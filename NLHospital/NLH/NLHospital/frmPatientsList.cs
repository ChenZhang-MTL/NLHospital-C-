using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NLHospitalLibrary;
using NLHBaseWindow;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace NLHospital
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmPatientsList : NLHBase
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		DataSet m_oDS = new DataSet();
		private DataGrid dgPatients;
        private CheckedListBox cb_roomsx;
        private Button button1;
        DataSet m_oSP = new DataSet();

       
		public frmPatientsList()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
           

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.dgPatients = new System.Windows.Forms.DataGrid();
            this.cb_roomsx = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPatients
            // 
            this.dgPatients.AlternatingBackColor = System.Drawing.Color.LightGray;
            this.dgPatients.BackColor = System.Drawing.Color.Gainsboro;
            this.dgPatients.BackgroundColor = System.Drawing.Color.Silver;
            this.dgPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPatients.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dgPatients.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dgPatients.DataMember = "";
            this.dgPatients.FlatMode = true;
            this.dgPatients.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgPatients.ForeColor = System.Drawing.Color.Black;
            this.dgPatients.GridLineColor = System.Drawing.Color.DimGray;
            this.dgPatients.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dgPatients.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgPatients.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgPatients.HeaderForeColor = System.Drawing.Color.White;
            this.dgPatients.LinkColor = System.Drawing.Color.MidnightBlue;
            this.dgPatients.Location = new System.Drawing.Point(298, 12);
            this.dgPatients.Name = "dgPatients";
            this.dgPatients.ParentRowsBackColor = System.Drawing.Color.DarkGray;
            this.dgPatients.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dgPatients.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dgPatients.SelectionForeColor = System.Drawing.Color.White;
            this.dgPatients.Size = new System.Drawing.Size(898, 640);
            this.dgPatients.TabIndex = 40;
            // 
            // cb_roomsx
            // 
            this.cb_roomsx.FormattingEnabled = true;
            this.cb_roomsx.Location = new System.Drawing.Point(12, 36);
            this.cb_roomsx.Name = "cb_roomsx";
            this.cb_roomsx.Size = new System.Drawing.Size(280, 504);
            this.cb_roomsx.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 50);
            this.button1.TabIndex = 42;
            this.button1.Text = "find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPatientsList
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 21);
            this.ClientSize = new System.Drawing.Size(1211, 677);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_roomsx);
            this.Controls.Add(this.dgPatients);
            this.Name = "frmPatientsList";
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.frmDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPatients)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		private void frmDoctors_Load(object sender, System.EventArgs e)
		{
			LoadRoomData();
        }

		/// <summary>
		/// 加载下拉框的选项
		/// </summary>
		private void LoadRoomData()
		{
			Beds beds = new Beds();
			HashSet<string> names=new HashSet<string>();
			var tab=beds.GetData();
			foreach (DataRow row in tab.Rows)
			{
				if (!names.Contains(row["WardName"].ToString()))
				{
					names.Add(row["WardName"].ToString());
                }
			}
            cb_roomsx.DataSource =names.ToList();

		}
        /// <summary>
        /// 加载下拉框选择的房间的病人信息
        /// </summary>
        private void LoadPatientData() {
            List<string> rooms = new List<string>();
            foreach (var item in cb_roomsx.CheckedItems)
            {
                rooms.Add(item as string );
            }
            
            if (rooms.Count<=0)
                return;
            DataTable dt = new DataTable();
            dt.Columns.Add("WardName");
            dt.Columns.Add("BedNumber");
            dt.Columns.Add("PatientID");
            dt.Columns.Add("LastName");
            dt.Columns.Add("FirstName");
            dt.Columns.Add("DoctorID");
            Beds beds = new Beds();
            Admissions adms = new Admissions();
            Patients patients = new Patients();
            var tab = beds.GetData();
            foreach (DataRow row in tab.Rows)
            {
                if (rooms.Contains(row["WardName"].ToString())) {
                    var newrow= dt.NewRow();
                    newrow["BedNumber"] = row["BedNumber"];
                    if (Convert.ToBoolean(row["Occupied"]))
                    {
                        var ids = adms.FindOnBed(row["BedNumber"].ToString());
                        var patient= patients.FindData(ids[0]);
                        newrow["PatientID"] = ids[0];
                        newrow["LastName"] = patient["LastName"];
                        newrow["FirstName"] = patient["FirstName"];
                        newrow["DoctorID"] = ids[1];
                        newrow["WardName"] = row["WardName"].ToString();
                    }
                    else {
                        newrow["PatientID"] ="empty";
                        newrow["LastName"] = "empty";
                        newrow["FirstName"] = "empty";
                        newrow["DoctorID"] = "empty";
                        newrow["WardName"] = row["WardName"].ToString();
                    }
                    dt.Rows.Add(newrow);
                }
            }
            dgPatients.DataSource = dt;
        }


        private void btnQuit_Click(object sender, System.EventArgs e)
		{
			this.Close ();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            LoadPatientData();
        }
    }
}
