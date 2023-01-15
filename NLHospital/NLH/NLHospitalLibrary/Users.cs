using System;
using System.Data;
using System.Data.SqlClient ;

namespace NLHospitalLibrary
{
	/// <summary>
	/// Summary description for Users.
	/// </summary>
	public class Users
	{
		private SqlConnection m_oCn ;    
		private SqlDataAdapter m_oDA;
//		private string m_sClassName = "Users";
		private string sSQL;

		public Users()
		{
			//
			// TODO: Add constructor logic here
			//
			SqlCommand oSelCmd;
            SqlCommand oUpdateCmd;

            InitializeConnection();

			sSQL = "SELECT UserID,UserType,UserName, Password,Ref FROM Login ";
			oSelCmd = new SqlCommand(sSQL, m_oCn);
			oSelCmd.CommandType = CommandType.Text;

			var upstr = "UPDATE Login   SET Password = @Password  WHERE UserID=@UserID";

            oUpdateCmd = new SqlCommand(upstr, m_oCn);
            oUpdateCmd.CommandType = CommandType.Text;
            oUpdateCmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.NVarChar, 30, "UserID"));
            oUpdateCmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 30, "Password"));

            m_oDA = new SqlDataAdapter();
			m_oDA.SelectCommand = oSelCmd;
			m_oDA.UpdateCommand = oUpdateCmd;


            m_oCn = null;

		}
        public DataTable GetData(  )
        {
            try
            {
                DataTable dt = new DataTable();
                m_oDA.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public DataTable FindData(string ID, string pass)
		{
			DataTable res = new DataTable();
			try
			{
                InitializeConnection();
                m_oCn.Open();
                var cmd = m_oCn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoginP";
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@pass", pass);
				var da = new SqlDataAdapter();
				da.SelectCommand = cmd;
				da.Fill(res);
				if (res.Rows.Count==0)
				{
					return null;
				}
				m_oCn.Close();
				m_oCn = null;
                return res;
            }
			catch (Exception ex)
			{
				return null;
			}
          
		}
		public void AddDoctor(string docid,string name,string pass) {
            InitializeConnection();
            m_oCn.Open();
            var cmd = m_oCn.CreateCommand(); 
            cmd.CommandText = "INSERT into  Login(UserID,UserType,UserName, Password,Ref) values(@UserID,@UserType,@UserName, @Password,@Ref) ";
            cmd.Parameters.AddWithValue("@UserID", "" + (GetData().Rows.Count + 1));
            cmd.Parameters.AddWithValue("@UserType", "Doctor");
            cmd.Parameters.AddWithValue("@UserName", name);
            cmd.Parameters.AddWithValue("@Password", pass);
            cmd.Parameters.AddWithValue("@Ref", docid);
            cmd.ExecuteNonQuery();
            return;
        }
		public bool UpdateDoctorPassWord(string doctorid, string pass) {
            DataSet thisDataSet = new DataSet();
          
            try
            {
                m_oDA.Fill(thisDataSet, "Login");
				var tb = thisDataSet.Tables["Login"].Rows;
            
                for (int n = 0; n < tb.Count; n++)
                {
                    if (tb[n]["Ref"].ToString() == doctorid&& tb[n]["UserType"].ToString()== "Doctor")
                    {
                        tb[n]["Password"] = pass;
                        m_oDA.Update(thisDataSet.GetChanges(), "Login");
                        return true;
                    }
                }
                return false;
            }
            catch(Exception ex)
            {
				return false; 
            }
             
        }
		private void InitializeConnection()
		{
			m_oCn = new SqlConnection(Settings.ConnectString);
		}
	}
}
