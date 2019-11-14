using System;
using System.Drawing;
using System.Windows.Forms;

namespace AddressBook
{
	public partial class AddressBookForm : Form
	{
		public AddressBookForm()
		{
			InitializeComponent();
			Initialize();
		}

		private void Initialize()
		{
			//cobProv.DataSource = StateArray.Abbreviations();
			PopulateContactListBox();
		}
		
		private void PopulateContactListBox()
		{
			contactListBox.Items.Clear();
			contactListBox.Items.AddRange(AddressBook.Instance.NameArray.ToArray());
		}

		private void SetComponentControlsEnabled(AddressBookFormGUIComponents component)
		{
			SetEditControlsEnabled(component == AddressBookFormGUIComponents.ContactEditForm);
			SetContactListBoxControls(component == AddressBookFormGUIComponents.ContactListBox);
		}

		private void SetEditControlsEnabled(bool enabled)
		{
			lastNameTextBox.Enabled = enabled;
			firstNameTextBox.Enabled = enabled;
			middleInitialTextBox.Enabled = enabled;
			addressTextBox.Enabled = enabled;
			addressExtTextBox.Enabled = enabled;
			cityTextBox.Enabled = enabled;
			txtProvince.Enabled = enabled;
			txtCountry.Enabled = enabled;
            postalCodeTextBox.Enabled = enabled;
			phoneNumberPrimaryTextBox.Enabled = enabled;
			phoneNumberAlternateTextBox.Enabled = enabled;
            //cobProv.Enabled = enabled;
            btnCancel.Enabled = enabled;
			saveContactButton.Enabled = enabled;
			birthdayDateTimePicker.Enabled = enabled;
			emailTextBox.Enabled = enabled;
			selectPhotoButton.Enabled = enabled;
			deletePhotoButton.Enabled = enabled;
		}

		private void SetContactListBoxControls(bool enabled)
		{
			contactListBox.Enabled = enabled;
			addContactButton.Enabled = enabled;
			editContactButton.Enabled = enabled;
			deleteContactButton.Enabled = enabled;
		}

		private void PopulateEditControls(Contact contact)
		{
			lastNameTextBox.Text = contact.LastName;
			firstNameTextBox.Text = contact.FirstName;
			addressTextBox.Text = contact.Address;
			addressExtTextBox.Text = contact.AddressExt;
			cityTextBox.Text = contact.City;
			txtProvince.Text = contact.Province;
			txtCountry.Text = contact.Country;
            postalCodeTextBox.Text = contact.PostalCode;
			phoneNumberPrimaryTextBox.Text = contact.PhonePrimary;
			phoneNumberAlternateTextBox.Text = contact.PhoneAlternate;
			birthdayDateTimePicker.Value = contact.Birthday;
			emailTextBox.Text = contact.Email;
			portraitPictureBox.Image = contact.Portrait;
			mapPictureBox.Image = contact.MapImage;
			middleInitialTextBox.Text = contact.MiddleInitial;

			if (contact.State != null)
			{
				//cobProv.SelectedIndex = cobProv.FindStringExact(contact.State.Abbreviation);
			}
		}

		private void ClearEditControls()
		{
			lastNameTextBox.Text = String.Empty;
			firstNameTextBox.Text = String.Empty;
			middleInitialTextBox.Text = String.Empty;
			addressTextBox.Text = String.Empty;
			addressExtTextBox.Text = String.Empty;
			cityTextBox.Text = String.Empty;
			txtProvince.Text = String.Empty;
			txtCountry.Text = String.Empty;
            postalCodeTextBox.Text = String.Empty;
			phoneNumberPrimaryTextBox.Text = String.Empty;
			phoneNumberAlternateTextBox.Text = String.Empty;
			emailTextBox.Text = String.Empty;

			portraitPictureBox.Image = null;

			birthdayDateTimePicker.Value = new DateTime(1900, 1, 1);

			//cobProv.SelectedIndex = cobProv.FindStringExact(StateArray.Abbreviations()[0]);
		}

		private void EditSelectedContact()
		{
			if (contactListBox.SelectedIndex == -1)
				return;

			/* Populate the data from the contact into the GUI */
			PopulateEditControls(AddressBook.Instance.Contacts[contactListBox.SelectedIndex]);

			/* Disable contactListBox so user cannot change selection */
			contactListBox.Enabled = false;

			/* Enable editing controls */
			SetComponentControlsEnabled(AddressBookFormGUIComponents.ContactEditForm);
		}

		#region Event Handlers
		private void editContactButton_Click(object sender, EventArgs e)
		{
			EditSelectedContact();
		}

		private void saveContactButton_Click(object sender, EventArgs e)
		{
			Contact selected = AddressBook.Instance.Contacts[contactListBox.SelectedIndex];

			selected.Save(lastNameTextBox.Text, firstNameTextBox.Text, middleInitialTextBox.Text,
				addressTextBox.Text, addressTextBox.Text, cityTextBox.Text, txtProvince.Text,txtCountry.Text,
				postalCodeTextBox.Text, phoneNumberPrimaryTextBox.Text, phoneNumberAlternateTextBox.Text,
				birthdayDateTimePicker.Value, emailTextBox.Text);

			/* Repopulate the data to show any changes from the saving process */
			PopulateEditControls(AddressBook.Instance.Contacts[contactListBox.SelectedIndex]);

			AddressBook.Instance.Contacts.Sort();
			PopulateContactListBox();
			SetComponentControlsEnabled(AddressBookFormGUIComponents.ContactListBox);

			AddressBook.SaveToDataFile();
		}
        private void btnCancel_Click(object sender, EventArgs e)
        {
            /* Repopulate the data to show any changes from the saving process */
            PopulateEditControls(AddressBook.Instance.Contacts[contactListBox.SelectedIndex]);
            SetComponentControlsEnabled(AddressBookFormGUIComponents.ContactListBox);
        }

        private void contactListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (contactListBox.SelectedIndex == -1)
			{
				return;
			}

			PopulateEditControls(AddressBook.Instance.Contacts[contactListBox.SelectedIndex]);
		}

		private void contactListBox_DoubleClick(object sender, EventArgs e)
		{
			EditSelectedContact();
		}

		private void addContactButton_Click(object sender, EventArgs e)
		{
			// Add a new entry to the AddressBook
			int newContactIndex = AddressBook.Add();

			// Update the contact list
			PopulateContactListBox();

			// Open the new contact for editing
			contactListBox.SelectedIndex = newContactIndex;
			EditSelectedContact();
		}

		private void deleteContactButton_Click(object sender, EventArgs e)
		{
			if (contactListBox.SelectedIndex == -1)
				return;

			ClearEditControls();

			int selectedInstace = contactListBox.SelectedIndex;
			AddressBook.Instance.Contacts.Remove(AddressBook.Instance.Contacts[selectedInstace]);

			PopulateContactListBox();
			contactListBox.SelectedIndex = selectedInstace;
		}

		private void selectPhotoButton_Click(object sender, EventArgs e)
		{
			Contact selectedContact = AddressBook.Instance.Contacts[contactListBox.SelectedIndex];
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				DialogResult result = dialog.ShowDialog();

				if (result == DialogResult.OK)
				{
					if (dialog.CheckFileExists)
					{
						portraitPictureBox.Image = selectedContact.Portrait = Image.FromFile(dialog.FileName);
					}
				}
			}
		}

		private void deletePhotoButton_Click(object sender, EventArgs e)
		{
			Contact selectedContact = AddressBook.Instance.Contacts[contactListBox.SelectedIndex];
			selectedContact.Portrait = null;
			portraitPictureBox.Image = selectedContact.Portrait;
		}
        #endregion


    }
}
