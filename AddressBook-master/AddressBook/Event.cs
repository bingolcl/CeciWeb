using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace AddressBook
{
    [SerializableAttribute]
    public class Event
    {
        private String _id;
        private String _subject;
        private String _note;
        private DateTime _eventdate;
        private List<string> _caseIDs = new List<string>();


        public Event()
        {
            _subject = "*";
            _note = "*";
            _eventdate = DateTime.Now;
            _id = DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");
        }

        public void Save(String subject, String note,DateTime eventdate, List<string> caseIDs)
        {
            /* Save non-validated fields */
            _subject = subject.Trim();
            _note = note.Trim();
            _eventdate = eventdate;
            _caseIDs = caseIDs;
        }

        #region Properties
        [CsvColumn(Name = "ID")]
        public String ID
        {
            get { return _id; }
        }
        [CsvColumn(Name = "Subject")]
        public String Subject
        {
            get { return _subject; }
        }
        [CsvColumn(Name = "Note")]
        public String Note
        {
            get { return _note; }
        }
        [CsvColumn(Name = "EventDate", OutputFormat = "dd MMM yyyy")]
        public DateTime EventDate
        {
            get { return _eventdate; }
        }
        public string[] CaseIDs
        {
            get { return _caseIDs.ToArray(); }
            set { _caseIDs = value.ToList(); }
        }
        #endregion
    }
}
