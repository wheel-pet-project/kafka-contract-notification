namespace NotificationKafkaMessages;

public record SendConfirmationEmailCommand(
    string ToEmail, 
    string ConfirmationUrl);