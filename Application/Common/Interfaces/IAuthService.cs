﻿using Application.Common.Models;
using Application.Requests.Users.Commands.RefreshToken;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IAuthService
    {
        Task<AuthResult> GenerateJwtTokens(string email);
        Task<AuthResult> ValidateAndCreateTokensAsync(TokenRequestDto tokenRequest);
    }
}