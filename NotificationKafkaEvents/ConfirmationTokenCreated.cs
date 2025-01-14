namespace NotificationKafkaEvents;

public record ConfirmationTokenCreated(
    Guid EventId,
    string EmailAddress, 
    string ConfirmationUrl);