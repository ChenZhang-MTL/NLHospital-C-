using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using NLHospitalLibrary;
using NLHBaseWindow;


namespace NLHospital
{
	/// <summary>
	/// Summary description for frmMenu.
	/// </summary>
	public class frmMenu : NLHBase
	{
		private System.Windows.Forms.Label lblAdministrator;
		private System.Windows.Forms.Button btnDoctors;
		private System.Windows.Forms.Label lblAdmin;
		private System.Windows.Forms.Panel pnlAdministrator;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnPatients;
		private System.Windows.Forms.Button btnSurgery;
		private System.Windows.Forms.Label lblNurses;
		private System.Windows.Forms.Button btnForSurgery;
		private System.Windows.Forms.Button btnBilling;
		private System.Windows.Forms.Button btn_bedpatient;
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.Panel pnlDoctors;
		private System.Windows.Forms.Panel pnlNurses;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
        private Panel pnlRecorder;
        private Label label1;
        private Button btnRecordPatient;
        private Label label5;
        public static CurrentUser oCurrent = new CurrentUser();

		public frmMenu()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
             pnlRecorder.Location=    pnlNurses.Location=   pnlDoctors.Location = pnlAdministrator.Location;
            this.FormBorderStyle= FormBorderStyle.FixedSingle;
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
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
            Application.Exit();
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.pnlAdministrator = new System.Windows.Forms.Panel();
            this.btnBilling = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.pnlDoctors = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSurgery = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNurses = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_bedpatient = new System.Windows.Forms.Button();
            this.btnForSurgery = new System.Windows.Forms.Button();
            this.lblNurses = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pnlRecorder = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecordPatient = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlAdministrator.SuspendLayout();
            this.pnlDoctors.SuspendLayout();
            this.pnlNurses.SuspendLayout();
            this.pnlRecorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAdministrator
            // 
            this.pnlAdministrator.Controls.Add(this.btnBilling);
            this.pnlAdministrator.Controls.Add(this.lblAdmin);
            this.pnlAdministrator.Controls.Add(this.btnDoctors);
            this.pnlAdministrator.Controls.Add(this.lblAdministrator);
            this.pnlAdministrator.Location = new System.Drawing.Point(32, 13);
            this.pnlAdministrator.Name = "pnlAdministrator";
            this.pnlAdministrator.Size = new System.Drawing.Size(640, 194);
            this.pnlAdministrator.TabIndex = 0;
            this.pnlAdministrator.Visible = false;
            // 
            // btnBilling
            // 
            this.btnBilling.Location = new System.Drawing.Point(320, 129);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(272, 37);
            this.btnBilling.TabIndex = 5;
            this.btnBilling.Text = "Bill Patient";
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(32, 52);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(323, 18);
            this.lblAdmin.TabIndex = 4;
            this.lblAdmin.Text = "Please select one of the following:";
            // 
            // btnDoctors
            // 
            this.btnDoctors.Location = new System.Drawing.Point(16, 129);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Size = new System.Drawing.Size(272, 37);
            this.btnDoctors.TabIndex = 1;
            this.btnDoctors.Text = "Manage Doctors";
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrator.Location = new System.Drawing.Point(32, 13);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(149, 25);
            this.lblAdministrator.TabIndex = 0;
            this.lblAdministrator.Text = "Administration";
            // 
            // pnlDoctors
            // 
            this.pnlDoctors.Controls.Add(this.label3);
            this.pnlDoctors.Controls.Add(this.btnSurgery);
            this.pnlDoctors.Controls.Add(this.btnPatients);
            this.pnlDoctors.Controls.Add(this.label2);
            this.pnlDoctors.Location = new System.Drawing.Point(717, 13);
            this.pnlDoctors.Name = "pnlDoctors";
            this.pnlDoctors.Size = new System.Drawing.Size(640, 194);
            this.pnlDoctors.TabIndex = 2;
            this.pnlDoctors.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Please elect one of the following:";
            // 
            // btnSurgery
            // 
            this.btnSurgery.Location = new System.Drawing.Point(336, 129);
            this.btnSurgery.Name = "btnSurgery";
            this.btnSurgery.Size = new System.Drawing.Size(272, 37);
            this.btnSurgery.TabIndex = 2;
            this.btnSurgery.Text = "Surgery Report";
            this.btnSurgery.Visible = false;
            // 
            // btnPatients
            // 
            this.btnPatients.Location = new System.Drawing.Point(32, 129);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(272, 37);
            this.btnPatients.TabIndex = 1;
            this.btnPatients.Text = "Patients";
            this.btnPatients.Click += new System.EventHandler(this.btnDischarge_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Doctors";
            // 
            // pnlNurses
            // 
            this.pnlNurses.Controls.Add(this.label4);
            this.pnlNurses.Controls.Add(this.btn_bedpatient);
            this.pnlNurses.Controls.Add(this.btnForSurgery);
            this.pnlNurses.Controls.Add(this.lblNurses);
            this.pnlNurses.Location = new System.Drawing.Point(717, 226);
            this.pnlNurses.Name = "pnlNurses";
            this.pnlNurses.Size = new System.Drawing.Size(640, 194);
            this.pnlNurses.TabIndex = 3;
            this.pnlNurses.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select one of the following:";
            // 
            // btn_bedpatient
            // 
            this.btn_bedpatient.Location = new System.Drawing.Point(32, 129);
            this.btn_bedpatient.Name = "btn_bedpatient";
            this.btn_bedpatient.Size = new System.Drawing.Size(272, 37);
            this.btn_bedpatient.TabIndex = 2;
            this.btn_bedpatient.Text = "Report";
            this.btn_bedpatient.Click += new System.EventHandler(this.btn_bedpatient_Click);
            // 
            // btnForSurgery
            // 
            this.btnForSurgery.Location = new System.Drawing.Point(336, 129);
            this.btnForSurgery.Name = "btnForSurgery";
            this.btnForSurgery.Size = new System.Drawing.Size(272, 37);
            this.btnForSurgery.TabIndex = 1;
            this.btnForSurgery.Text = "Surgery Report";
            this.btnForSurgery.Visible = false;
            // 
            // lblNurses
            // 
            this.lblNurses.AutoSize = true;
            this.lblNurses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNurses.Location = new System.Drawing.Point(64, 13);
            this.lblNurses.Name = "lblNurses";
            this.lblNurses.Size = new System.Drawing.Size(80, 25);
            this.lblNurses.TabIndex = 0;
            this.lblNurses.Text = "Nurses";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(269, 239);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(150, 37);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pnlRecorder
            // 
            this.pnlRecorder.Controls.Add(this.label1);
            this.pnlRecorder.Controls.Add(this.btnRecordPatient);
            this.pnlRecorder.Controls.Add(this.label5);
            this.pnlRecorder.Location = new System.Drawing.Point(717, 446);
            this.pnlRecorder.Name = "pnlRecorder";
            this.pnlRecorder.Size = new System.Drawing.Size(640, 194);
            this.pnlRecorder.TabIndex = 6;
            this.pnlRecorder.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select one of the following:";
            // 
            // btnRecordPatient
            // 
            this.btnRecordPatient.Location = new System.Drawing.Point(32, 129);
            this.btnRecordPatient.Name = "btnRecordPatient";
            this.btnRecordPatient.Size = new System.Drawing.Size(272, 37);
            this.btnRecordPatient.TabIndex = 2;
            this.btnRecordPatient.Text = "Patient";
            this.btnRecordPatient.Click += new System.EventHandler(this.btnRecordPatient_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Admissions";
            // 
            // frmMenu
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 21);
            this.ClientSize = new System.Drawing.Size(1314, 603);
            this.Controls.Add(this.pnlRecorder);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.pnlDoctors);
            this.Controls.Add(this.pnlAdministrator);
            this.Controls.Add(this.pnlNurses);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlAdministrator.ResumeLayout(false);
            this.pnlAdministrator.PerformLayout();
            this.pnlDoctors.ResumeLayout(false);
            this.pnlDoctors.PerformLayout();
            this.pnlNurses.ResumeLayout(false);
            this.pnlNurses.PerformLayout();
            this.pnlRecorder.ResumeLayout(false);
            this.pnlRecorder.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void btnDoctors_Click(object sender, System.EventArgs e)
		{
			frmDoctors doctorsForm = new frmDoctors ();
			doctorsForm.Visible = true;
			doctorsForm.Activate();
		}

		private void btnQuit_Click(object sender, System.EventArgs e)
		{
			Application.Exit ();
		}

		private void frmMenu_Load(object sender, System.EventArgs e)
		{
		}

		public void SelectUser()
		{
			switch (oCurrent.UserType )
			{
				case "Admin":
					pnlAdministrator.Visible = true;
					break;
				case "Doctor":
					pnlDoctors.Visible = true;
					break;
				case "Nurse":
					pnlNurses.Visible = true;
                    break;
                case "Admissions":
                    pnlRecorder.Visible = true;
                    break;
			}
			
		}

		private void btnDischarge_Click(object sender, System.EventArgs e)
		{
            frmPatientsMgr patientsMgr = new frmPatientsMgr();
            patientsMgr.Visible = true;
            patientsMgr.Activate();

            frmSinglePatient frmSinglePatient = new frmSinglePatient(oCurrent.UserType == "Doctor");
            frmSinglePatient.Visible = true;
            frmSinglePatient.Activate();

        }

		private void btnBilling_Click(object sender, System.EventArgs e)
		{
			frmBillPatient billForm = new frmBillPatient ();
			billForm.Visible = true;
			billForm.Activate();
		}

        private void btn_bedpatient_Click(object sender, EventArgs e)
        {
            frmPatientsList patientsList = new frmPatientsList();
            patientsList.Visible = true;
            patientsList.Activate();
        
        }

        private void btnRecordPatient_Click(object sender, EventArgs e)
        {
            frmPatientsMgr patientsMgr = new frmPatientsMgr();
            patientsMgr.Visible = true;
            patientsMgr.Activate();

            frmSinglePatient frmSinglePatient = new frmSinglePatient(oCurrent.UserType == "Doctor");
            frmSinglePatient.Visible = true;
            frmSinglePatient.Activate();
        }
    }
}
