﻿namespace ExamScheduleSystem.DTO
{
    public class UserDTO
    {
        public string Status { get; set; }
        public string Email { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string RoleId { get; set; }
    }
}
