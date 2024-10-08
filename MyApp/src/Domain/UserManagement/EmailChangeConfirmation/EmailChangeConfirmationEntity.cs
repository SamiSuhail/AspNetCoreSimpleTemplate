﻿using MyApp.Domain.Auth.User;
using MyApp.Domain.Shared;
using MyApp.Domain.Shared.Confirmations;

namespace MyApp.Domain.Auth.EmailChangeConfirmation;

public class EmailChangeConfirmationEntity : ICreationAudited, IOwnedByUser
{
    public int Id { get; private set; }
    public int UserId { get; private set; }
    public string OldEmailCode { get; private set; } = default!;
    public string NewEmailCode { get; private set; } = default!;
    public DateTime CreatedAt { get; private set; }
    public string NewEmail { get; private set; } = default!;

    public UserEntity User { get; private set; } = default!;

    public static EmailChangeConfirmationEntity Create(int userId, string newEmail)
    {
        return new()
        {
            UserId = userId,
            NewEmail = newEmail,
            OldEmailCode = ConfirmationCodeGenerator.GenerateCode(),
            NewEmailCode = ConfirmationCodeGenerator.GenerateCode(),
            CreatedAt = DateTime.UtcNow,
        };
    }
}
