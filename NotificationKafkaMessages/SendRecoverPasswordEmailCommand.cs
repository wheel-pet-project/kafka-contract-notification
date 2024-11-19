namespace NotificationKafkaMessages;

public record SendRecoverPasswordEmailCommand(
    string ToEmail, 
    string RecoveryUrl);