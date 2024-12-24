namespace NotificationKafkaMessages;

public record SendConfirmationEmailMessage(
    string ToAddress, 
    string ConfirmationUrl);