namespace Messages;

public record SendConfirmationEmail(
    string ToEmail, 
    string ConfirmationUrl);