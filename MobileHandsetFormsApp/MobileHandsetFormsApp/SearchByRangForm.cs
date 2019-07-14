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
    public partial class SearchByRangForm : Form
    {
        public MoblieHandset mobileHandset;
        public MobileHandsetManager _mobileHandsetManager;
        public SearchByRangForm()
        {
            InitializeComponent();
            mobileHandset = new MoblieHandset();
            _mobileHandsetManager = new MobileHandsetManager();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            mobileHandset.Price = Convert.ToInt32(priceTextBox.Text);
            mobileHandset.Price2 = Convert.ToInt32(price2TextBox.Text);
            searchDataGridView.DataSource = _mobileHandsetManager.SearchbyPrice(mobileHandset);
            //foreach (DataGridViewRow row in searchDataGridView.Rows)

            //    row.Cells["SL"].Value = (row.Index + 1).ToString();

        }
    }
}
