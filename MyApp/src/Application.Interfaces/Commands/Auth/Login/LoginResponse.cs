﻿namespace MyApp.Application.Interfaces.Commands.Auth.Login;

public record LoginResponse(string AccessToken, string RefreshToken);
