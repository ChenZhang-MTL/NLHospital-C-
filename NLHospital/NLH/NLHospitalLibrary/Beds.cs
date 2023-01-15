using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;

namespace NLHospitalLibrary
{
    /// <summary>
    /// Summary description for Beds.
    /// </summary>
    public class Beds
    {
        private DataSet m_oDS;
        private SqlConnection m_oCn;
        private SqlDataAdapter m_oDA;
        private string m_sClassName = "Bed";
        private string sSQL;

        public Beds()
        {
            //
            // TODO: Add constructor logic here
            //
            SqlCommand oSelCmd;

            InitializeConnection();

            sSQL = "SELECT BedNumber, BedType, Occupied, WardName " +
                " FROM	Beds " +
                " ORDER BY BedNumber ";
            oSelCmd = null;
            oSelCmd = new SqlCommand(sSQL, m_oCn);
            oSelCmd.CommandType = CommandType.Text;

            m_oDA = new SqlDataAdapter();
            m_oDA.SelectCommand = oSelCmd;

            m_oCn = null;

        }

        public DataTable GetData()
        {
            m_oDS = new DataSet();
            m_oDA.Fill(m_oDS, m_sClassName);
            return m_oDS.Tables[m_sClassName];
        }

        private void InitializeConnection()
        {
            m_oCn = new SqlConnection(Settings.ConnectString);
        }

        public string GetBed(string ward)
        {
            string bednumber = "none available";
            string tempbed;
            bool occupied = true;

            DataSet thisDataSet = new DataSet();

            m_oDA.Fill(thisDataSet, m_sClassName);

            for (int n = 0; n < thisDataSet.Tables["Beds"].Rows.Count; n++)
            {
                tempbed = thisDataSet.Tables["Beds"].Rows[n]["BedNumber"].ToString();
                if (tempbed.StartsWith(ward))
                {
                    occupied = Convert.ToBoolean(thisDataSet.Tables["Beds"].Rows[n]["Occupied"]);
                }

            }
            return bednumber;
        }

        /// <summary>
        /// 尝试入住房间
        /// </summary>
        /// <param name="Surgery"></param>
        /// <param name="insurance"></param>
        /// <param name="age"></param>
        /// <param name="room">0 普通 1半私人 2私人</param>
        /// <returns>[0]code -2 指定类型无法入住 -1 无法入住 1手术 2手术且更好的病房<br/>
		/// 3儿童 4儿童且更好的病房 5正常 6正常且更好的病房
		/// [1] 0 普通 1半私人 2私人  [2]bednum</returns>
        public object[] TryEnter(string want,bool Surgery, bool insurance, int age, int room)
        {
            object[] res = new object[3];
            var dt = GetData();
            var allbeds = new List<Bed1>();
            foreach (DataRow item in dt.Rows)
            {
                if (!Convert.ToBoolean(item["Occupied"]))
                {
                    var num = item["BedNumber"].ToString();
                    var type = item["BedType"].ToString();
                    var level = type == "Private" ? 2 : type == "Semi-Private" ? 1 : 0;
                    if (level >= room)
                    {
                        allbeds.Add(new Bed1()
                        {
                            Num = num,
                            WardName = item["WardName"].ToString(),
                        level = level,
                            Type = type,
                        });
                    }
                }
            }
            var beds = allbeds.Where(it => it.level >= room).ToList();
            if (beds.Count == 0)
            {
                res[0] = allbeds.Count == 0 ? -1 : -2;
                return res;
            }
            //优先入住同级别的普通病房 其次是儿童病房 其次是手术病房
            beds.Sort((a, b) => {
                if (a.level - b.level==0)
                {
                    if (a.WardName == "Surgery")
                    {
                        return 1;
                    }else if (a.WardName == "Pediatrics")
                    {
                        return 1;
                    }
                    return 0;
                }
                return a.level - b.level;
            });
            if (Surgery)
            {
                var prefer = beds.Where(it => it.WardName == "Surgery").ToList();
                if (prefer.Count != 0)
                {
                    res[0] = 1 + (prefer[0].level > room ? 1 : 0);
                    res[1] = prefer[0].level;
                    res[2] = prefer[0].Num;
                    return res;
                }
            }
            if (age < 18)
            {
                var prefer = beds.Where(it => it.WardName == "Pediatrics").ToList();
                if (prefer.Count != 0)
                {
                    res[0] = 3 + (prefer[0].level > room ? 1 : 0);
                    res[1] = prefer[0].level;
                    res[2] = prefer[0].Num;
                    return res;
                }
            }

            beds = beds.Where(it => it.WardName == want).ToList();
            if (beds.Count == 0)
            {
                res[0] =  -2;
                return res;
            }
            res[0] = 5 + (beds[0].level > room ? 1 : 0);
            res[1] = beds[0].level;
            res[2] = beds[0].Num;
            return res;
        }

        /// <summary>
        /// 设置占用状态
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool SetOccupy(string bed, bool occupy, SqlConnection cnn,SqlTransaction trans)
        {
            try
            {
                //确保一致性Occupied<>@ocp
                var cmd = new SqlCommand("update Beds set Occupied=@ocp where BedNumber=@bed and  Occupied<>@ocp", cnn);
                cmd.Transaction = trans;
                cmd.Parameters.AddWithValue("@ocp", occupy);
                cmd.Parameters.AddWithValue("@bed", bed);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}

public class Bed1
{
    public string Num;
    public string WardName;
    /// <summary>
    /// 0 普通 1半私人 2私人
    /// </summary>
    public int level;
    public string Type;
}