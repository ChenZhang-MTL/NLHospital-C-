using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NLHospitalLibrary;
using NLHBaseWindow;

namespace NLHospital
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmPatientsMgr : NLHBase
	{
		private System.Windows.Forms.DataGrid dgPatients;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		DataTable patients = new DataTable();
        DataSet m_oSP = new DataSet();

		public frmPatientsMgr()
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
            this.dgPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPatients.FlatMode = true;
            this.dgPatients.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgPatients.ForeColor = System.Drawing.Color.Black;
            this.dgPatients.GridLineColor = System.Drawing.Color.DimGray;
            this.dgPatients.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dgPatients.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgPatients.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgPatients.HeaderForeColor = System.Drawing.Color.White;
            this.dgPatients.LinkColor = System.Drawing.Color.MidnightBlue;
            this.dgPatients.Location = new System.Drawing.Point(0, 0);
            this.dgPatients.Name = "dgPatients";
            this.dgPatients.ParentRowsBackColor = System.Drawing.Color.DarkGray;
            this.dgPatients.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dgPatients.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dgPatients.SelectionForeColor = System.Drawing.Color.White;
            this.dgPatients.Size = new System.Drawing.Size(1356, 624);
            this.dgPatients.TabIndex = 7;
            // 
            // frmPatientsMgr
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 21);
            this.ClientSize = new System.Drawing.Size(1356, 624);
            this.Controls.Add(this.dgPatients);
            this.Name = "frmPatientsMgr";
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.frmPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPatients)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		private void frmPatient_Load(object sender, System.EventArgs e)
		{
			LoadPatientData();
		}
        /// <summary>
        /// 加载病人信息
        /// </summary>
		private void LoadPatientData()
		{
			Patients p = new Patients();
			dgPatients.DataBindings.Clear();
            patients = p.GetData();
			dgPatients.DataSource = patients;
		}


    }
}
