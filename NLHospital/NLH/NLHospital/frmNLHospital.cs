using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using NLHBaseWindow;
using NLHospitalLibrary;

namespace NLHospital
{
    /// <summary>
    /// Summary description for frmNLHospital.
    /// </summary>
    /// 
    public class frmNLHospital : NLHBase
    {
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        static int cnt = 0;

        public frmNLHospital()
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(80, 349);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 37);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(368, 349);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 37);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(320, 194);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(200, 28);
            this.txtUserID.TabIndex = 2;
            this.txtUserID.Text = "1";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(320, 258);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 28);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "123456";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(112, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Northern Lights Hospital";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.Location = new System.Drawing.Point(48, 194);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(200, 37);
            this.lblUserID.TabIndex = 5;
            this.lblUserID.Text = "User ID:";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(48, 258);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(200, 38);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(48, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Please log in:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(144, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Patient Admissions";
            // 
            // frmNLHospital
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 21);
            this.ClientSize = new System.Drawing.Size(647, 476);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmNLHospital";
            this.Text = "frmNLHospital";
            this.Load += new System.EventHandler(this.frmNLHospital_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new frmNLHospital());
        }


        private void frmNLHospital_Load(object sender, System.EventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Exit Northern Lights Hospital application?", "",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            string strUser;
            string strPass;
            string sMsg = "";

            strUser = txtUserID.Text;
            strPass = txtPassword.Text;

            Users oUsers = new Users();

            try
            {
                var dt = oUsers.FindData(strUser, strPass);
                if (dt == null){
                    sMsg="login fail";
                    return;
                }
                sMsg = "Welcome " + dt.Rows[0]["UserName"].ToString();

                switch (dt.Rows[0]["UserType"])
                {
                    case "Admissions": 
                    case "Admin":
                    case "Nurse":
                    case "Doctor":
                        frmMenu menuForm = new frmMenu();
                        frmMenu.oCurrent.UserID = strUser;
                        frmMenu.oCurrent.UserType = dt.Rows[0]["UserType"].ToString();
                        frmMenu.oCurrent.Ref= dt.Rows[0]["Ref"].ToString();
                        frmMenu.oCurrent.UserName = dt.Rows[0]["UserName"].ToString();
                        menuForm.Visible = true;
                        menuForm.Activate();
                        menuForm.SelectUser();
                        this.Visible = false;
                        break;
                }

            }

            catch
            {
                if (cnt == 0)
                    sMsg = "User not in database. Please try again.";
                if (cnt == 1)
                    sMsg = "User not in database. One try left.";
                if (cnt == 2)
                    sMsg = "Application is closing. Please contact your supervisor.";
                cnt++;
                txtUserID.Text = "";
                txtPassword.Text = "";
            }
            finally
            {
                MessageBox.Show(sMsg, "", MessageBoxButtons.OK);
                txtUserID.Text = "";
                txtPassword.Text = "";
            }

            if (cnt > 2)
            {
                Application.Exit();
            }
        }
    }
}
