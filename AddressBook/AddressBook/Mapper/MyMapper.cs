using AddressBook.DTOs;
using AddressBook.Models;
using AddressBook.DTOs;
using AddressBook.Models;

namespace AddressBook.Mapper
{
    public class MyMapper
    {
        public ContactDTO ToContactDTO(Contact contact)
        {
            var contactDTO = new ContactDTO();
            contactDTO.Id = contact.Id;
            contactDTO.FirstName = contact.FirstName;
            contactDTO.LastName = contact.LastName;
            contactDTO.PhoneNumber = contact.PhoneNumber;
            contactDTO.Address = contact.Address;

            return contactDTO;
        }

        public List<ContactDTO> ToContactDTOList(List<Contact> contacts)
        {

            List<ContactDTO> contactsDTO = new List<ContactDTO>();

            contacts.ForEach(contact =>
            {
                var contactDTO = new ContactDTO();
                contactDTO.Id = contact.Id;
                contactDTO.FirstName = contact.FirstName;
                contactDTO.LastName = contact.LastName;
                contactDTO.PhoneNumber = contact.PhoneNumber;
                contactDTO.Address = contact.Address;

                contactsDTO.Add(contactDTO);
            });

            return contactsDTO;
        }
    }
}