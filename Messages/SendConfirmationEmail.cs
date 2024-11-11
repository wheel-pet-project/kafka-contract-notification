namespace Messages;

public record SendConfirmationEmail(
    Guid ConfirmationId,
    string ToEmail, 
    string ConfirmationUrl);