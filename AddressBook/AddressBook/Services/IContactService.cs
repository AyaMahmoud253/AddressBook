using AddressBook.DTOs;
using AddressBook.Models;

namespace AddressBook.Services
{
    public interface IContactService
    {
        ContactDTO CreateContact(ContactDTO newContact);
        bool DeleteContact(int id);
        List<ContactDTO> GetAllContacts();
        ContactDTO GetContactById(int id);
        ContactDTO UpdateContact(ContactDTO updateContact);
    }
}