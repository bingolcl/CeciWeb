using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AddressBook
{
	class AddressBook
	{
		#region Singleton Implementation

		private static AddressBook instance;

		private AddressBook()
		{
			_contacts = new List<Contact>();

			/* Populate contacts from data */
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream stream = new FileStream("Contacts.dat", FileMode.OpenOrCreate);
			try
			{
				if (stream.Length > 0)
				{
					_contacts = (List<Contact>)formatter.Deserialize(stream);
				}
			}
			finally
			{
				stream.Close();
			}

			_contacts.Sort();
		}

		public static AddressBook Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new AddressBook();
				}
				
				return instance;
			}
		}

		#endregion

		private List<Contact> _contacts;

		/// <summary>
		/// Add a new contact to the Address Book
		/// </summary>
		/// <returns>Array index of the newly added Contact</returns>
		public static int Add()
		{
			Contact newContact = new Contact();
			Instance._contacts.Add(newContact);
			Instance._contacts.Sort();

			return Instance._contacts.IndexOf(newContact);
		}

		/// <summary>
		/// Get a contact by index from the AddressBook
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public static Contact Load(int index)
		{
			return Instance._contacts[index];
		}
		
		/// <summary>
		/// Save all contact data to the program's internal data file
		/// </summary>
		public static void SaveToDataFile()
		{
			FileStream stream = new FileStream("Contacts.dat", FileMode.Create);
			BinaryFormatter formatter = new BinaryFormatter();

			try
			{
				formatter.Serialize(stream, Instance.Contacts);
			}
			finally
			{
				stream.Close();
			}
		}

		/// <summary>
		/// Remove a contact from the AddressBook
		/// </summary>
		/// <param name="contact"></param>
		public static void Remove(Contact contact)
		{
			Instance._contacts.Remove(contact);
			Instance._contacts.Sort();
		}

		#region Properties

		public List<String> NameArray
		{
			get
			{
				List<String> names = new List<String>();
				foreach (Contact contact in Contacts)
				{
					names.Add(contact.Name);
				}

				return names;
			}
		}
	
		public List<Contact> Contacts
		{
			get { return _contacts; }
		}

		#endregion
	}
}
