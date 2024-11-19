namespace NotificationKafkaMessages;

public record SendConfirmationEmailCommand(
    string ToAddress, 
    string ConfirmationUrl);