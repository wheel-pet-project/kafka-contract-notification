namespace NotificationKafkaEvents;

public class PasswordRecoverTokenCreated
{
    private PasswordRecoverTokenCreated(){}

    public PasswordRecoverTokenCreated(Guid eventId, string emailAddress, string recoveryUrl) : this()
    {
        EventId = eventId;
        EmailAddress = emailAddress;
        RecoveryUrl = recoveryUrl;
    }

    public Guid EventId { get; private set; }

    public string EmailAddress { get; private set; } = null!;
    
    public string RecoveryUrl { get; private set; } = null!;
};