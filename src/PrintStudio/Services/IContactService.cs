using PrintStudio.Models;

namespace PrintStudio.Services;

public interface IContactService
{
    Task<ContactRequest> CreateAsync(ContactRequest request);
}
