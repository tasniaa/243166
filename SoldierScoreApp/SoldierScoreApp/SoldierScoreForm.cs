using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoldierScoreApp
{
    public partial class SoldierScoreForm : Form
    {
        List<int> Soldiernos = new List<int>();
        List<string> Soldiernames = new List<string>();
        List<int> Averages = new List<int>();
        List<int> Totals = new List<int>();

        public SoldierScoreForm()
        {
            InitializeComponent();
        }



        private void saveButton_Click(object sender, EventArgs e)
        {
            

                int soldierno;
                string soldiername;
                int Targetscore1;
                int Targetscore2;
                int Targetscore3;
                int Targetscore4;
                int average;
                int total;
                if (SoldiernoisExists(Convert.ToInt32(soldierNoTextBox.Text)))
                {
                    soldierNoLabel.Text = "Soldier NO " + soldierNoTextBox.Text + " is already exists!!";

                    return;
                }
                soldierno = Convert.ToInt32(soldierNoTextBox.Text);
                soldiername = soldierNameTextBox.Text;
                Targetscore1 = Convert.ToInt32(target1TextBox.Text);
                Targetscore2 = Convert.ToInt32(target2TextBox.Text);
                Targetscore3 = Convert.ToInt32(target3TextBox.Text);
                Targetscore4 = Convert.ToInt32(target4TextBox.Text);
                Soldiernos.Add(soldierno);
                Soldiernames.Add(soldiername);
                average =( (Targetscore1+Targetscore2+Targetscore3+Targetscore4) / 4);
                Averages.Add(average);
                total = Targetscore1 + Targetscore2 + Targetscore3 + Targetscore4;
                Totals.Add(total);
                saveRichTextBox.Text = Display();


        }
        private string Display()
        {
           
            string message = "";
            message = message + "|Soldier No.\t|Soldier Name|\t|Average Score|\t|Total Score|\n";
            for (int index = 0; index < Soldiernos.Count; index++)
            {
                message = message  + Soldiernos[index] + "|\t\t|" + Soldiernames[index]+ "|\t\t|" + Averages[index] + "|\t\t|" + Totals[index] + "|\n";
            }
            return message;
        }
        private bool SoldiernoisExists(int soldierno)
        {
            bool isExists = false;
            foreach (int soldiernochk in Soldiernos)
            {
                if (soldiernochk == soldierno)
                {
                    isExists = true;
                }
            }

            return isExists;
        }

        private void AverageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
         
            saveRichTextBox.Text = Display();
           int topAverageScore = Averages.Max();
           int  topTotalScore = Totals.Max();
            int indexValue = Averages.IndexOf(topAverageScore);
            AverageTextBox.Text = Soldiernames[indexValue] ;
            TotalTextBox.Text = Soldiernames[indexValue];
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string solderInfo =searchTextBox.Text;
                string message = "Soldier No\t Soldier Name\t Average Score\t Total Score\n";
                if (searchComboBox.Text == "Soldier No")
                {
                    int index = Soldiernos.IndexOf(Convert.ToInt32(solderInfo));
                    message = message + Soldiernos[index] + "\t " + Soldiernames[index] + "\t " + Averages[index] + "\t " + Totals[index] + "\n";
                }
                if (searchComboBox.Text == "Soldier Name")
                {
                    int index = Soldiernames.IndexOf(solderInfo);
                    message = message + Soldiernos[index] + "\t " + Soldiernames[index] + "\t " + Averages[index] + "\t " + Totals[index] + "\n";
                }
                saveRichTextBox.Text = message;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
