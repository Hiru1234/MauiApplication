﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTest.Models
{
    public static class ContactRepository
    {
        public static List<Contact> _contacts = new List<Contact>() {
            new Contact {ContactId = 1, Name="John Doe", Email= "johndoe@gmail.com"},
            new Contact {ContactId = 2, Name="Jane Doe", Email= "janedoe@gmail.com"},
            new Contact {ContactId = 3, Name="Tom Hanks", Email= "tomHanks@gmail.com"},
            new Contact {ContactId = 4, Name="Frank Carson", Email= "frankCarson@gmail.com"},
        };

        public static List<Contact> GetContacts() => _contacts;

        public static Contact GetContactById(int contactId) {
            var contact = _contacts.FirstOrDefault( x => x.ContactId == contactId);
            if (contact != null) {
                return new Contact
                {
                    ContactId = contactId,
                    Address = contact.Address,
                    Email = contact.Email,
                    Name = contact.Name,
                    Phone = contact.Phone,
                };
            }
            return null;
        }

        public static void UpdateContact
            (int contactId, Contact contact)
        {
            if (contactId != contact.ContactId) return;

            var contactToUpdate = _contacts.FirstOrDefault(x => x.ContactId == contactId);
            if (contactToUpdate != null) {
                contactToUpdate.Address = contact.Address;
                contactToUpdate.Email = contact.Email;
                contactToUpdate.Name = contact.Name;
                contactToUpdate.Phone = contact.Phone;
            }

            //    contactToUpdate = GetContactById(contactId); 
            //if (contactToUpdate != null)
            //{
            //    contactToUpdate.Address = contact.Address;
            //    contactToUpdate.Email = contact.Email;
            //    contactToUpdate.Name = contact.Name;
            //    contactToUpdate.Phone = contact.Phone;
            //}

        }
    }
}
