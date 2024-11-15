namespace Messages;

public record SendRecoverPasswordEmailCommand(
    string ToEmail, 
    string RecoveryUrl);