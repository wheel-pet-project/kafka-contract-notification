namespace NotificationKafkaEvents;

public class ConfirmationTokenCreated
{
    private ConfirmationTokenCreated(){}
    
    public ConfirmationTokenCreated(Guid eventId, string emailAddress, string confirmationUrl)
    {
        EventId = eventId;
        EmailAddress = emailAddress;
        ConfirmationUrl = confirmationUrl;
    }
    
    public Guid EventId { get; init; }
    
    public string EmailAddress { get; init; }
    
    public string ConfirmationUrl { get; init; }
}