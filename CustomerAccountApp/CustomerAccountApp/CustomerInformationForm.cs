using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerAccountApp
{
    public partial class Form1 : Form
    {
        List<string> usernames = new List<string>();
        List<string> firstnames = new List<string>();
        List<string> lastnames = new List<string>();
        List<int> contactNos = new List<int>();
        List<string> emails = new List<string>();
        List<string> addresses = new List<string>();
        List<int> accountNos = new List<int>();
        List<int> accountNumbers = new List<int>();
        List<int> balances = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           try
            {
                string contactNochk = contactNoTextBox.Text;
               
                string user;
                string firstname;
                string lastname;
                int contactNo;
                string email;
                string address;
                int accountno;
                user = userTextBox.Text;
                email = emailTextBox.Text;
                userLabel.Text = "";
                contactNoLabel.Text = "";
                emailLabel.Text = "";
                accountNoLabel.Text = "";


                if ( (String.IsNullOrEmpty(user)) && (String.IsNullOrEmpty(contactNoTextBox.Text)) && (String.IsNullOrEmpty(accountNoTextBox.Text)) && String.IsNullOrEmpty(email)) 
                {
                    userLabel.Text = ("User can not be empty!!");
                    contactNoLabel.Text = ("Contact No can not be empty!!");
                    emailLabel.Text = ("Email can not be empty!!");
                    accountNoLabel.Text = ("Account No can not be empty!!");

                    return;
                }
                if (UserNameExists(user))
                { 
                    userLabel.Text = "User " + user + " is already exists!!";
                    return;
                }

                if (System.Text.RegularExpressions.Regex.IsMatch(contactNoTextBox.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers in Concact No!!");
                    return;
                }
                if ( ContactnoExists(Convert.ToInt32(contactNoTextBox.Text)))
                {
                   contactNoLabel.Text = "Contact NO " + contactNoTextBox.Text + " is already exists!!";
    
                    return;
                }

                    if (contactNoTextBox.TextLength != 11)
                {
                    MessageBox.Show("Enter Contact No 11 Numeric Digits Only!");
                    return;
                }
                if ( EmailExists(email))
                {
                    emailLabel.Text = "Email " + email + " is already exists!!";
                    return;
                }
                if (!email.Contains("@") || (!email.Contains(".")))
                {
                    MessageBox.Show("invalid email. missing @ or . !!");
                    return;
                }
                if (System.Text.RegularExpressions.Regex.IsMatch(accountNoTextBox.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers in Account No");
                    return;
                }
                if (AccountNoExists(Convert.ToInt32(accountNoTextBox.Text)))
                {
                    accountNoLabel.Text = "Account NO " + accountNoTextBox.Text + " is already exists!!";
                    return;
                }
                if (accountNoTextBox.TextLength != 9)
                {
                    MessageBox.Show("Enter only 9 numeric digits Account No!!");
                    return;
                }
              
               
                contactNo = Convert.ToInt32(contactNoTextBox.Text);
                accountno = Convert.ToInt32(accountNoTextBox.Text);
                firstname = firstNameTextBox.Text;
                lastname = lastNameTextBox.Text;
                address = addressTextBox.Text;
                usernames.Add(user);
                firstnames.Add(firstname);
                lastnames.Add(lastname);
                contactNos.Add(contactNo);
                emails.Add(email);
                addresses.Add(address);
                accountNos.Add(accountno);
                balances.Add(0);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
        }
        private string Display()
        {
            string message = "";
            message = message + "SI\t|User Name\t|First Name\t|Last Name\t|Contact No\t|Email\t\t|address\t\t|Account No\n";
            for (int index = 0; index < usernames.Count; index++)
            {
                message = message + (index + 1) + "\t" + usernames[index] + "\t\t" + firstnames[index] + "\t" + lastnames[index] + "\t\t" + contactNos[index] + "\t"+ emails[index] + "\t" + addresses[index] + "\t" + accountNos[index] + "\n";
            }
            return message;
        }
        private bool UserNameExists(string user)
        {
            bool isExists = false;
            foreach(string userchk in usernames)
            {
                if(userchk==user)
                {
                    isExists = true;
                }
            }

            return isExists;
        }
        private bool ContactnoExists(int contactno)
        {
            bool isExists = false;
            foreach (int contactnochk in contactNos)
            {
                if (contactnochk == contactno)
                {
                    isExists = true;
                }
            }

            return isExists;
        }
        private bool EmailExists(string email)
        {
            bool isExists = false;
            foreach (string emailchk in emails)
            {
                if (emailchk == email)
                {
                    isExists = true;
                }
            }

            return isExists;
        }
        private bool AccountNoExists(int accountNo)
        {
            bool isExists= false;
            foreach(int accountNochk in accountNos)
            {
                if(accountNochk== accountNo)
                {
                    isExists = true;
                }
            }
            return isExists;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string message = "";
            message = message + "\t\t\t\t\t Show all Customer information  \n ";
          
            displayRichTextBox.Text = message +Display();
        }

        private void dipositButton_Click(object sender, EventArgs e)
        {
          
            try
            {
               
                for (int index = 0; index < accountNos.Count; index++)
                {
                     int accountno;
                accountno = Convert.ToInt32(accountNoTextBox.Text);
                accountNos.Add(accountno);
                int amount;
                    if (accountNos[index].ToString() != accountNumberTextBox.Text)
                    {
                        MessageBox.Show("Invalid account number");
                        return;
                    }
                    if (accountNos[index].ToString() == accountNumberTextBox.Text)
                    {
                        amount = Convert.ToInt32(amountTextBox.Text);
                        balances[index] += amount;
                        MessageBox.Show("Account number : " + accountNos[index] + "\n" + "Balance is: " + balances[index]);
                        return;
                    }

                }
            }


            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

        }

        private void balanceButton_Click(object sender, EventArgs e)
        {
           
                try
                {
                    int accountno;
                    for (int index = 0; index < accountNos.Count; index++)
                    {
                        accountno = Convert.ToInt32(accountNoTextBox.Text);
                        accountNos.Add(accountno);
                        if (accountNos[index].ToString() != accountNumberTextBox.Text)
                        {
                            MessageBox.Show("Invalid account number");
                            return;
                        }
                        if (accountNos[index].ToString() == accountNumberTextBox.Text)
                    {

                        MessageBox.Show("Account number : " + accountNos[index]+ "\n" + "Balance is: " + balances[index]);
                        
                        index++;
                        return;
                    }
                    if (accountNos[index].ToString() != accountNumberTextBox.Text)
                    {
                        MessageBox.Show("Invalid account number");
                        return;
                    }
                }
                }

            
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
        
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
           
            try
            {
                int accountno;
              
              
                int amount;
                for (int index = 0; index < accountNos.Count; index++)
                {
                    accountno = Convert.ToInt32(accountNoTextBox.Text);
                    accountNos.Add(accountno);
                    if (accountNos[index].ToString() != accountNumberTextBox.Text)
                    {
                        MessageBox.Show("Invalid account number");
                        return;
                    }
                    if (accountNos[index].ToString() == accountNumberTextBox.Text)
                    {
                        amount = Convert.ToInt32(amountTextBox.Text);
                        if ( amount> balances[index])
                        {

                            MessageBox.Show("Not sufficient balance for withdraw.please check balance!!");
                            return;
                        }
                        if ( amount<balances[index])
                        {
                            balances[index] -= amount;
                            MessageBox.Show("Account number : " + accountNos[index] + "\n" + "Balance is: " + balances[index]);
                            return;
                        }

                    }
                    index++;
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
        }
    }
}
