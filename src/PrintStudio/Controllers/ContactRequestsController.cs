using Microsoft.AspNetCore.Mvc;
using PrintStudio.Models;
using PrintStudio.Services;

namespace PrintStudio.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContactRequestsController(IContactService contactService) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<ContactRequest>> Create(ContactRequest request)
    {
        if (!ModelState.IsValid)
        {
            return ValidationProblem(ModelState);
        }

        var created = await contactService.CreateAsync(request);
        return Ok(created);
    }
}
