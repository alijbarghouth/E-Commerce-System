﻿using System.Text.Json.Serialization;

namespace E_Commerce_System.DTO.CustomerDto
{
    public class AuthModel
    {
        public string? Message { get; set; }

        public bool IsAuthenticated { get; set; }

        public string? Username { get; set; }

        public string? Email { get; set; }

        public string? Token { get; set; }

        public string Role { get; set; }

        public DateTime? TokenExpier { get; set; }

        public DateTime? TokenCreated { get; set;}

    }
}
