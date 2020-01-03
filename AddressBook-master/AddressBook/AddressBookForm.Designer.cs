namespace AddressBook
{
	partial class AddressBookForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressBookForm));
            this.contactListBox = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.editContactButton = new System.Windows.Forms.Button();
            this.deleteContactButton = new System.Windows.Forms.Button();
            this.addContactButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deletePhotoButton = new System.Windows.Forms.Button();
            this.selectPhotoButton = new System.Windows.Forms.Button();
            this.contactInfoPanel = new System.Windows.Forms.Panel();
            this.cobProv = new System.Windows.Forms.ComboBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.saveContactButton = new System.Windows.Forms.Button();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addressExtTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.middleInitialTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phoneNumberAlternateTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberPrimaryTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteFileButton = new System.Windows.Forms.Button();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.listPhotos = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.listFiles = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contactInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactListBox
            // 
            this.contactListBox.FormattingEnabled = true;
            this.contactListBox.Location = new System.Drawing.Point(0, 21);
            this.contactListBox.Name = "contactListBox";
            this.contactListBox.Size = new System.Drawing.Size(235, 446);
            this.contactListBox.TabIndex = 0;
            this.contactListBox.SelectedIndexChanged += new System.EventHandler(this.contactListBox_SelectedIndexChanged);
            this.contactListBox.DoubleClick += new System.EventHandler(this.contactListBox_DoubleClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.editContactButton);
            this.splitContainer1.Panel1.Controls.Add(this.deleteContactButton);
            this.splitContainer1.Panel1.Controls.Add(this.addContactButton);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.contactListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listFiles);
            this.splitContainer1.Panel2.Controls.Add(this.listPhotos);
            this.splitContainer1.Panel2.Controls.Add(this.deleteFileButton);
            this.splitContainer1.Panel2.Controls.Add(this.selectFileButton);
            this.splitContainer1.Panel2.Controls.Add(this.deletePhotoButton);
            this.splitContainer1.Panel2.Controls.Add(this.selectPhotoButton);
            this.splitContainer1.Panel2.Controls.Add(this.contactInfoPanel);
            this.splitContainer1.Size = new System.Drawing.Size(797, 506);
            this.splitContainer1.SplitterDistance = 241;
            this.splitContainer1.TabIndex = 3;
            // 
            // editContactButton
            // 
            this.editContactButton.Location = new System.Drawing.Point(78, 483);
            this.editContactButton.Name = "editContactButton";
            this.editContactButton.Size = new System.Drawing.Size(75, 23);
            this.editContactButton.TabIndex = 4;
            this.editContactButton.Text = "Edit";
            this.editContactButton.UseVisualStyleBackColor = true;
            this.editContactButton.Click += new System.EventHandler(this.editContactButton_Click);
            // 
            // deleteContactButton
            // 
            this.deleteContactButton.Location = new System.Drawing.Point(159, 483);
            this.deleteContactButton.Name = "deleteContactButton";
            this.deleteContactButton.Size = new System.Drawing.Size(75, 23);
            this.deleteContactButton.TabIndex = 3;
            this.deleteContactButton.Text = "Delete";
            this.deleteContactButton.UseVisualStyleBackColor = true;
            this.deleteContactButton.Click += new System.EventHandler(this.deleteContactButton_Click);
            // 
            // addContactButton
            // 
            this.addContactButton.Location = new System.Drawing.Point(0, 483);
            this.addContactButton.Name = "addContactButton";
            this.addContactButton.Size = new System.Drawing.Size(75, 23);
            this.addContactButton.TabIndex = 2;
            this.addContactButton.Text = "Add";
            this.addContactButton.UseVisualStyleBackColor = true;
            this.addContactButton.Click += new System.EventHandler(this.addContactButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contacts";
            // 
            // deletePhotoButton
            // 
            this.deletePhotoButton.Enabled = false;
            this.deletePhotoButton.Location = new System.Drawing.Point(196, 274);
            this.deletePhotoButton.Name = "deletePhotoButton";
            this.deletePhotoButton.Size = new System.Drawing.Size(75, 23);
            this.deletePhotoButton.TabIndex = 4;
            this.deletePhotoButton.Text = "Remove Image";
            this.deletePhotoButton.UseVisualStyleBackColor = true;
            this.deletePhotoButton.Click += new System.EventHandler(this.deletePhotoButton_Click);
            // 
            // selectPhotoButton
            // 
            this.selectPhotoButton.Enabled = false;
            this.selectPhotoButton.Location = new System.Drawing.Point(107, 274);
            this.selectPhotoButton.Name = "selectPhotoButton";
            this.selectPhotoButton.Size = new System.Drawing.Size(83, 23);
            this.selectPhotoButton.TabIndex = 3;
            this.selectPhotoButton.Text = "Select Image";
            this.selectPhotoButton.UseVisualStyleBackColor = true;
            this.selectPhotoButton.Click += new System.EventHandler(this.selectPhotoButton_Click);
            // 
            // contactInfoPanel
            // 
            this.contactInfoPanel.AllowDrop = true;
            this.contactInfoPanel.Controls.Add(this.btnCancel);
            this.contactInfoPanel.Controls.Add(this.cobProv);
            this.contactInfoPanel.Controls.Add(this.txtCountry);
            this.contactInfoPanel.Controls.Add(this.label13);
            this.contactInfoPanel.Controls.Add(this.emailTextBox);
            this.contactInfoPanel.Controls.Add(this.label14);
            this.contactInfoPanel.Controls.Add(this.saveContactButton);
            this.contactInfoPanel.Controls.Add(this.postalCodeTextBox);
            this.contactInfoPanel.Controls.Add(this.label12);
            this.contactInfoPanel.Controls.Add(this.label11);
            this.contactInfoPanel.Controls.Add(this.label10);
            this.contactInfoPanel.Controls.Add(this.addressExtTextBox);
            this.contactInfoPanel.Controls.Add(this.cityTextBox);
            this.contactInfoPanel.Controls.Add(this.label9);
            this.contactInfoPanel.Controls.Add(this.middleInitialTextBox);
            this.contactInfoPanel.Controls.Add(this.label8);
            this.contactInfoPanel.Controls.Add(this.firstNameTextBox);
            this.contactInfoPanel.Controls.Add(this.label7);
            this.contactInfoPanel.Controls.Add(this.birthdayDateTimePicker);
            this.contactInfoPanel.Controls.Add(this.phoneNumberAlternateTextBox);
            this.contactInfoPanel.Controls.Add(this.phoneNumberPrimaryTextBox);
            this.contactInfoPanel.Controls.Add(this.addressTextBox);
            this.contactInfoPanel.Controls.Add(this.label6);
            this.contactInfoPanel.Controls.Add(this.label5);
            this.contactInfoPanel.Controls.Add(this.label4);
            this.contactInfoPanel.Controls.Add(this.label3);
            this.contactInfoPanel.Controls.Add(this.lastNameTextBox);
            this.contactInfoPanel.Controls.Add(this.label2);
            this.contactInfoPanel.Location = new System.Drawing.Point(3, 303);
            this.contactInfoPanel.Name = "contactInfoPanel";
            this.contactInfoPanel.Size = new System.Drawing.Size(542, 203);
            this.contactInfoPanel.TabIndex = 1;
            // 
            // cobProv
            // 
            this.cobProv.FormattingEnabled = true;
            this.cobProv.Location = new System.Drawing.Point(341, 58);
            this.cobProv.Name = "cobProv";
            this.cobProv.Size = new System.Drawing.Size(198, 21);
            this.cobProv.TabIndex = 26;
            // 
            // txtCountry
            // 
            this.txtCountry.Enabled = false;
            this.txtCountry.Location = new System.Drawing.Point(341, 84);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(198, 20);
            this.txtCountry.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(290, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Country";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Location = new System.Drawing.Point(341, 136);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(198, 20);
            this.emailTextBox.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(297, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Email";
            // 
            // saveContactButton
            // 
            this.saveContactButton.Enabled = false;
            this.saveContactButton.Location = new System.Drawing.Point(383, 177);
            this.saveContactButton.Name = "saveContactButton";
            this.saveContactButton.Size = new System.Drawing.Size(75, 23);
            this.saveContactButton.TabIndex = 0;
            this.saveContactButton.Text = "Save";
            this.saveContactButton.UseVisualStyleBackColor = true;
            this.saveContactButton.Click += new System.EventHandler(this.saveContactButton_Click);
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Enabled = false;
            this.postalCodeTextBox.Location = new System.Drawing.Point(102, 83);
            this.postalCodeTextBox.MaxLength = 5;
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(55, 20);
            this.postalCodeTextBox.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Postal Code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(286, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Province";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Address Ext";
            // 
            // addressExtTextBox
            // 
            this.addressExtTextBox.Enabled = false;
            this.addressExtTextBox.Location = new System.Drawing.Point(341, 31);
            this.addressExtTextBox.Name = "addressExtTextBox";
            this.addressExtTextBox.Size = new System.Drawing.Size(198, 20);
            this.addressExtTextBox.TabIndex = 5;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Enabled = false;
            this.cityTextBox.Location = new System.Drawing.Point(102, 57);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(166, 20);
            this.cityTextBox.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "City";
            // 
            // middleInitialTextBox
            // 
            this.middleInitialTextBox.Enabled = false;
            this.middleInitialTextBox.Location = new System.Drawing.Point(505, 4);
            this.middleInitialTextBox.MaxLength = 1;
            this.middleInitialTextBox.Name = "middleInitialTextBox";
            this.middleInitialTextBox.Size = new System.Drawing.Size(34, 20);
            this.middleInitialTextBox.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(480, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "MI";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Enabled = false;
            this.firstNameTextBox.Location = new System.Drawing.Point(341, 5);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(133, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "First Name";
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.Enabled = false;
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(341, 110);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(198, 20);
            this.birthdayDateTimePicker.TabIndex = 11;
            // 
            // phoneNumberAlternateTextBox
            // 
            this.phoneNumberAlternateTextBox.Enabled = false;
            this.phoneNumberAlternateTextBox.Location = new System.Drawing.Point(102, 133);
            this.phoneNumberAlternateTextBox.MaxLength = 10;
            this.phoneNumberAlternateTextBox.Name = "phoneNumberAlternateTextBox";
            this.phoneNumberAlternateTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberAlternateTextBox.TabIndex = 10;
            // 
            // phoneNumberPrimaryTextBox
            // 
            this.phoneNumberPrimaryTextBox.Enabled = false;
            this.phoneNumberPrimaryTextBox.Location = new System.Drawing.Point(102, 107);
            this.phoneNumberPrimaryTextBox.MaxLength = 10;
            this.phoneNumberPrimaryTextBox.Name = "phoneNumberPrimaryTextBox";
            this.phoneNumberPrimaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberPrimaryTextBox.TabIndex = 9;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Enabled = false;
            this.addressTextBox.Location = new System.Drawing.Point(102, 31);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(166, 20);
            this.addressTextBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Birthday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone (Alternate)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone (Primary)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Enabled = false;
            this.lastNameTextBox.Location = new System.Drawing.Point(102, 5);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(166, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name";
            // 
            // deleteFileButton
            // 
            this.deleteFileButton.Enabled = false;
            this.deleteFileButton.Location = new System.Drawing.Point(471, 274);
            this.deleteFileButton.Name = "deleteFileButton";
            this.deleteFileButton.Size = new System.Drawing.Size(75, 23);
            this.deleteFileButton.TabIndex = 7;
            this.deleteFileButton.Text = "Remove File";
            this.deleteFileButton.UseVisualStyleBackColor = true;
            this.deleteFileButton.Click += new System.EventHandler(this.deleteFileButton_Click);
            // 
            // selectFileButton
            // 
            this.selectFileButton.Enabled = false;
            this.selectFileButton.Location = new System.Drawing.Point(382, 274);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(83, 23);
            this.selectFileButton.TabIndex = 6;
            this.selectFileButton.Text = "Select File";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // listPhotos
            // 
            this.listPhotos.FormattingEnabled = true;
            this.listPhotos.Location = new System.Drawing.Point(3, 3);
            this.listPhotos.Name = "listPhotos";
            this.listPhotos.Size = new System.Drawing.Size(268, 264);
            this.listPhotos.TabIndex = 8;
            this.listPhotos.DoubleClick += new System.EventHandler(this.listPhotos_DoubleClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(464, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // listFiles
            // 
            this.listFiles.FormattingEnabled = true;
            this.listFiles.Location = new System.Drawing.Point(277, 4);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(268, 264);
            this.listFiles.TabIndex = 9;
            this.listFiles.DoubleClick += new System.EventHandler(this.listFiles_DoubleClick);
            // 
            // AddressBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 530);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddressBookForm";
            this.Text = "Address Book";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contactInfoPanel.ResumeLayout(false);
            this.contactInfoPanel.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox contactListBox;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel contactInfoPanel;
		private System.Windows.Forms.TextBox phoneNumberAlternateTextBox;
		private System.Windows.Forms.TextBox phoneNumberPrimaryTextBox;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox postalCodeTextBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox addressExtTextBox;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox middleInitialTextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
		private System.Windows.Forms.Button editContactButton;
		private System.Windows.Forms.Button deleteContactButton;
		private System.Windows.Forms.Button addContactButton;
		private System.Windows.Forms.Button saveContactButton;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button selectPhotoButton;
		private System.Windows.Forms.Button deletePhotoButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.ComboBox cobProv;
        private System.Windows.Forms.Button deleteFileButton;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.ListBox listPhotos;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox listFiles;
    }
}

