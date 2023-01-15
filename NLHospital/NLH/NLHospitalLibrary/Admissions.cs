using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace NLHospitalLibrary
{
    /// <summary>
    /// Summary description for Admissions.
    /// </summary>
    public class Admissions
    {
        private DataSet m_oDS;
        private SqlConnection m_oCn;
        private SqlDataAdapter m_oDA;
        private string m_sClassName = "AdmissionRecords";
        private string sSQL;

        public Admissions()
        {
            //
            // TODO: Add constructor logic here
            //
            SqlCommand oSelCmd;

            InitializeConnection();

            sSQL = "SELECT AdmissionID, PatientID, BedNumber, " +
                " SurgeryScheduled, SurgeryDate, AdmitDate, DischargeDate,Doctor" +
                " FROM	AdmissionRecords " +
                " ORDER BY AdmissionID ";
            oSelCmd = null;
            oSelCmd = new SqlCommand(sSQL, m_oCn);
            oSelCmd.CommandType = CommandType.Text;

            var updatesql = "UPDATE AdmissionRecords set  " +
                "AdmissionID=@AdmissionID,PatientID=@PatientID,BedNumber=@BedNumber," +
                "SurgeryScheduled=@SurgeryScheduled,SurgeryDate=@SurgeryDate," +
                "AdmitDate=@AdmitDate,DischargeDate=@DischargeDate,Doctor=@Doctor";
            var ucmd = new SqlCommand(updatesql, m_oCn);
            ucmd.CommandType = CommandType.Text;
            ucmd.Parameters.Add(new SqlParameter("@AdmissionID", SqlDbType.NVarChar, 30, "AdmissionID"));
            ucmd.Parameters.Add(new SqlParameter("@PatientID", SqlDbType.NVarChar, 15, "PatientID"));
            ucmd.Parameters.Add(new SqlParameter("@BedNumber", SqlDbType.NVarChar, 3, "BedNumber"));
            ucmd.Parameters.Add(new SqlParameter("@SurgeryScheduled", SqlDbType.Bit, 1, "SurgeryScheduled"));
            ucmd.Parameters.Add(new SqlParameter("@SurgeryDate", SqlDbType.DateTime, 1, "SurgeryDate"));
            ucmd.Parameters.Add(new SqlParameter("@AdmitDate", SqlDbType.DateTime, 1, "AdmitDate"));
            ucmd.Parameters.Add(new SqlParameter("@DischargeDate", SqlDbType.DateTime, 1, "DischargeDate"));
            ucmd.Parameters.Add(new SqlParameter("@Doctor", SqlDbType.NVarChar, 15, "Doctor"));

           

            m_oDA = new SqlDataAdapter();
            m_oDA.SelectCommand = oSelCmd;
            m_oDA.UpdateCommand = ucmd;
          m_oCn = null;

        }



        public DataRow FindData(string ID)
        {
            InitializeConnection();
            m_oCn.Open();
            DataSet thisDataSet = new DataSet();
            DataSet foundDataSet = new DataSet();
            try
            {
                m_oDA.Fill(thisDataSet, m_sClassName);
                for (int n = 0; n < thisDataSet.Tables["AdmissionRecords"].Rows.Count; n++)
                {
                    if (thisDataSet.Tables["AdmissionRecords"].Rows[n]["AdmissionID"].ToString() == ID)
                    {
                        return thisDataSet.Tables["AdmissionRecords"].Rows[n];
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
            return null;
        }
        public DataRow FindLatest(string patientid)
        {
            InitializeConnection();
            m_oCn.Open();
            DataSet thisDataSet = new DataSet();
            try
            {
                m_oDA.Fill(thisDataSet, m_sClassName);
                for (int n = 0; n < thisDataSet.Tables["AdmissionRecords"].Rows.Count; n++)
                {
                    if (thisDataSet.Tables["AdmissionRecords"].Rows[n]["PatientID"].ToString() == patientid && thisDataSet.Tables["AdmissionRecords"].Rows[n]["DischargeDate"] == DBNull.Value)
                    {
                        return thisDataSet.Tables["AdmissionRecords"].Rows[n];
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
            return null;
        }

        public DataSet GetData()
        {
            m_oDS = new DataSet();
            m_oDA.Fill(m_oDS, m_sClassName);
            return m_oDS;
        }

        public bool Add(string AdmissionID, string PatientID, string BedNumber, bool SurgeryScheduled,DateTime? SurgeryDate, DateTime  AdmitDate, DateTime?  DischargeDate,string Doctor,SqlConnection cnn, SqlTransaction trans) {
            try
            {
                DataTable dt = new DataTable();
                var adpt = new SqlDataAdapter();
                var insql = "INSERT INTO  AdmissionRecords( AdmissionID, PatientID, BedNumber, SurgeryScheduled, SurgeryDate, AdmitDate, DischargeDate,Doctor)" +
         "values(@AdmissionID,@PatientID,@BedNumber,@SurgeryScheduled,@SurgeryDate,@AdmitDate,@DischargeDate,@Doctor)";
                var incmd = new SqlCommand(insql, cnn);
                incmd.Transaction = trans;
                incmd.CommandType = CommandType.Text;
                incmd.Parameters.Add(new SqlParameter("@AdmissionID", SqlDbType.NVarChar, 30, "AdmissionID"));
                incmd.Parameters.Add(new SqlParameter("@PatientID", SqlDbType.NVarChar, 15, "PatientID"));
                incmd.Parameters.Add(new SqlParameter("@BedNumber", SqlDbType.NVarChar, 3, "BedNumber"));
                incmd.Parameters.Add(new SqlParameter("@SurgeryScheduled", SqlDbType.Bit, 1, "SurgeryScheduled"));
                incmd.Parameters.Add(new SqlParameter("@SurgeryDate", SqlDbType.DateTime, 1, "SurgeryDate"));
                incmd.Parameters.Add(new SqlParameter("@AdmitDate", SqlDbType.DateTime, 1, "AdmitDate"));
                incmd.Parameters.Add(new SqlParameter("@DischargeDate", SqlDbType.DateTime, 1, "DischargeDate"));
                incmd.Parameters.Add(new SqlParameter("@Doctor", SqlDbType.NVarChar, 15, "Doctor"));
                adpt.InsertCommand = incmd;
                adpt.SelectCommand = new SqlCommand("select top 0 * from  AdmissionRecords", cnn,trans);
                adpt.Fill(dt);
                DataRow thisRow = dt.NewRow();
                thisRow["Doctor"] = Doctor;
                thisRow["AdmissionID"] =AdmissionID;
                thisRow["PatientID"] = PatientID;
                thisRow["BedNumber"] = BedNumber;
                thisRow["SurgeryScheduled"] = SurgeryScheduled;
                if (SurgeryDate == null||!SurgeryScheduled)
                {
                    thisRow["SurgeryDate"] = DBNull.Value;
                }
                else 
                {
                    thisRow["SurgeryDate"] = SurgeryDate;
                }
             
                thisRow["AdmitDate"] =AdmitDate;
                thisRow["DischargeDate"] = DBNull.Value;
                dt.Rows.Add(thisRow);
                return adpt.Update(dt.GetChanges())>0;

            }
            catch (Exception e)
            {
                return false;
            }
        }


        private void InitializeConnection()
        {
            m_oCn = new SqlConnection(Settings.ConnectString);
        }


        public bool SetPatientDischarge(string aid,DateTime time,SqlConnection cnn, SqlTransaction trans)
        {
            try
            {
                DataTable dt = new DataTable();
                var adpt = new SqlDataAdapter();
                var updatesql = "UPDATE AdmissionRecords set  " +
            "DischargeDate=@DischargeDate where DischargeDate is null and @AdmissionID=AdmissionID";
                var ucmd = new SqlCommand(updatesql,cnn);
                ucmd.CommandType = CommandType.Text;
                ucmd.Parameters.Add(new SqlParameter("@AdmissionID", SqlDbType.NVarChar, 30, "AdmissionID"));
                ucmd.Parameters.Add(new SqlParameter("@DischargeDate", SqlDbType.DateTime, 1, "DischargeDate"));
                ucmd.Transaction = trans;
                adpt.UpdateCommand = ucmd;
                var datarow= FindData(aid);
                datarow["DischargeDate"] = time;
                return adpt.Update(datarow.Table.GetChanges()) > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public int GetDays(string ID)
        {
            int days;
            DateTime dis = new DateTime();
            DateTime ad = new DateTime();

            var dt = this.FindData(ID);

            ad = Convert.ToDateTime(dt["AdmitDate"]);
            dis = Convert.ToDateTime(dt["DischargeDate"]);

            days = dis.Day - ad.Day;

            return days;

        }

        /// <summary>
        /// 获取在指定床上的病人ID 和医生ID
        /// </summary>
        /// <param name="bednum"></param>
        /// <returns></returns>
        public string[] FindOnBed(string bednum)
        {
            string[] res = new string[2];
            foreach (DataRow row in GetData().Tables[m_sClassName].Rows)
            {
                if (row["BedNumber"].ToString() == bednum && row["DischargeDate"] != DBNull.Value)
                {
                    res[0] = row["PatientID"].ToString();
                    res[1] = row["Doctor"].ToString();
                }
            }
            return res;
        }

        public DataRow CalculatingFee(string aid,DateTime time)
        {
            DataTable dt = new DataTable();
            InitializeConnection();
            m_oCn.Open();

            var cmd = m_oCn.CreateCommand();
            cmd.CommandText = "CalculatingFee";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AdmissionRecordID", aid);
            cmd.Parameters.AddWithValue("timex", time);

            var adap = new SqlDataAdapter();
            adap.SelectCommand = cmd;
            adap.Fill(dt);

            m_oCn.Close();
            m_oCn = null;
            return dt.Rows.Count == 0 ? null : dt.Rows[0];
        }
    }
}

