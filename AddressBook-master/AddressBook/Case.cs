using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace AddressBook
{
    [SerializableAttribute]
    public class Case 
    {
        private String _id;
        private String _name;
        private String _note;

        private DateTime _startDate;
        private List<Image> _images = new List<Image>();
        private List<string> _contactIDs = new List<string>();
        private string[] _filePaths;

        public Case()
        {
            _name = "*";
            _note = "*";
            _startDate = DateTime.Now;
            _id = DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");
        }

        public void Save(String name, String note,DateTime startDate, List<string> contactIDs)
        {
            /* Save non-validated fields */
            _name = name.Trim();
            _note = note.Trim();
            _startDate = startDate;
            _contactIDs = contactIDs;
        }

        #region Properties
        [CsvColumn(Name = "ID")]
        public String ID
        {
            get { return _id; }
        }
        [CsvColumn(Name = "Name")]
        public String Name
        {
            get { return _name; }
        }
        [CsvColumn(Name = "Note")]
        public String Note
        {
            get { return _note; }
        }
        
        [CsvColumn(Name = "StartDate", OutputFormat = "dd MMM yy")]
        public DateTime StartDate
        {
            get { return _startDate; }
        }        
        public string[] FilePaths
        {
            get { return _filePaths; }
            set { _filePaths = value; }
        }
        public string[] ContactIDs
        {
            get { return _contactIDs.ToArray(); }
            set { _contactIDs = value.ToList(); }
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
