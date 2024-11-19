namespace NotificationKafkaMessages;

public record SendRecoverPasswordEmailCommand(
    string ToAddress, 
    string RecoveryUrl);