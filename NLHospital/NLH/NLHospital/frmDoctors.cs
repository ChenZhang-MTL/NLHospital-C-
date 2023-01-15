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
	public class frmDoctors : NLHBase
	{
		private System.Windows.Forms.DataGrid dgDoctors;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		DataSet m_oDS = new DataSet();
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblSpecialty;
		private System.Windows.Forms.Label lblFName;
		private System.Windows.Forms.Label lblLName;
		private System.Windows.Forms.Label lblDoctorID;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtDoctorID;
		private System.Windows.Forms.ComboBox cboSpecialty;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
        private Label label1;
        private TextBox textPassword;
        private Button btn_updatepass;
        DataSet m_oSP = new DataSet();

		public frmDoctors()
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
            this.dgDoctors = new System.Windows.Forms.DataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_updatepass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboSpecialty = new System.Windows.Forms.ComboBox();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctors)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgDoctors
            // 
            this.dgDoctors.AlternatingBackColor = System.Drawing.Color.LightGray;
            this.dgDoctors.BackColor = System.Drawing.Color.Gainsboro;
            this.dgDoctors.BackgroundColor = System.Drawing.Color.Silver;
            this.dgDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDoctors.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dgDoctors.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dgDoctors.DataMember = "";
            this.dgDoctors.FlatMode = true;
            this.dgDoctors.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgDoctors.ForeColor = System.Drawing.Color.Black;
            this.dgDoctors.GridLineColor = System.Drawing.Color.DimGray;
            this.dgDoctors.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dgDoctors.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgDoctors.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgDoctors.HeaderForeColor = System.Drawing.Color.White;
            this.dgDoctors.LinkColor = System.Drawing.Color.MidnightBlue;
            this.dgDoctors.Location = new System.Drawing.Point(48, 13);
            this.dgDoctors.Name = "dgDoctors";
            this.dgDoctors.ParentRowsBackColor = System.Drawing.Color.DarkGray;
            this.dgDoctors.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dgDoctors.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dgDoctors.SelectionForeColor = System.Drawing.Color.White;
            this.dgDoctors.Size = new System.Drawing.Size(816, 323);
            this.dgDoctors.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_updatepass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textPassword);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cboSpecialty);
            this.panel1.Controls.Add(this.lblSpecialty);
            this.panel1.Controls.Add(this.lblFName);
            this.panel1.Controls.Add(this.lblLName);
            this.panel1.Controls.Add(this.lblDoctorID);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtDoctorID);
            this.panel1.Location = new System.Drawing.Point(32, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 219);
            this.panel1.TabIndex = 21;
            // 
            // btn_updatepass
            // 
            this.btn_updatepass.Location = new System.Drawing.Point(379, 161);
            this.btn_updatepass.Name = "btn_updatepass";
            this.btn_updatepass.Size = new System.Drawing.Size(150, 37);
            this.btn_updatepass.TabIndex = 34;
            this.btn_updatepass.Text = "change";
            this.btn_updatepass.Click += new System.EventHandler(this.btn_updatepass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Password:";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(176, 161);
            this.textPassword.MaxLength = 20;
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(172, 28);
            this.textPassword.TabIndex = 32;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(624, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 37);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(624, 116);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 37);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(624, 65);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(150, 37);
            this.btnFind.TabIndex = 29;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(624, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 37);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // cboSpecialty
            // 
            this.cboSpecialty.Items.AddRange(new object[] {
            "surgery",
            "pediatrics",
            "neurology",
            "skin",
            "other"});
            this.cboSpecialty.Location = new System.Drawing.Point(176, 129);
            this.cboSpecialty.Name = "cboSpecialty";
            this.cboSpecialty.Size = new System.Drawing.Size(336, 26);
            this.cboSpecialty.TabIndex = 27;
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new System.Drawing.Point(16, 132);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(89, 18);
            this.lblSpecialty.TabIndex = 26;
            this.lblSpecialty.Text = "Specialty";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(16, 94);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(107, 18);
            this.lblFName.TabIndex = 25;
            this.lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(16, 55);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(98, 18);
            this.lblLName.TabIndex = 24;
            this.lblLName.Text = "Last Name:";
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Location = new System.Drawing.Point(16, 16);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(98, 18);
            this.lblDoctorID.TabIndex = 23;
            this.lblDoctorID.Text = "Doctor ID:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(176, 94);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(336, 28);
            this.txtFirstName.TabIndex = 22;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(176, 55);
            this.txtLastName.MaxLength = 20;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(336, 28);
            this.txtLastName.TabIndex = 21;
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Location = new System.Drawing.Point(176, 16);
            this.txtDoctorID.MaxLength = 4;
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.Size = new System.Drawing.Size(200, 28);
            this.txtDoctorID.TabIndex = 20;
            // 
            // frmDoctors
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 21);
            this.ClientSize = new System.Drawing.Size(901, 623);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgDoctors);
            this.Name = "frmDoctors";
            this.Text = "Doctors";
            this.Load += new System.EventHandler(this.frmDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctors)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion


		private void frmDoctors_Load(object sender, System.EventArgs e)
		{
			LoadDoctorData();
			//LoadSpecialtyData();
		}

		private void LoadDoctorData()
		{
			Doctors oDoctor = new Doctors();
			dgDoctors.DataBindings.Clear();
			m_oDS = oDoctor.GetData();
			dgDoctors.DataSource = m_oDS.Tables ["Doctors"];
		}


		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			string docID = txtDoctorID.Text ;
			string LName = txtLastName.Text ;
			string FName = txtFirstName.Text;
			string sPec = cboSpecialty.SelectedItem.ToString();
			string sMsg = "";

			Doctors oDoctors = new Doctors();

			try
			{
				sMsg = oDoctors.AddData(docID,LName,FName,sPec);
                LoadDoctorData();
            }
			catch
			{
				sMsg = "Error saving data." + "\n\n" + e.ToString();
			}
			finally
			{
				MessageBox.Show (sMsg, "Add Record", MessageBoxButtons.OK);
			}
		}

		private void btnAdd_Click_1(object sender, System.EventArgs e)
		{
			string docID = txtDoctorID.Text ;
			string LName = txtLastName.Text ;
			string FName = txtFirstName.Text;
			string sPec = cboSpecialty.Text;
            string pass= textPassword.Text;
            string sMsg = "";

			Doctors oDoctors = new Doctors();
            Users users = new Users();
			try
			{
				sMsg = oDoctors.AddData(docID,LName,FName,sPec);
                ///添加一个医生账号
                users.AddDoctor(docID,FName+" "+LName, string.IsNullOrEmpty(pass)?"123456":pass);
                LoadDoctorData();
            }
			catch
			{
				sMsg = "Error saving data." + "\n\n" + e.ToString();
			}
			finally
			{
				MessageBox.Show (sMsg, "Add Record", MessageBoxButtons.OK);
			}
		}

		private void btnFind_Click(object sender, System.EventArgs e)
		{
			string docID = txtDoctorID.Text ;
			string sMsg = "";

			DataSet o_Find = new DataSet ();
			Doctors oDoctors = new Doctors();
            Users users = new Users();
            try
			{
				o_Find = oDoctors.FindData(docID);
				txtLastName.Text = o_Find.Tables["Doctors"].Rows[0]["LastName"].ToString ();
				txtFirstName.Text = o_Find.Tables["Doctors"].Rows[0]["FirstName"].ToString ();
				cboSpecialty.Text = o_Find.Tables["Doctors"].Rows[0]["Specialty"].ToString ();
                //cboSpecialty.SelectedIndex = this.BindingContext [o_Find, "Doctors"].Position ;
                //sMsg = "Doctor record found.";
                sMsg = null;

            }
			catch
			{
				sMsg = "Doctor not in database.";
				txtDoctorID.Text = "";
			}
			finally
			{
                if(sMsg!=null)
				MessageBox.Show (sMsg, "Find Record", MessageBoxButtons.OK);
			}
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			string docID = txtDoctorID.Text ;
			string sMsg = "";

			Doctors oDoctors = new Doctors();

			try
			{
				sMsg = oDoctors.DeleteData(docID);
				LoadDoctorData();
				txtDoctorID.Text = "";
				txtLastName.Text = "";
				txtFirstName.Text = "";
				sMsg = "Doctor record deleted.";

            }
            catch
			{
				sMsg = "Error deleting data." + "\n\n" + e.ToString();
			}
			finally
			{
				MessageBox.Show (sMsg, "Delete Record", MessageBoxButtons.OK);
			}
		
		}

		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			string docID = txtDoctorID.Text ;
			string LName = txtLastName.Text ;
			string FName = txtFirstName.Text;
			string sPec = cboSpecialty.Text;
			string sMsg = "";

			Doctors oDoctors = new Doctors();

			try
			{
				sMsg = oDoctors.UpdateData(docID,LName,FName,sPec);
                LoadDoctorData();

            }
            catch
			{
				sMsg = "Error saving data." + "\n\n" + e.ToString();
			}
			finally
			{
				MessageBox.Show (sMsg, "Update Record", MessageBoxButtons.OK);
			}		
		}

		private void btnQuit_Click(object sender, System.EventArgs e)
		{
			this.Close ();
		}

        private void btn_updatepass_Click(object sender, EventArgs e)
        {
            Users us = new Users();
            var res=us.UpdateDoctorPassWord(txtDoctorID.Text.Trim(), textPassword.Text.Trim());
            if (res)
            {
                MessageBox.Show("success");
            }
            else {
                MessageBox.Show("fail");
            }
        }
    }
}
