using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ISE_Project
{
    class DBClass
    {
        SqlConnection conc;
        public string dataString = @"Data Source=DESKTOP-V5OREHE;Initial Catalog=PMS;Integrated Security=True";
        public DBClass()
        {
            conc = new SqlConnection(dataString);
        }

        public string quantityCheckAll(string query, int value, string itemName, DataGridView ClientOrder_Gview)
        {
            conc.Open();
            string availableQty = "";
            SqlCommand cnd = new SqlCommand(query, conc);
            SqlDataReader reader = cnd.ExecuteReader();
            while (reader.Read())
            {
                availableQty = reader[0].ToString();
            }
            reader.Close();
            if (Convert.ToInt32(availableQty) < Convert.ToInt32(value))
            {
                conc.Close();
                return "Unavailable";
            }
            else
            {
                conc.Close();
                return "Available";
            }
        }

        public string FetchPrice(string query, string itemName, DataGridView ClientOrder_Gview)
        {
            conc.Open();
            string Price = "";
            SqlCommand cnd = new SqlCommand(query, conc);
            SqlDataReader read = cnd.ExecuteReader();
            while (read.Read())
            {
                Price = read[0].ToString();
            }
            conc.Close();
            return Price;
        }

        public int amountCalculator(string val1, string val2)
        {
            int amount = Convert.ToInt32(val1) * Convert.ToInt32(val2);
            return amount;
        }

        public void datagridcombox(DataGridViewComboBoxCell c, string q)
        {
            c.Items.Clear();
            conc.Open();
            SqlCommand cnd = new SqlCommand(q, conc);
            SqlDataReader reader = cnd.ExecuteReader();
            while (reader.Read())
            {
                c.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conc.Close();
        }
       
    
        public void Salesmen_insertValues(string query)
        {
            conc.Open();
            SqlCommand cmd = new SqlCommand(query, conc);
            cmd.ExecuteNonQuery();
            conc.Close();
        }

        public void Salesmen_update_data(String query)
        {
            conc.Open();
            SqlCommand cmd = new SqlCommand(query, conc);
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public void Del_data(String query)
        {
            conc.Open();
            SqlCommand cmd = new SqlCommand(query, conc);
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public void RequiredItem_insertValues(string query)
        {
            conc.Open();
            SqlCommand cmd = new SqlCommand(query, conc);
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public DataTable RequiredItem_disp(string query)
        {
            conc.Open();
            SqlCommand cmd = conc.CreateCommand();
            cmd.CommandText = query;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conc.Close();
            return dt;



        }


    }
}
