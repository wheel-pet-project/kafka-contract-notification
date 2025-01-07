namespace NotificationKafkaEvents;

public record PasswordRecoverTokenCreated(
    string EmailAddress, 
    string RecoveryUrl);