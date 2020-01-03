using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace AddressBook
{

	[SerializableAttribute]
    public class Contact : IComparable
	{
		private String _lastName;
		private String _firstName;
		private String _middleInitial;
		private String _address;
		private String _addressExt;
		private String _city;
        private String _prov;
		private CA_Province _province;
		private String _country;
        private US_State _state;
		private String _postalCode;
		private String _phonePrimary;
		private String _phoneAlternate;
		private DateTime _birthday;
		private Image _portrait;
		private List<Image> _portraits = new List<Image>();
		private string[] _filePaths;
		private string[] _imagePaths;
        private String _email;
		private Image _mapImage;

		public Contact()
		{
			_lastName = "*";
			_firstName = "*";
			_birthday = new DateTime(1900, 1, 1);
		}

        /// <summary>
        /// Updates contact data.
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <param name="middleInitial"></param>
        /// <param name="address"></param>
        /// <param name="addressExt"></param>
        /// <param name="city"></param>
		/// <param name="province"></param>
        /// <param name="country"></param>
        /// <param name="state"></param>
        /// <param name="postalCode"></param>
        /// <param name="phonePrimary"></param>
        /// <param name="phoneAlternate"></param>
        /// <param name="birthday"></param>
        /// <param name="portrait"></param>
        /// <param name="resultString"></param>
        /// <returns>true if data is properly formatted, false otherwise</returns>
        public void Save(String lastName, String firstName,
			String middleInitial, String address, String addressExt,
			String city, CA_Province province, String country, String postalCode,
			String phonePrimary, String phoneAlternate, DateTime birthday,
			String email)
		{
			/* Save non-validated fields */
			_lastName = lastName.Trim();
			_firstName = firstName.Trim();
			_middleInitial = middleInitial.Trim().ToUpper();
			_address = address.Trim();
			_addressExt = addressExt.Trim();
			_city = city.Trim();
			_province = province;
			_country = country.Trim();
            //_state = state;
            _birthday = birthday;
			
			/* Save validated fields */
			_phonePrimary = GetPhoneNumberIfValid(phonePrimary);
			_phoneAlternate = GetPhoneNumberIfValid(phoneAlternate);
			_postalCode = GetPostalCodeIfValid(postalCode);
			_email = GetEmailAddressIfValid(email);

			/* Update address map */
			if (_address != String.Empty && _city != String.Empty && _state != null)
			{
				//_mapImage = MapAddress.GetImage(_address, _city, _state);
			}
		}

		private static String GetPostalCodeIfValid(String source)
		{
			return Utilities.getRegexMatch(source, @"^\d{5}$"); /* Postal codes are 5-digit numbers */
		}

		private static String GetPhoneNumberIfValid(String source)
		{
			return Utilities.getRegexMatch(source, @"^\d{7}(\d{3})?$"); /* phone numbers have 7 or 10 digits */
		}

		private static String GetEmailAddressIfValid(String source)
		{
			return Utilities.getRegexMatch(source, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$"); /* */
		}

		#region IComparable Members

		/// <summary>
		/// Compares LastName, FirstName, and MiddleInitial using standard string comparison.
		/// </summary>
		/// <param name="contactAsObject"></param>
		/// <returns></returns>
		public int CompareTo(object contactAsObject)
		{
			int result;

			Contact contact = (Contact)contactAsObject;

			result = String.Compare(this.LastName, contact.LastName);
			if (0 != result)
				return result;

			result = String.Compare(this.FirstName, contact.FirstName);
			if (0 != result)
				return result;

			result = String.Compare(this.MiddleInitial, contact.MiddleInitial);
			if (0 != result)
				return result;

			return result;
		}

        #endregion

        #region Properties
        public String Name
		{
			get { return String.Format("{0}, {1} {2}.", _lastName, _firstName, _middleInitial); }
		}
        [CsvColumn(Name = "LastName")]
        public String LastName
		{
			get { return _lastName; }
		}
        [CsvColumn(Name = "FirstName")]
        public String FirstName
		{
			get { return _firstName; }
		}
        [CsvColumn(Name = "MiddleInitial")]
        public String MiddleInitial
		{
			get { return _middleInitial; }
		}
        [CsvColumn(Name = "Address")]
        public String Address
		{
			get { return _address; }
		}
        [CsvColumn(Name = "AddressExt")]
        public String AddressExt
		{
			get { return _addressExt; }
		}
        [CsvColumn(Name = "City")]
        public String City
		{
			get { return _city; }
		}
        public CA_Province Province
        {
            get { return _province; }
        }
        [CsvColumn(Name = "Province")]
        public string Prov
        {
            get { return _province.Name; }
        }
        //public String Province
        //{
        //    get { return _province; }
        //}
        [CsvColumn(Name = "Country")]
        public String Country
        {
            get { return _country; }
        }

  //      public US_State State
		//{
		//	get { return _state; }
		//}

        [CsvColumn(Name = "PostalCode")]
        public String PostalCode
		{
			get { return _postalCode; }
		}
        [CsvColumn(Name = "Birthday", OutputFormat = "dd MMM yy")]
        public DateTime Birthday
		{
			get { return _birthday; }
		}
        [CsvColumn(Name = "PhonePrimary")]
        public String PhonePrimary
		{
			get { return _phonePrimary; }
		}
        [CsvColumn(Name = "PhoneAlternate")]
        public String PhoneAlternate
		{
			get { return _phoneAlternate; }
		}
        public Image[] Portraits
		{
			get { return _portraits.ToArray(); }
			set { _portraits = value.ToList(); }
		}
        public string[] ImagePaths
        {
            get { return _imagePaths; }
            set { _imagePaths = value; }
        }
        public string[] FilePaths
        {
            get { return _filePaths; }
            set { _filePaths = value; }
        }
        [CsvColumn(Name = "Email")]
        public String Email
		{
			get { return _email; }
		}
        public Image MapImage
		{
			get { return _mapImage; }
		}

        public String[] GetFileName(string[] paths)
        {
            List<String> names = new List<String>();
            if (paths != null)
            {
                foreach (string path in paths)
                {
                    names.Add(Path.GetFileName(path));
                }
            }

            return names.ToArray();
        }

        #endregion
    }
}
