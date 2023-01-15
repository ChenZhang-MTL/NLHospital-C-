using System;
using System.Data ;
using System.Data.SqlClient ;

namespace NLHospitalLibrary
{
	/// <summary>
	/// Summary description for Extras.
	/// </summary>
	public class Extras
	{
		private DataSet m_oDS ; 
		private SqlConnection m_oCn ;    
		private SqlDataAdapter m_oDA;
		private string m_sClassName = "Extras";
		private string sSQL;

		public Extras()
		{
			//
			// TODO: Add constructor logic here
			//
			SqlCommand oSelCmd;
			SqlCommand oInsCmd;
			SqlCommand oUpdCmd;

			InitializeConnection();

			sSQL = "SELECT PatientID, AdmissionRecordID, TV, Phone, " +
				" SemiPrivate, Private FROM Extras " ;
			oSelCmd = null;
			oSelCmd = new SqlCommand(sSQL, m_oCn);
			oSelCmd.CommandType = CommandType.Text;

			sSQL = "UPDATE Extras " +
				" SET AdmissionRecordID = @AdmissionRecordID, PatientID = @PatientID, " +
				" TV = @TV, Phone = @Phone, SemiPrivate = @SemiPrivate, Private = @Private " +
				" WHERE AdmissionRecordID = @AdmissionRecordID ";
			oUpdCmd = null;
			oUpdCmd = new SqlCommand(sSQL, m_oCn);
			oUpdCmd.CommandType = CommandType.Text;
			oUpdCmd.Parameters.Add(new SqlParameter("@AdmissionRecordID", SqlDbType.NChar, 4, "AdmissionRecordID"));
			oUpdCmd.Parameters.Add(new SqlParameter("@PatientID", SqlDbType.NVarChar, 15, "PatientID"));
			oUpdCmd.Parameters.Add(new SqlParameter("@TV", SqlDbType.Bit, 1, "TV"));
			oUpdCmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.Bit, 1, "Phone"));
			oUpdCmd.Parameters.Add(new SqlParameter("@SemiPrivate", SqlDbType.Bit,1, "SemiPrivate"));
			oUpdCmd.Parameters.Add(new SqlParameter("@Private", SqlDbType.Bit, 1, "Private"));
			
			sSQL = "INSERT INTO Extras " +
				" (AdmissionRecordID, PatientID, TV, " +
				" Phone, SemiPrivate, Private )" +
				" VALUES (@AdmissionRecordID, @PatientID, @TV, " +
				" @Phone, @SemiPrivate, @Private)";
			oInsCmd = null;
			oInsCmd = new SqlCommand(sSQL, m_oCn);
			oInsCmd.CommandType = CommandType.Text;
			oInsCmd.Parameters.Add(new SqlParameter("@AdmissionRecordID", SqlDbType.NChar, 4, "AdmissionRecordID"));
			oInsCmd.Parameters.Add(new SqlParameter("@PatientID", SqlDbType.NVarChar, 15, "PatientID"));
			oInsCmd.Parameters.Add(new SqlParameter("@TV", SqlDbType.Bit, 1, "TV"));
			oInsCmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.Bit, 1, "Phone"));
			oInsCmd.Parameters.Add(new SqlParameter("@SemiPrivate", SqlDbType.Bit,1, "SemiPrivate"));
			oInsCmd.Parameters.Add(new SqlParameter("@Private", SqlDbType.Bit, 1, "Private"));


			m_oDA = new SqlDataAdapter();
			m_oDA.SelectCommand = oSelCmd;
			m_oDA.UpdateCommand = oUpdCmd;
			m_oDA.InsertCommand = oInsCmd;

			m_oCn = null;

		}

		public DataSet GetData()
		{
			m_oDS = new DataSet();
			m_oDA.Fill(m_oDS, m_sClassName);
			return m_oDS;
		}

		private void InitializeConnection()
		{
			m_oCn = new SqlConnection(Settings.ConnectString);
		}

		public bool AddData(string aID, string pID, bool tv, 
			bool phone, bool semi, bool priv,SqlConnection cnn, SqlTransaction trans)
		{
			try
			{
				DataTable dt = new DataTable();
				var adpt = new SqlDataAdapter();
                var sql =  "INSERT INTO Extras " +
                " (AdmissionRecordID, PatientID, TV, " +
                " Phone, [SemiPrivate], Private )" +
                " VALUES (@AdmissionRecordID, @PatientID, @TV, " +
                " @Phone, @SemiPrivate, @Private)";
                var ocmd = new SqlCommand(sql, cnn);
                ocmd.CommandType = CommandType.Text;
                ocmd.Transaction = trans;
                ocmd.Parameters.Add(new SqlParameter("@AdmissionRecordID", SqlDbType.NChar, 4, "AdmissionRecordID"));
                ocmd.Parameters.Add(new SqlParameter("@PatientID", SqlDbType.NVarChar, 15, "PatientID"));
                ocmd.Parameters.Add(new SqlParameter("@TV", SqlDbType.Bit, 1, "TV"));
                ocmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.Bit, 1, "Phone"));
                ocmd.Parameters.Add(new SqlParameter("@SemiPrivate", SqlDbType.Bit, 1, "SemiPrivate"));
                ocmd.Parameters.Add(new SqlParameter("@Private", SqlDbType.Bit, 1, "Private"));
				adpt.InsertCommand = ocmd;
				adpt.SelectCommand = new SqlCommand("select top 0 * from Extras", cnn, trans);
                adpt.Fill (dt);
                DataRow thisRow = dt.NewRow();
                thisRow["AdmissionRecordID"] = aID;
                thisRow["PatientID"] = pID;
                thisRow["TV"] = tv;
                thisRow["Phone"] = phone;
                thisRow["SemiPrivate"] = semi;
                thisRow["Private"] = priv;
                dt.Rows.Add(thisRow);
                return adpt.Update(dt.GetChanges())>0;

            }
			catch (Exception e)
			{
				return false;
			}
		}

		public DataSet FindData(string ID)
		{
			InitializeConnection();
			m_oCn.Open();
			DataSet thisDataSet = new DataSet();
			DataSet foundDataSet = new DataSet();
			try
			{
				m_oDA.Fill (thisDataSet, m_sClassName);
				for (int n = 0; n < thisDataSet.Tables["Extras"].Rows.Count ; n++)
				{
					if (thisDataSet.Tables["Extras"].Rows[n]["AdmissionRecordID"].ToString () == ID)
					{
						m_oDA.Fill(foundDataSet,n,1,"Extras");							
					}
				}
			}
			catch 
			{
			}
			finally
			{
				m_oCn.Close();
				m_oCn = null;
			}
			return foundDataSet;
		}
	}
}
