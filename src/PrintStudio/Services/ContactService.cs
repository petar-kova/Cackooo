using PrintStudio.Data;
using PrintStudio.Models;

namespace PrintStudio.Services;

public class ContactService(AppDbContext db) : IContactService
{
    public async Task<ContactRequest> CreateAsync(ContactRequest request)
    {
        request.CreatedAtUtc = DateTime.UtcNow;
        db.ContactRequests.Add(request);
        await db.SaveChangesAsync();
        return request;
    }
}
