﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem
{
    public class Connect
    {
        SqlConnection con;

        public static string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zkons\Desktop\Shop-Management-System-master\StoreDb.mdf;Integrated Security=True;Connect Timeout=30";

        public  SqlConnection connect()
        {
            try
            {
                con = new SqlConnection(cs);
                con.Open();
                return con;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void closeConnection()
        {
            if(con != null)
            {
                con.Close();
            }
        }

        /*internal void Connect()
        {
            throw new NotImplementedException();
        }*/
    }
}
