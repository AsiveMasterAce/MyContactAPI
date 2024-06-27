using MyContactAPI.Models;

namespace MyContactAPI.Services
{
    public interface IContactService
    {
        Task<IEnumerable<Contact>> GetContactsAsync();
    }
}
