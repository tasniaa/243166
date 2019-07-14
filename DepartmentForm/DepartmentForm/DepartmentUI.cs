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

namespace DepartmentForm
{
    public partial class DepartmentUI : Form
    {
        class Department
        {
            public int ID { set; get; }
            public string Name { set; get; }
            public string Code { set; get; }
        }
        public DepartmentUI()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // string name = "Computer Science and Engineering";
            //string code = "CSE";
            //Insert(name,code);
            //string name = nameTextBox.Text;
            //string code = codeTextBox.Text;
            //Insert(name, code);
            Department department = new Department();
            department.Name = nameTextBox.Text;
            department.Code = codeTextBox.Text;
            Insert(department);
            nameTextBox.Clear();
            idTextBox.Clear();
            codeTextBox.Clear();
        }
  
 
        private void Insert(Department department)
        {
            try

            {
                //1
                SqlConnection sqlConnection = new SqlConnection();
                string connectionString = @"Server=TOROSHA; Database=StudentDB; Integrated Security=True";
                sqlConnection.ConnectionString = connectionString;
                //2

                SqlCommand sqlCommand = new SqlCommand();
                string commandString = @"INSERT INTO Departments (Name,Code)  Values('" + department.Name + "','" + department.Code + "')";
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;
                //3
                sqlConnection.Open();
                //4
                int isExecuted = 0;
                isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    Show();
                    MessageBox.Show("Save Successfully");
                    
                }
                else
                {
                    MessageBox.Show("Save Failed!!");
                }
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        
            private void ShowButton_Click_1(object sender, EventArgs e)
        {
            Show();

        }
        private void Show()
        {
            SqlConnection sqlConnection = new SqlConnection();
            string connectionString = @"Server=TOROSHA; Database=StudentDB; Integrated Security=True";
            sqlConnection.ConnectionString = connectionString;

            string commandString = @"SELECT * FROM Departments";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                displayDataGridView1.DataSource = dataTable;
            }
            sqlConnection.Close();
        }

        private void UpdateButton_Click_1(object sender, EventArgs e)
        {

            Department department = new Department();
            department.ID = Convert.ToInt32(idTextBox.Text);
            department.Name = nameTextBox.Text;
            department.Code = codeTextBox.Text;
            Update(department);
            nameTextBox.Clear();
            idTextBox.Clear();
            codeTextBox.Clear();
        }
        private void Update(Department department)
        {

            try

            {
                //1
                SqlConnection sqlConnection = new SqlConnection();
                string connectionString = @"Server=TOROSHA; Database=StudentDB; Integrated Security=True";
                sqlConnection.ConnectionString = connectionString;
                //2

                SqlCommand sqlCommand = new SqlCommand();
                string commandString = @"UPDATE Departments SET Name ='" + department.Name + "', Code='" + department.Code + "' WHERE ID = '" + department.ID + "'";
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;
                //3
                sqlConnection.Open();
                //4
   
                int isExecuted = 0;
                isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    Show();
                    MessageBox.Show("Update Successfully");
             

                }
                else
                {
                    MessageBox.Show("Update Failed!!");
                }

             
                sqlConnection.Close();

            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            Department department = new Department();
            department.ID = Convert.ToInt32(idTextBox.Text);
            Delete(department);
            nameTextBox.Clear();
            idTextBox.Clear();
            codeTextBox.Clear();

        }

        private void Delete(Department department)
        {

            try

            {
                //1
                SqlConnection sqlConnection = new SqlConnection();
                string connectionString = @"Server=TOROSHA; Database=StudentDB; Integrated Security=True";
                sqlConnection.ConnectionString = connectionString;
                //2

                SqlCommand sqlCommand = new SqlCommand();
                string commandString = @"DELETE FROM Departments  WHERE ID = '" + department.ID + "'";
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;
                //3
                sqlConnection.Open();
                //4

                int isExecuted = 0;
                isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    Show();
                    MessageBox.Show("Delete Successfully");
                 
                }
                else
                {
                    MessageBox.Show("DELETE Failed!!");
                }

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}

