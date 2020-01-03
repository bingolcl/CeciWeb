using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace AddressBook
{
	public partial class AddressBookForm : Form
	{
		public AddressBookForm()
		{
			InitializeComponent();
            System.IO.Directory.CreateDirectory("photos");
            System.IO.Directory.CreateDirectory("files");
            Initialize();
		}

		private void Initialize()
		{
			cobProv.DataSource = ProvinceArray.Abbreviations();
			PopulateContactListBox();
            SetComponentControlsEnabled(AddressBookFormGUIComponents.ContactListBox);

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
			txtCountry.Enabled = enabled;
            postalCodeTextBox.Enabled = enabled;
			phoneNumberPrimaryTextBox.Enabled = enabled;
			phoneNumberAlternateTextBox.Enabled = enabled;
			cobProv.Enabled = enabled;
			saveContactButton.Enabled = enabled;
			btnCancel.Enabled = enabled;
            birthdayDateTimePicker.Enabled = enabled;
			emailTextBox.Enabled = enabled;
			selectPhotoButton.Enabled = enabled;
			deletePhotoButton.Enabled = enabled;
			listPhotos.Enabled = enabled;
            selectFileButton.Enabled = enabled;
            deleteFileButton.Enabled = enabled;
            listFiles.Enabled = enabled;
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
			txtCountry.Text = contact.Country;
            postalCodeTextBox.Text = contact.PostalCode;
			phoneNumberPrimaryTextBox.Text = contact.PhonePrimary;
			phoneNumberAlternateTextBox.Text = contact.PhoneAlternate;
			birthdayDateTimePicker.Value = contact.Birthday;
			emailTextBox.Text = contact.Email;
			//portraitPictureBox.Image = contact.Portraits[0];
			//mapPictureBox.Image = contact.MapImage;
			middleInitialTextBox.Text = contact.MiddleInitial;

			if (contact.Province != null)
			{
				cobProv.SelectedIndex = cobProv.FindStringExact(contact.Province.Abbreviation);
			}
            PopulateContactPhotoList(contact);
            PopulateContactFileList(contact);

        }

        private void PopulateContactPhotoList(Contact contact)
        {
            listPhotos.Items.Clear();
            listPhotos.Items.AddRange(contact.GetFileName(contact.ImagePaths));
        }

        private void PopulateContactFileList(Contact contact)
        {
            listFiles.Items.Clear();
            listFiles.Items.AddRange(contact.GetFileName(contact.FilePaths));
        }

        private void ClearEditControls()
		{
			lastNameTextBox.Text = String.Empty;
			firstNameTextBox.Text = String.Empty;
			middleInitialTextBox.Text = String.Empty;
			addressTextBox.Text = String.Empty;
			addressExtTextBox.Text = String.Empty;
			cityTextBox.Text = String.Empty;
			txtCountry.Text = String.Empty;
            postalCodeTextBox.Text = String.Empty;
			phoneNumberPrimaryTextBox.Text = String.Empty;
			phoneNumberAlternateTextBox.Text = String.Empty;
			emailTextBox.Text = String.Empty;

			birthdayDateTimePicker.Value = new DateTime(1900, 1, 1);

			cobProv.SelectedIndex = cobProv.FindStringExact(StateArray.Abbreviations()[0]);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PopulateContactListBox();
            SetComponentControlsEnabled(AddressBookFormGUIComponents.ContactListBox);
        }

        private void saveContactButton_Click(object sender, EventArgs e)
		{
			Contact selected = AddressBook.Instance.Contacts[contactListBox.SelectedIndex];

			selected.Save(lastNameTextBox.Text, firstNameTextBox.Text, middleInitialTextBox.Text,
				addressTextBox.Text, addressTextBox.Text, cityTextBox.Text, CA_Province.FromInt(cobProv.SelectedIndex), txtCountry.Text,
				postalCodeTextBox.Text, phoneNumberPrimaryTextBox.Text, phoneNumberAlternateTextBox.Text,
				birthdayDateTimePicker.Value, emailTextBox.Text);

			/* Repopulate the data to show any changes from the saving process */
			PopulateEditControls(AddressBook.Instance.Contacts[contactListBox.SelectedIndex]);

			AddressBook.Instance.Contacts.Sort();
			PopulateContactListBox();
			SetComponentControlsEnabled(AddressBookFormGUIComponents.ContactListBox);

            AddressBook.SaveToDataFile();
            AddressBook.SaveToCSVFile();
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
            string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
            string exeDir = Path.GetDirectoryName(exeFile);
            using (OpenFileDialog dialog = new OpenFileDialog())
			{
				DialogResult result = dialog.ShowDialog();

				if (result == DialogResult.OK)
				{
					if (dialog.CheckFileExists)
					{
                        var fileNames = dialog.FileNames;
                        List<Image> images = selectedContact.Portraits.ToList();
                        string dateStamp = DateTime.Now.ToString("dd-MM-yy-");
                        List<String> imagePaths = selectedContact.ImagePaths == null? new List<string>() : selectedContact.ImagePaths.ToList();
                        foreach (var fileName in fileNames)
                        {
                            var planName = dateStamp + System.IO.Path.GetFileName(dialog.FileName);
                            var copyTo = exeDir + "/photos/" + planName;
                            if (File.Exists(copyTo))
                            {
                                MessageBox.Show($"File {planName} already exists.");
                                continue;
                            }
                            var index = selectedContact.Portraits.Length;                            
                            images.Add(Image.FromFile(dialog.FileName));
                            images[index].Tag = planName;
                            File.Copy(fileName, copyTo);
                            imagePaths.Add(copyTo);
                        }
                        selectedContact.Portraits = images.ToArray();
                        selectedContact.ImagePaths = imagePaths.ToArray();
                        PopulateContactPhotoList(selectedContact);
                    }
				}
			}
		}

		private void deletePhotoButton_Click(object sender, EventArgs e)
		{
			Contact selectedContact = AddressBook.Instance.Contacts[contactListBox.SelectedIndex];
            Image selectedImage = selectedContact.Portraits[listPhotos.SelectedIndex];
            var list = selectedContact.Portraits.ToList();
            list.Remove(selectedImage);
            var listI = selectedContact.ImagePaths.ToList();
            string selectedImageName = listPhotos.SelectedItem.ToString();
            var index = listI.FindIndex(x=> Path.GetFileName(x) == selectedImageName);
            System.IO.File.Delete(listI[index]);
            if (index >= 0) listI.RemoveAt(index);
            selectedContact.Portraits = list.ToArray();
            selectedContact.ImagePaths = listI.ToArray();
            PopulateContactPhotoList(selectedContact);
            
        }
        private void listPhotos_DoubleClick(object sender, EventArgs e)
        {
            if (listPhotos.SelectedIndex == -1)
                return;

            /* Populate the image from the contact info */
            Contact selectedContact = AddressBook.Instance.Contacts[contactListBox.SelectedIndex];
            Image i = selectedContact.Portraits[listPhotos.SelectedIndex];
            ContactImage imageForm = new ContactImage(i);
            DialogResult result = imageForm.ShowDialog();
        }


        private void selectFileButton_Click(object sender, EventArgs e)
        {
            Contact selectedContact = AddressBook.Instance.Contacts[contactListBox.SelectedIndex];
            string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
            string exeDir = Path.GetDirectoryName(exeFile);
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (dialog.CheckFileExists)
                    {
                        var fileNames = dialog.FileNames;
                        string dateStamp = DateTime.Now.ToString("dd-MM-yy-");
                        List<String> filePaths = selectedContact.FilePaths == null ? new List<string>() : selectedContact.FilePaths.ToList();
                        foreach (var fileName in fileNames)
                        {
                            var planName = dateStamp + System.IO.Path.GetFileName(dialog.FileName);
                            var copyTo = exeDir + "/files/" + planName;
                            if (File.Exists(copyTo))
                            {
                                MessageBox.Show($"File {planName} already exists.");
                                continue;
                            }
                            File.Copy(fileName, copyTo);
                            filePaths.Add(copyTo);
                        }
                        selectedContact.FilePaths = filePaths.ToArray();
                        PopulateContactFileList(selectedContact);
                    }
                }
            }
        }

        private void listFiles_DoubleClick(object sender, EventArgs e)
        {
            string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
            string exeDir = Path.GetDirectoryName(exeFile);
            string file = listFiles.SelectedItem.ToString();
            string fullFileName = Path.Combine(exeDir+ "/files/", file);            
            var confirmResult = MessageBox.Show($"Do you want to open file: {file} ?",
                                     "Confirm",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Process.Start(fullFileName);
            }            
        }

        private void deleteFileButton_Click(object sender, EventArgs e)
        {
            Contact selectedContact = AddressBook.Instance.Contacts[contactListBox.SelectedIndex];
            string selectedFileName = listFiles.SelectedItem.ToString();
            var listF = selectedContact.FilePaths.ToList();
            var index = listF.FindIndex(x => Path.GetFileName(x) == selectedFileName);
            System.IO.File.Delete(listF[index]);
            if (index >= 0) listF.RemoveAt(index);
            selectedContact.FilePaths = listF.ToArray();
            PopulateContactFileList(selectedContact);
        }

        #endregion


    }
}
