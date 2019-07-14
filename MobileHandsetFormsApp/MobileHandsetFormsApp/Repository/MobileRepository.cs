using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileHandsetFormsApp.Model;

namespace MobileHandsetFormsApp.Repository
{
    public class MobileRepository
    {
        string connectionString = @"Server=TOROSHA; Database=MobileHandsetDB; Integrated Security=True";
        SqlConnection sqlConnection;

        private string commandString;
        private SqlCommand sqlCommand;
        public int Insertmobile(MoblieHandset moblieHandset)
        {
            

            sqlConnection = new SqlConnection(connectionString);
            commandString = @"INSERT INTO MobileInformations  VALUES ('" + moblieHandset.ModelName + "', '" + moblieHandset.IMEI + "', " + moblieHandset.Price + ")";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return isExecuted;
        }
        public DataTable SearchByIMEI(MoblieHandset mobileHandset)
        {
            DataTable dataTable = new DataTable();
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
           
               // DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataTable = new DataTable();
                
               dataAdapter.Fill(dataTable);

            }
            sqlConnection.Close();
            return dataTable;


        }
        public DataTable SearchbyPrice(MoblieHandset mobileHandset)
        {

            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM MobileInformations WHERE Price >= '" + mobileHandset.Price+ "' AND Price <='" + mobileHandset.Price2 + "'";

            //commandString = @"SELECT * FROM StudentsView";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataTable.Columns.Add("SL", typeof(System.Int32));
            int x = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                x = x + 1;
                row["SL"] = x;
            }

            //if (dataTable.Rows.Count > 0)
            //    displayDataGridView.DataSource = dataTable;


            sqlConnection.Close();
            return dataTable;
        }
    }
}
