namespace To.NotificationKafkaEvents;

public class ConfirmationTokenCreated
{
    private ConfirmationTokenCreated(){}
    
    public ConfirmationTokenCreated(Guid eventId, string emailAddress, string confirmationUrl) : this()
    {
        EventId = eventId;
        EmailAddress = emailAddress;
        ConfirmationUrl = confirmationUrl;
    }
    
    public Guid EventId { get; private set; }

    public string EmailAddress { get; private set; } = null!;
    
    public string ConfirmationUrl { get; private set; } = null!;
}