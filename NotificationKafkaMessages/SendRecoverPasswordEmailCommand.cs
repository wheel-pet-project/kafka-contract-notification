namespace NotificationMessages;

public record SendRecoverPasswordEmailCommand(
    string ToEmail, 
    string RecoveryUrl);