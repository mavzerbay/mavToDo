using Microsoft.AspNetCore.Http;

namespace MavToDo.MVCWebUI.Models
{
    public class UserDetailsViewModel
    {
        public string UserName { get; set; }
        public string UserId { get; internal set; }
    }
}