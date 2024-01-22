using AlcoView.Data.Models.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AlcoView.Data.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
