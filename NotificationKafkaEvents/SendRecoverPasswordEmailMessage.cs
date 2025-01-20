namespace NotificationKafkaEvents;

public class PasswordRecoverTokenCreated
{
    private PasswordRecoverTokenCreated(){}

    public PasswordRecoverTokenCreated(Guid eventId, string emailAddress, string recoveryUrl)
    {
        EventId = eventId;
        EmailAddress = emailAddress;
        RecoveryUrl = recoveryUrl;
    }

    public Guid EventId { get; init; }
    
    public string EmailAddress { get; init; }
    
    public string RecoveryUrl { get; init; }
};