using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileHandsetFormsApp.Model;
using MobileHandsetFormsApp.BLL;


namespace MobileHandsetFormsApp
{
    public partial class MoblieHandsetInformationForm : Form
    {
        public MoblieHandset mobileHandset;
        public MobileHandsetManager _mobileHandsetManager;
        public MoblieHandsetInformationForm()
        {
            InitializeComponent();
            mobileHandset = new MoblieHandset();
            _mobileHandsetManager = new MobileHandsetManager();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            mobileHandset.ModelName = modelNameTextBox.Text;
            mobileHandset.IMEI = imeiTextBox.Text;
            mobileHandset.Price = Convert.ToInt32(priceTextBox.Text);
        
            int isExecuted;
            isExecuted =_mobileHandsetManager.Insertmobile(mobileHandset);
            if (isExecuted > 0)
            {
                messageLabel.Text = "Save mobile Handset Information!!";

            }
            else
            {
                messageLabel.Text = " mobile Handset Information not saved!!";
            }
        }
    }
}
