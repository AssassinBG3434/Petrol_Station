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
        public Dictionary<int, string> GetNamesForDelivery()
        {
            SqlCommand sqlCommand = new SqlCommand($"SELECT id,name_ FROM Delivery",conn);
            List<string> names = new List<string>();
            Dictionary<int,string> idAndNames = new Dictionary<int,string>();
            conn.Open() ;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while ( reader.Read() )
            {
                idAndNames.Add(int.Parse(reader[0].ToString()), reader[1].ToString());
            }
            conn.Close();
            return idAndNames;
        }
        public void InsertDeliveredGasData(string typeGas,string deliver, string quantity, string deliveryPrice, string where, string registerPlate, string driver)
        {
            /*string typeGas = TypeGasInput.Text;
            string deliver = DeliveryNameInput.Text;
            string quantity = QuantityInput.Text;
            string deliveryPrice = PriceInput.Text;
            string where = ToWhereInput.Text;
            string registerPlate = RegisterPlateInput.Text;
            string driver = DriverNameInput.Text;*/
            
            SqlCommand sqlCommand = new SqlCommand($"INSERT INTO AllDelivered (gasId,deliveryId,quantity,gasTankId,registerPlate,driver,price) VALUES ({typeGas},{deliver},{quantity},{where},N'{registerPlate}',N'{driver}',{deliveryPrice})", conn);
            conn.Open();
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }
        public string WhichIdIsThisGas(string name)
        {
            string id = "";
            SqlCommand sqlCommand = new SqlCommand($"SELECT (id) FROM GAS where (type_ = N'{name.ToLower().Trim()}')", conn);
            conn.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while ( reader.Read() )
            {
                id = reader[0].ToString();
            }
            conn.Close();
            return id;
        }
    }
}
