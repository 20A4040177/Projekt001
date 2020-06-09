using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace EShop
{
    class Functions
    {
        public static SqlConnection conn;
        public static string connString;
        public static void Connect()
        {
            connString="Data Source=DESKTOP-BUQ7P2D\\SQLEXPRESS;Initial Catalog=EShop;Integrated Security=True";
            conn=new SqlConnection();
            conn.ConnectionString=connString;
            conn.Open();

        }
        public static void Disconnect()
        {
            if(conn.State==ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
                conn=null;
            }
        }
        public static DataTable getDataToTable(string sql)
        {
            SqlDataAdapter MyData = new SqlDataAdapter();
            MyData.SelectCommand = new SqlCommand();
            MyData.SelectCommand.Connection = Functions.conn;
            MyData.SelectCommand.CommandText = sql;
            DataTable table = new DataTable();
            MyData.Fill(table);
            return table;
        }
        public static bool checkID(string sql)
        {
            SqlDataAdapter MyData = new SqlDataAdapter(sql,Functions.conn);
            DataTable table = new DataTable();
            MyData.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;



        }
        public static void modifySQL(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Functions.conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery(); 
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;


        }
        public static void deleteSQL(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Functions.conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception)
            {
                MessageBox.Show("This data is currently in use","Warning",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            cmd.Dispose();
            cmd = null;


        }
        public static bool checkDate(string date)
        {
            string[] parts = date.Split('/');
            if ((Convert.ToInt32(parts[0]) >= 1900) && (Convert.ToInt32(parts[1]) >= 1) && (Convert.ToInt32(parts[1]) <= 12) && (Convert.ToInt32(parts[2]) >= 1) && (Convert.ToInt32(parts[2]) <= 31))
            {
                //if (Convert.ToInt32(parts[1]) == 2 && Convert.ToInt32(parts[2]) <= 29 && Convert.ToInt32(parts[0]) % 4 == 0)
                    //return true;
                if (Convert.ToInt32(parts[1]) == 2 && Convert.ToInt32(parts[2]) >= 29 && Convert.ToInt32(parts[0]) % 4 != 0)
                    return false;
                else return true;
            }
            else return false;
        }
        public static string convertToDate(string date)
        {
            string[] parts = date.Split('/');
            string dt = String.Format("{0},{1},{2}", parts[0], parts[1], parts[2]);
            return dt;

        }
        public static void fillComboBox(string sql,ComboBox cbo,string ID, string Name)
        {
            SqlDataAdapter MyData = new SqlDataAdapter(sql, Functions.conn);
            DataTable table = new DataTable();
            MyData.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ID;
            cbo.DisplayMember = Name;
        }
        public static string getFieldValues(string sql)
        {
            string ID = "";
            SqlCommand cmd = new SqlCommand(sql,Functions.conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ID = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ID;

        }
        public static int getFieldValuesInt(string sql)
        {
            int ID=new int();
            SqlCommand cmd = new SqlCommand(sql, Functions.conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ID = Convert.ToInt32(reader.GetValue(0));
            }
            reader.Close();
            return ID;
        }

       /* public static bool checkINT(string input)
        {
     
        }*/
        public static string CreateKey(string tiento )
      {
         string key = tiento;
         string[] partsDay;
         partsDay = DateTime.Now.ToShortDateString().Split('/');
//Ví dụ 07/08/2009
        string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
         key = key + d;
       string[] partsTime;
       partsTime = DateTime.Now.ToLongTimeString().Split(':');
//Ví dụ 7:08:03 PM hoặc 7:08:03 AM
        if( partsTime[2].Substring(3, 2) == "PM" )
        partsTime[0] = ConvertTimeTo24(partsTime[0]);
        if (partsTime[2].Substring(3, 2) == "AM")
            if (partsTime[0].Length == 1)
                partsTime[0] = "0" + partsTime[0];
        //Xóa ký tự trắng và PM hoặc AM
        partsTime[2] = partsTime[2].Remove(2, 3);
        string t;
        t = String.Format("{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
        key = key + t;
        return key;
      }
        public static string ConvertTimeTo24(string hour)
{
        string h = "";
 switch (hour)
{
case "1":
h = "13";
break;
case "2":
h = "14";
break;
case "3":
h = "15";
break;
case "4":
h = "16";
break;
case "5":
h = "17";
break;
case "6":
h = "18";
break;
case "7":
h = "19";
break;
case "8":
h = "20";
break;
case "9":
h = "21";
break;
case "10":
h = "22";
break;
case "11":
h = "23";
break;
case "12":
h = "0";
break;
}
 return h;
}


        
        
    }

}
