using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace Petrol_Station_Libary
{
    internal class Queries
    {
        public SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\VisualStudio\\Projects\\Petrol_Station\\Petrol_StationDB\\PetrolStationDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Queries() 
        {
            
        }
        public bool InsertDataDelivery(string name_,string mol,string address,string bulstat)
        {
            SqlCommand sqlCommand = new SqlCommand($"INSERT INTO Delivery (name_,mol,adress,bulstat) VALUES (N'{name_}', N'{mol}', N'{address}', N'{bulstat}') ", conn);
            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
