﻿using Middlewares.ExceptionHandling.Exceptions;

namespace Authentication.API.Exceptions.Unauthorized;

public class InvalidUserPasswordUnauthorized : UnauthorizedException
{
    public InvalidUserPasswordUnauthorized(string username) : base(
        $"User '{username}' tried to log with invalid password")
    {
        
    }
}