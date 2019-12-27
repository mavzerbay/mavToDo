using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MavToDo.MVCWebUI.Entities
{
    public class MavIdentityDbContext:IdentityDbContext<MavIdentityUser,MavIdentityRole,string>
    {
        public MavIdentityDbContext(DbContextOptions<MavIdentityDbContext>options):base(options)
        {
            
        }
    }
}
