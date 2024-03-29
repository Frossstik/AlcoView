﻿using Microsoft.AspNetCore.Identity;

namespace AlcoView.Data.DTOs
{
    public class ChangeRoleDto
    {
        public string UserId { get; set; }
        public string UserEmail { get; set; }
        public List<IdentityRole> AllRoles { get; set; }
        public IList<string> UserRoles { get; set; }
        public ChangeRoleDto()
        {
            AllRoles = new List<IdentityRole>();
            UserRoles = new List<string>();
        }
    }
}
