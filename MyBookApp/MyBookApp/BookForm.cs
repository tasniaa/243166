using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBookApp
{

    public partial class BookForm : Form
    {

        List<string> CustomerNames = new List<string>();
        List<int> ContactNos = new List<int>();
        List<string> Addresses = new List<string>();
        List<string> Orders = new List<string>();
        List<int> Quantitys = new List<int>();
        List<int> Totals = new List<int>();

        int price;



        public BookForm()
        {
            InitializeComponent();
        }
    




        private void SaveButton_Click(object sender, EventArgs e)
        {
            CustomerNames.Add(nameTextBox.Text);
            ContactNos.Add(Convert.ToInt32(contactTextBox.Text));
            Addresses.Add(addressTextBox.Text);
            Orders.Add(orderComboBox.Text);
            Quantitys.Add(Convert.ToInt32(quantityTextBox.Text));
           
            string message = "";
        
            int index = 0;
            if (orderComboBox.Text == "Math -120")
            {
                price = 120;

            }
            else if (orderComboBox.Text == "English -100")
            {
                price = 100;

            }
            else if (orderComboBox.Text == "Bangla -90")
            {
                price = 90;

            }
            else if (orderComboBox.Text == "Art -80")
            {
                price = 80;

            }
            Totals.Add(Convert.ToInt32(quantityTextBox.Text) * price);

            foreach (int ContactNo in ContactNos)
            {

                message = message + ("\n\tCustomer Number " +(index+1) + ". Order Information : \n\n"+" Name :   " + CustomerNames[index] + "\n" + " Contact No :   " + ContactNo + "\n" + " Address :   " + Addresses[index] + "\n" + " Order :   " + Orders[index] + "\n" + " Quantity :   " + Quantitys[index] + "\n"+" Total Price :   " + Totals[index] + " Tk.\n");

                index++;
            }
      
            
            saveRichTextBox.Text = message;
            nameTextBox.Clear();
            contactTextBox.Clear();
            addressTextBox.Clear();
            orderComboBox.ResetText();
            quantityTextBox.Clear(); 
        }

        private void saveRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

       

