﻿namespace Application.Requests.Users.Commands.RefreshToken
{
    public class TokenRequestDto
    {
        public string JwtToken { get; set; }
        public string RefreshToken { get; set; }
    }
}