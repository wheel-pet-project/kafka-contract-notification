namespace NotificationKafkaEvents;

public record ConfirmationTokenCreated(
    string EmailAddress, 
    string ConfirmationUrl);