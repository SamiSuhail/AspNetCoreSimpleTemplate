﻿using MyApp.Server.Domain.Auth.User;

namespace MyApp.Server.Domain.Auth.EmailConfirmation.Failures;

public class ResendConfirmationInvalidFailure : DomainFailure
{
    public const string Key = nameof(UserEntity.Email);
    public const string Message = "No user with this email is awaiting confirmation.";

    private ResendConfirmationInvalidFailure() : base() { }
    public static DomainException Exception()
        => new ResendConfirmationInvalidFailure()
            .AddError(Key, Message)
            .ToException();
}
