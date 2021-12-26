using MailKit;

namespace spamfilter.Interfaces;

/// <summary>
/// This interface contains all necessary information about the mails that we need to operate on
/// </summary>
public interface IEmail
{
    string SenderName { get; }
    string SenderEmailaddress { get; }
    
    UniqueId Id { get; }
    string Subject { get; }
    string Body { get; }
}