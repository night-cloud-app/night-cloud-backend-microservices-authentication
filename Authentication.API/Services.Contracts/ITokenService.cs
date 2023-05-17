﻿using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Authentication.API.Services.Contracts;

public interface ITokenService
{
    JwtSecurityToken CreateToken(List<Claim> authClaims);
    string GenerateRefreshToken();
    ClaimsPrincipal GetPrincipaFromExpiredToken(string token);
}