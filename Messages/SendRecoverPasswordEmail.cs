namespace Messages;

public record SendRecoverPasswordEmail(
    string ToEmail, 
    string RecoveryUrl);