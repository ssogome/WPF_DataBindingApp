using System.Collections.ObjectModel;
using System;
using System.Windows;

namespace WPF_DataBindingApp
{
    public class Friend
    {
        private string _studentFirstName;
        private string _studentLastName;
        private string _studentHomeTown;
        private bool _isEnrolled;
        // The default constructor is required for creation from XAML. 
        public Friend() { }
        public Friend(string fname, string lname, string htown, bool isEnrolled)
        {
            this._studentFirstName = fname;
            this._studentLastName = lname;
            this._studentHomeTown = htown;
            this._isEnrolled = isEnrolled;
        }

        // The StudentName property is a string that holds the first and last name. 
        public string StudentFirstName { get { return _studentFirstName; } set { _studentFirstName = value; } }
        public string StudentLastName { get { return _studentLastName; } set { _studentLastName = value; } }
        public string StudentHomeTown { get { return _studentHomeTown; } set { _studentHomeTown = value; } }

        // The IsEnrolled property gets or sets a value indicating whether 
        // the student is currently enrolled. 
        public bool IsEnrolled { get { return _isEnrolled; } set { _isEnrolled = value; } }

        public override string ToString()
        {
            return _studentFirstName.ToString();
        }
    }

    // The StudentList collection is declared for convenience, 
    // because declaring generic types in XAML is inconvenient. 
    public class FriendList : ObservableCollection<Friend>
    {
        public FriendList(): base()
        {
            Add(new Friend("Carter", "Evans", "Fort COllins", true));
            Add(new Friend("Melanie",  "Ekoe", "Denver", false));
        }
    }

}

