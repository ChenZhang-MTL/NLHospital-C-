using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace NLHospitalLibrary
{
   public class Settings
    {
        static public string ConnectString = "Server=CHEN\\SQLEXPRESS;Database=NLHospital;Trusted_Connection=True;";
        static public SqlConnection InitializeConnection()
        {
            var cnn = new SqlConnection(Settings.ConnectString);
            cnn.Open();
            return cnn;
        }
    }
}
