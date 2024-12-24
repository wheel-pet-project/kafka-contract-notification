namespace NotificationKafkaMessages;

public record SendRecoverPasswordEmailMessage(
    string ToAddress, 
    string RecoveryUrl);