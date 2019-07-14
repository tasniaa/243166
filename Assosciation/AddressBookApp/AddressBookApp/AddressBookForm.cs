using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBookApp
{
    public partial class AddressBookForm : Form
    {
        Person person = new Person();
        List<Person> persons;
        public AddressBookForm()
        {
            InitializeComponent();
            persons = new List<Person>();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
            if (saveButton.Text.Equals("Save"))
            {
                person = new Person();
                person.FirstName = firstNameTextBox.Text;
                person.LastName = lastNameTextBox.Text;
                //person.Email = emailTextBox.Text;
                foreach (Person aPerson in persons)
                {
                    if (aPerson.Email.Equals(emailTextBox.Text))
                    {
                        messageLabel.Text = "Email is already exist";
                        return;
                    }
                }
                if (person.SetEmail(emailTextBox.Text))
                {
                    messageLabel.Text = "Please enter a valid Email";
                    return;
                }
                person.PhoneNo = phoneNoTextBox.Text;
                persons.Add(person);
            }
            else
            {
                foreach (Person aPerson in persons)
                {
                    if (aPerson.Email.Equals(emailTextBox.Text))
                    {
                        person = aPerson;
                        break;
                    }
                }
                person.FirstName = firstNameTextBox.Text;
                person.LastName = lastNameTextBox.Text;
                person.PhoneNo = phoneNoTextBox.Text;
                saveButton.Text = "Save";
                editEmailextBox.Text = "";
            }
            //cleaning textbox
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            phoneNoTextBox.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
            string email = editEmailextBox.Text;
            foreach (Person aPerson in persons)
            {
                if (aPerson.Email.Equals(email))
                {
                    person = aPerson;
                    person = aPerson;
                    firstNameTextBox.Text = person.FirstName;
                    lastNameTextBox.Text = person.LastName;
                    emailTextBox.Text = person.Email;
                    phoneNoTextBox.Text = person.PhoneNo.ToString();
                    saveButton.Text = "Update";
                    break;
                }
            }
            if (firstNameTextBox.Text.Equals(""))
            {
                messageLabel.Text = "This Person information is not available";
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
            List<Person> personList = new List<Person>();
            if (!String.IsNullOrEmpty(lastNameSearchTextBox.Text))
            {
                personList = new List<Person>();
                foreach (Person aPerson in persons)
                {
                    if (aPerson.LastName.Equals(lastNameSearchTextBox.Text))
                    {
                        personList.Add(aPerson);
                    }
                }
                if (personList.Count == 0)
                {
                    messageLabel.Text = "Last Name not found!";
                }
            }
            if (!String.IsNullOrEmpty(searchEmailTextBox.Text))
            {
                personList = new List<Person>();
                foreach (Person aPerson in persons)
                {
                    if (aPerson.Email.Equals(searchEmailTextBox.Text))
                    {
                        personList.Add(aPerson);
                        break;
                    }
                }
                if (personList.Count == 0)
                {
                    messageLabel.Text = "Email not found!";
                }
            }
            if (!String.IsNullOrEmpty(searchPhoneTextBox.Text))
            {
                personList = new List<Person>();
                foreach (Person aPerson in persons)
                {
                    if (aPerson.PhoneNo.Equals(phoneNoTextBox.Text))
                    {
                        personList.Add(aPerson);
                        break;
                    }
                }
                if (personList.Count == 0)
                {
                    messageLabel.Text = "Phone No. not found!";
                }
            }
            showDataGridView.DataSource = personList;

        }
    }
}
