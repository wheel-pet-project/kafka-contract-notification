namespace NotificationKafkaEvents;

public record PasswordRecoverTokenCreated(
    Guid EventId,
    string EmailAddress, 
    string RecoveryUrl);