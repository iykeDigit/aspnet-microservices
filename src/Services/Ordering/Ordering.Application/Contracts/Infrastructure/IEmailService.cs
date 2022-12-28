using Ordering.Application.Models;

namespace Ordering.API.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
