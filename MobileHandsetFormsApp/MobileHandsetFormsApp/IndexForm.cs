using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileHandsetFormsApp
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }
        private void SaveMobileHandsetButton_Click_1(object sender, EventArgs e)
        {
            MoblieHandsetInformationForm moblieHandsetInformationForm = new MoblieHandsetInformationForm();
            this.Hide();
            moblieHandsetInformationForm.Show();
        }

        private void SearchbyPriceButton_Click_1(object sender, EventArgs e)
        {
            SearchByRangForm searchByRangForm = new SearchByRangForm();
            this.Hide();
            searchByRangForm.Show();
        }

        private void SearchbyImeiButton_Click(object sender, EventArgs e)
        {
            SearchByIMEIForm searchByIMEIForm = new SearchByIMEIForm();
            this.Hide();
            searchByIMEIForm.Show();
        }
    }
}
