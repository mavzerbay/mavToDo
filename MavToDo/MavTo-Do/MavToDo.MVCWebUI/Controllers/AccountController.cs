using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MavToDo.Business.Abstract;
using MavToDo.Business.Concrete;
using MavToDo.MVCWebUI.Entities;
using MavToDo.MVCWebUI.Models.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace MavToDo.MVCWebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<MavIdentityUser> _userManager;
        private readonly SignInManager<MavIdentityUser> _signInManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public AccountController(UserManager<MavIdentityUser> userManager,
            SignInManager<MavIdentityUser> signInManager,
            IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager; 
            _signInManager = signInManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public ActionResult Login()
        {
            return View();  
        }
        [HttpPost,ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginViewModel);
            }

            var user = await _userManager.FindByNameAsync(loginViewModel.UserName);
            var userId = user.Id;
            if (user!=null)
            {
                
                if (!await _userManager.IsEmailConfirmedAsync(user) )
                {
                    ModelState.AddModelError(string.Empty,"Confirm your email please!");
                    return View(loginViewModel);
                }
            }

            var result = await _signInManager.PasswordSignInAsync(loginViewModel.UserName, loginViewModel.Password,
                loginViewModel.RememberMe, false);

            if (result.Succeeded)
            { 
                HttpContext.Session.SetString("userId",userId);
                HttpContext.Session.SetString("userName",loginViewModel.UserName);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError(string.Empty,"Login Failed");
            return View(loginViewModel);
        }

        public async Task<ActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

        public ActionResult AccessDenied()
        {
            TempData.Add("message","Access Denied");
            return RedirectToAction("Login", "Account");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel registerViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(registerViewModel);
            }
            var user = new MavIdentityUser
            {
                UserName = registerViewModel.UserName,
                FirstName = registerViewModel.FirstName,
                LastName = registerViewModel.LastName,
                Email = registerViewModel.Email
            };
            if (registerViewModel.Password!=registerViewModel.ConfirmPassword)
            {
                ModelState.AddModelError("confirmError","Passwords do not match!");
                return View(registerViewModel);
            }

            var result = _userManager.CreateAsync(user, registerViewModel.Password).Result;
            if (result.Succeeded)
            {
                var confirmationCode = _userManager.GenerateEmailConfirmationTokenAsync(user);
                var callBackUrl = Url.Action("ConfirmEmail", "Account",
                    new {userId = user.Id, code = confirmationCode.Result});

                var myUrl =
                    $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}";

                var message = new MimeMessage();

                message.From.Add(new MailboxAddress("Erbay MAVZER", "erbaymavzer35@gmail.com"));

                message.To.Add(new MailboxAddress(registerViewModel.FirstName, registerViewModel.Email));

                message.Subject = $"Welcome {registerViewModel.FirstName}, your mail verification code";

                message.Body = new TextPart("plain")
                {
                    Text =myUrl+callBackUrl
                };
                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("erbaymavzer35@gmail.com", "konal421");
                    client.Send(message);
                    client.Disconnect(true);
                }

                return RedirectToAction("Login");
            }

            return View(registerViewModel);
        }

        public async Task<ActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId==null||code==null)
            {
                TempData.Add("message","User or verification code not found.");
                return RedirectToAction("Login","Account");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user==null)
            {
                TempData.Add("message","No such user found.");
                return RedirectToAction("Login","Account");
            }

            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
            {
                return View("ConfirmEmail");
            }

            return RedirectToAction("Index", "Home");
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost,ValidateAntiForgeryToken]
        public async Task<ActionResult> ForgotPassword(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return View();
            }

            var user = await _userManager.FindByEmailAsync(email);
            if (user==null)
            {
                return View();
            }

            var confirmationCode = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callBackUrl = Url.Action("ResetPassword", "Account", new {userId = user.Id, code = confirmationCode});

            var myUrl =
                $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}";

            var message = new MimeMessage();

            message.From.Add(new MailboxAddress("Erbay MAVZER", "erbaymavzer35@gmail.com"));

            message.To.Add(new MailboxAddress(user.FirstName, user.Email));

            message.Subject = $"Welcome {user.FirstName}, here your code for reset to your password";

            message.Body = new TextPart("plain")
            {
                Text = myUrl + callBackUrl
            };
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("erbaymavzer35@gmail.com", "konal421");
                client.Send(message);
                client.Disconnect(true);
            }

            return RedirectToAction("ForgotPasswordEmailSend","Account");
        }

        public ActionResult ForgotPasswordEmailSend()
        {
            TempData.Add("message","Please check your email to reset your password!!!");
            return RedirectToAction("Login","Account");
        }

        public ActionResult ResetPassword(string userId, string code)
        {
            if (userId==null||code==null)
            {
                throw new ApplicationException("User id or code must be supplied for password reset");
            }
            var model = new ResetPasswordViewModel();
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<ActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(resetPasswordViewModel);
            }

            var user = await _userManager.FindByEmailAsync(resetPasswordViewModel.Email);
            if (user==null)
            {
                throw new ApplicationException("User not found!");
            }

            var result =
                await _userManager.ResetPasswordAsync(user, resetPasswordViewModel.Code,
                    resetPasswordViewModel.Password);
            if (result.Succeeded)
            {
                if (resetPasswordViewModel.Password == resetPasswordViewModel.ConfirmPassword)
                {
                    TempData.Add("message","Your password has been reset!");
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("confirm","Passwords do not match");
                return View(resetPasswordViewModel);
            }

            return View();
        }


    }
}