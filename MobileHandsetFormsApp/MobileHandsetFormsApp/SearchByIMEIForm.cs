using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileHandsetFormsApp.Model;
using MobileHandsetFormsApp.BLL;

namespace MobileHandsetFormsApp
{
    public partial class SearchByIMEIForm : Form
    {
        string connectionString = @"Server=TOROSHA; Database=MobileHandsetDB; Integrated Security=True";
        SqlConnection sqlConnection;

        private string commandString;
        private SqlCommand sqlCommand;
        public MoblieHandset mobileHandset;
        public MobileHandsetManager _mobileHandsetManager;
        public SearchByIMEIForm()
        {
            InitializeComponent();
            mobileHandset = new MoblieHandset();
            _mobileHandsetManager = new MobileHandsetManager();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            mobileHandset.IMEI = imeiTextBox.Text;
            SearchByIMEI(mobileHandset);


        }
        public void SearchByIMEI(MoblieHandset mobileHandset)
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = "";
            if (!String.IsNullOrEmpty(mobileHandset.IMEI))
            {
                commandString = "SELECT * FROM MobileInformations WHERE IMEI LIKE '%" + mobileHandset.IMEI + "%'";
            }


            if (!String.IsNullOrEmpty(commandString))
            {
                sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    modelNamelabel.Text = dataTable.Rows[0]["ModelName"].ToString();
                    imeiLabel.Text = dataTable.Rows[0]["IMEI"].ToString();
                    priceLabel.Text = dataTable.Rows[0]["Price"].ToString();

                }
            }
            sqlConnection.Close();

        }
    }
}
