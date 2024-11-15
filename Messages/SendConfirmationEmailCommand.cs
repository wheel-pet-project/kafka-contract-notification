namespace Messages;

public record SendConfirmationEmailCommand(
    string ToEmail, 
    string ConfirmationUrl);