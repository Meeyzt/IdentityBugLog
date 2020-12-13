using System.ComponentModel.DataAnnotations;

namespace IdentityBugLog.Models
{
    public class Role
    {
        [Required]
        public string RoleName { get; set; }
        
    }
}
