﻿using System.ComponentModel.DataAnnotations;

namespace Auth.API.Models.DTOs
{
    public class RoleCreateDTO
    {
        [MaxLength(20)]
        public string RoleName { get; set; }
    }
}