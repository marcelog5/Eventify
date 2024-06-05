using Application.Abstractions.Messaging;

namespace Application.Users.Login
{
    public record LoginCommand(string Email) : ICommand<string>
    {
    }
}
