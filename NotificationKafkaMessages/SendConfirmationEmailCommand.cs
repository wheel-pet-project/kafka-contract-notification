namespace NotificationMessages;

public record SendConfirmationEmailCommand(
    string ToEmail, 
    string ConfirmationUrl);