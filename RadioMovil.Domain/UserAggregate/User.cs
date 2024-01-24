using RadioMovil.Domain.Common.Models;
using RadioMovil.Domain.UserAggregate.Events;
using RadioMovil.Domain.UserAggregate.ValueObjects;

namespace RadioMovil.Domain.UserAggregate;

public sealed class User : AggregateRoot<UserId>
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public string Type {get; private set;}
    public Password Password { get; private set; }

    private User(
        UserId userId,
        string firstName,
        string lastName,
        string email,
        string type,
        Password password
    ) : base(userId)
    {
        Id = userId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Type = type;
        Password = password;
    }

    public static User Create(
        string firstName,
        string lastName,
        string email,
        string type,
        Password password
    )
    {
        var user = new User(
            UserId.CreateUnique(),
            firstName,
            lastName,
            email,
            type,
            password
        );

    }

#pragma warning disable CS8618
    private User()
    {
    }
#pragma warning restore CS8618

}