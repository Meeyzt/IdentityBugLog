using IdentityBugLog.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityBugLog.Models
{
    public class RoleEdit
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<UserIdentity> Members { get; set; }
        public IEnumerable<UserIdentity> NonMembers { get; set; }
    }
}
