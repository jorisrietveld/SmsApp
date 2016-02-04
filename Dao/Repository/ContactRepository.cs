using System;
using SmsApp.Dao.Entity;
using System.Collections.Generic;

namespace SmsApp.Dao.Repository
{
	public interface ContactRepository
	{
		Contact getContactById( UInt32 id );
		List<Contact> getAllContacts( );
		List<Contact> getContactsByTelephoneNumber( string telephoneNumber );
		List<Contact> getContactsByFirstName (string firstName);
		List<Contact> getContactsByLastName (string lastName);
		List<Contact> getContactsByEmail (string email);

		void insertContact ( Contact message);
		void deleteContact ( Contact message);
		void updateContact ( Contact message);
	}
}

