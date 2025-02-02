﻿namespace ProyectosDGTIC.Auth
{
    public class JwtTokenOptions
    {
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string Key { get; set; }
        public string Subject { get; set; }
        public int DurationMinutes { get; set; } = 1;
    }
}