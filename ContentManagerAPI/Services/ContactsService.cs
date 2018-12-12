using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContentManagerAPI.Data;
using ContentManagerAPI.Models;


namespace ContentManagerAPI.Services
{
    public interface IContactsService
    {
        ContactsInfo GetContactsInfo(string name);
        string UpdateContactInfo(ContactsInfo info);
    }


    public class ContactsService : IContactsService
    {
        private readonly ContactsApiContext context;

        public ContactsService(ContactsApiContext ContactsApiContext)
        {
            context = ContactsApiContext;
        }


        public ContactsInfo GetContactsInfo(string name)
        {

            ContactsInfo info = context.ContactsInfo.Where(e => e.FirstName == name)
                 .OrderBy(e => e.FirstName)
                 .FirstOrDefault();
            return info;
        }

        public string UpdateContactInfo(ContactsInfo info)
        {
            if (ValidateContactInfo(info))
            {
                var CInfo = new ContactsInfo()
                {
                    FirstName = info.FirstName.ToLower(),
                    LastName = info.LastName.ToLower(),
                    PhoneNumber = info.PhoneNumber
                };

                if (!VerifyExistingRecords(info))
                {
                    context.ContactsInfo.Add(CInfo);
                    context.SaveChanges();
                    return "Records Inserted";
                }
                return "Record already exists";
            }
            return "Character in First Name or Last Name or Mobile number, exceeds allowed limit of 20 characters";

        }

        private bool ValidateContactInfo(ContactsInfo info)
        {
            if (info.FirstName.Length > 20 || info.LastName.Length > 20 || info.PhoneNumber.ToString().Length > 15)
                return false;
            return true;
        }

        private bool VerifyExistingRecords(ContactsInfo info)
        {
            if (context.ContactsInfo.Where(e =>
                        e.FirstName == info.FirstName.ToLower() && e.LastName == info.LastName.ToLower() && e.PhoneNumber == info.PhoneNumber)
                    .ToList().Count > 0)
                return true;
            return false;
        }


    }


}
