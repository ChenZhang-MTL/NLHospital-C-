using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NLHospitalLibrary;
using NLHBaseWindow;
using System.Runtime;
using System.Web.Services.Description;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace NLHospital
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class frmSinglePatient : NLHBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        DataSet m_oDS = new DataSet();
        private Panel panel1;
        private TextBox txtInsuranceCompany;
        private Label label7;
        private TextBox txtPosCode;
        private Label label6;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtProvice;
        private Label label4;
        private TextBox txtCity;
        private Label label2;
        private TextBox txtAddress;
        private TextBox txtFirstName;
        private Label label1;
        private Label label3;
        private Button btnUpdate;
        private Button btnFind;
        private Button btnAdd;
        private Label lblSpecialty;
        private Label lblFName;
        private Label lblLName;
        private Label lblDoctorID;
        private TextBox txtLastName;
        private TextBox txtPatientID;
        private Button btn_Admit;
        private TextBox nextOfKinRship;
        private TextBox nextOfKin;
        private Label label9;
        private TextBox txtInsuranceNumber;
        private Label label8;
        private Panel panel2;
        private RadioButton cNormal;
        private RadioButton cPri;
        private RadioButton cSpri;
        private DateTimePicker dtAdmit;
        private DateTimePicker dtSurgery;
        private CheckBox cSurgery;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label23;
        private Label label24;
        private Panel panel3;
        private DateTimePicker dtDischarge;
        private Button button6;
        private Button btn_Discharge;
        private Button button8;
        private Button button9;
        private Button button10;
        private Label label12;
        private CheckBox cPhone;
        private CheckBox cTV;
        private DateTimePicker dtBirth;
        private ComboBox cb_rooms;
        private ComboBox dropDoctor;
        DataSet m_oSP = new DataSet();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="doctor">医生或者记录者</param>
        public frmSinglePatient(bool doctor)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            if (doctor)
            {
                panel3.Visible = true;
                panel3.Location = panel2.Location;
            }
            else
            {
                panel2.Visible = true;
                btnAdd.Visible = true;
                btnUpdate.Visible = true;
            }
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dropDoctor = new System.Windows.Forms.ComboBox();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.nextOfKinRship = new System.Windows.Forms.TextBox();
            this.nextOfKin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInsuranceNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInsuranceCompany = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPosCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProvice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.btn_Admit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_rooms = new System.Windows.Forms.ComboBox();
            this.cPhone = new System.Windows.Forms.CheckBox();
            this.cTV = new System.Windows.Forms.CheckBox();
            this.cNormal = new System.Windows.Forms.RadioButton();
            this.cPri = new System.Windows.Forms.RadioButton();
            this.cSpri = new System.Windows.Forms.RadioButton();
            this.dtAdmit = new System.Windows.Forms.DateTimePicker();
            this.dtSurgery = new System.Windows.Forms.DateTimePicker();
            this.cSurgery = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtDischarge = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_Discharge = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtBirth);
            this.panel1.Controls.Add(this.nextOfKinRship);
            this.panel1.Controls.Add(this.nextOfKin);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtInsuranceNumber);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtInsuranceCompany);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPosCode);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtProvice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblSpecialty);
            this.panel1.Controls.Add(this.lblFName);
            this.panel1.Controls.Add(this.lblLName);
            this.panel1.Controls.Add(this.lblDoctorID);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtPatientID);
            this.panel1.Location = new System.Drawing.Point(53, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 516);
            this.panel1.TabIndex = 22;
            // 
            // dropDoctor
            // 
            this.dropDoctor.Font = new System.Drawing.Font("宋体", 15F);
            this.dropDoctor.FormattingEnabled = true;
            this.dropDoctor.Location = new System.Drawing.Point(12, 247);
            this.dropDoctor.Name = "dropDoctor";
            this.dropDoctor.Size = new System.Drawing.Size(321, 38);
            this.dropDoctor.TabIndex = 64;
            // 
            // dtBirth
            // 
            this.dtBirth.Location = new System.Drawing.Point(213, 51);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(336, 28);
            this.dtBirth.TabIndex = 63;
            // 
            // nextOfKinRship
            // 
            this.nextOfKinRship.Location = new System.Drawing.Point(213, 469);
            this.nextOfKinRship.MaxLength = 20;
            this.nextOfKinRship.Name = "nextOfKinRship";
            this.nextOfKinRship.Size = new System.Drawing.Size(336, 28);
            this.nextOfKinRship.TabIndex = 52;
            // 
            // nextOfKin
            // 
            this.nextOfKin.Location = new System.Drawing.Point(213, 431);
            this.nextOfKin.MaxLength = 20;
            this.nextOfKin.Name = "nextOfKin";
            this.nextOfKin.Size = new System.Drawing.Size(336, 28);
            this.nextOfKin.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 18);
            this.label9.TabIndex = 49;
            this.label9.Text = "NextOfKinRelationship:";
            // 
            // txtInsuranceNumber
            // 
            this.txtInsuranceNumber.Location = new System.Drawing.Point(213, 393);
            this.txtInsuranceNumber.MaxLength = 20;
            this.txtInsuranceNumber.Name = "txtInsuranceNumber";
            this.txtInsuranceNumber.Size = new System.Drawing.Size(336, 28);
            this.txtInsuranceNumber.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 47;
            this.label8.Text = "NextOfKin:";
            // 
            // txtInsuranceCompany
            // 
            this.txtInsuranceCompany.Location = new System.Drawing.Point(213, 355);
            this.txtInsuranceCompany.MaxLength = 20;
            this.txtInsuranceCompany.Name = "txtInsuranceCompany";
            this.txtInsuranceCompany.Size = new System.Drawing.Size(336, 28);
            this.txtInsuranceCompany.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "Insurance Number:";
            // 
            // txtPosCode
            // 
            this.txtPosCode.Location = new System.Drawing.Point(213, 279);
            this.txtPosCode.MaxLength = 20;
            this.txtPosCode.Name = "txtPosCode";
            this.txtPosCode.Size = new System.Drawing.Size(336, 28);
            this.txtPosCode.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 43;
            this.label6.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(213, 317);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(336, 28);
            this.txtPhone.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 18);
            this.label5.TabIndex = 41;
            this.label5.Text = "Insurance Company:";
            // 
            // txtProvice
            // 
            this.txtProvice.Location = new System.Drawing.Point(213, 241);
            this.txtProvice.MaxLength = 20;
            this.txtProvice.Name = "txtProvice";
            this.txtProvice.Size = new System.Drawing.Size(336, 28);
            this.txtProvice.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Postal Code:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(213, 203);
            this.txtCity.MaxLength = 20;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(336, 28);
            this.txtCity.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "City:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(213, 165);
            this.txtAddress.MaxLength = 20;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(336, 28);
            this.txtAddress.TabIndex = 34;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(213, 127);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(336, 28);
            this.txtFirstName.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Province:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(625, 109);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 37);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(625, 17);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(150, 37);
            this.btnFind.TabIndex = 29;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(625, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 37);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new System.Drawing.Point(10, 92);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(98, 18);
            this.lblSpecialty.TabIndex = 26;
            this.lblSpecialty.Text = "Last Name:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(10, 130);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(107, 18);
            this.lblFName.TabIndex = 25;
            this.lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(10, 54);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(116, 18);
            this.lblLName.TabIndex = 24;
            this.lblLName.Text = "DateOfBirth:";
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Location = new System.Drawing.Point(10, 16);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(134, 18);
            this.lblDoctorID.TabIndex = 23;
            this.lblDoctorID.Text = "Health Number:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(213, 89);
            this.txtLastName.MaxLength = 20;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(336, 28);
            this.txtLastName.TabIndex = 22;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(213, 13);
            this.txtPatientID.MaxLength = 4;
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(336, 28);
            this.txtPatientID.TabIndex = 20;
            // 
            // btn_Admit
            // 
            this.btn_Admit.Location = new System.Drawing.Point(115, 307);
            this.btn_Admit.Name = "btn_Admit";
            this.btn_Admit.Size = new System.Drawing.Size(150, 37);
            this.btn_Admit.TabIndex = 53;
            this.btn_Admit.Text = "Admit";
            this.btn_Admit.Click += new System.EventHandler(this.btn_Admit_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dropDoctor);
            this.panel2.Controls.Add(this.cb_rooms);
            this.panel2.Controls.Add(this.cPhone);
            this.panel2.Controls.Add(this.cTV);
            this.panel2.Controls.Add(this.cNormal);
            this.panel2.Controls.Add(this.cPri);
            this.panel2.Controls.Add(this.cSpri);
            this.panel2.Controls.Add(this.dtAdmit);
            this.panel2.Controls.Add(this.dtSurgery);
            this.panel2.Controls.Add(this.cSurgery);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btn_Admit);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Location = new System.Drawing.Point(850, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 384);
            this.panel2.TabIndex = 53;
            this.panel2.Visible = false;
            // 
            // cb_rooms
            // 
            this.cb_rooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_rooms.Font = new System.Drawing.Font("宋体", 15F);
            this.cb_rooms.FormattingEnabled = true;
            this.cb_rooms.Location = new System.Drawing.Point(13, 116);
            this.cb_rooms.Name = "cb_rooms";
            this.cb_rooms.Size = new System.Drawing.Size(320, 38);
            this.cb_rooms.TabIndex = 59;
            // 
            // cPhone
            // 
            this.cPhone.AutoSize = true;
            this.cPhone.Location = new System.Drawing.Point(116, 183);
            this.cPhone.Name = "cPhone";
            this.cPhone.Size = new System.Drawing.Size(79, 22);
            this.cPhone.TabIndex = 62;
            this.cPhone.Text = "Phone";
            this.cPhone.UseVisualStyleBackColor = true;
            // 
            // cTV
            // 
            this.cTV.AutoSize = true;
            this.cTV.Location = new System.Drawing.Point(13, 184);
            this.cTV.Name = "cTV";
            this.cTV.Size = new System.Drawing.Size(52, 22);
            this.cTV.TabIndex = 61;
            this.cTV.Text = "TV";
            this.cTV.UseVisualStyleBackColor = true;
            // 
            // cNormal
            // 
            this.cNormal.AutoSize = true;
            this.cNormal.Checked = true;
            this.cNormal.Location = new System.Drawing.Point(262, 218);
            this.cNormal.Name = "cNormal";
            this.cNormal.Size = new System.Drawing.Size(87, 22);
            this.cNormal.TabIndex = 60;
            this.cNormal.TabStop = true;
            this.cNormal.Text = "Normal";
            this.cNormal.UseVisualStyleBackColor = true;
            // 
            // cPri
            // 
            this.cPri.AutoSize = true;
            this.cPri.Location = new System.Drawing.Point(13, 219);
            this.cPri.Name = "cPri";
            this.cPri.Size = new System.Drawing.Size(96, 22);
            this.cPri.TabIndex = 59;
            this.cPri.Text = "Private";
            this.cPri.UseVisualStyleBackColor = true;
            // 
            // cSpri
            // 
            this.cSpri.AutoSize = true;
            this.cSpri.Location = new System.Drawing.Point(115, 218);
            this.cSpri.Name = "cSpri";
            this.cSpri.Size = new System.Drawing.Size(141, 22);
            this.cSpri.TabIndex = 58;
            this.cSpri.Text = "Semi-Private";
            this.cSpri.UseVisualStyleBackColor = true;
            // 
            // dtAdmit
            // 
            this.dtAdmit.Location = new System.Drawing.Point(133, 13);
            this.dtAdmit.Name = "dtAdmit";
            this.dtAdmit.Size = new System.Drawing.Size(200, 28);
            this.dtAdmit.TabIndex = 57;
            // 
            // dtSurgery
            // 
            this.dtSurgery.Location = new System.Drawing.Point(132, 81);
            this.dtSurgery.Name = "dtSurgery";
            this.dtSurgery.Size = new System.Drawing.Size(200, 28);
            this.dtSurgery.TabIndex = 56;
            // 
            // cSurgery
            // 
            this.cSurgery.AutoSize = true;
            this.cSurgery.Location = new System.Drawing.Point(13, 50);
            this.cSurgery.Name = "cSurgery";
            this.cSurgery.Size = new System.Drawing.Size(97, 22);
            this.cSurgery.TabIndex = 55;
            this.cSurgery.Text = "Surgery";
            this.cSurgery.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 37);
            this.button2.TabIndex = 31;
            this.button2.Text = "Delete";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(624, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 37);
            this.button3.TabIndex = 30;
            this.button3.Text = "Update";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(624, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 37);
            this.button4.TabIndex = 29;
            this.button4.Text = "Find";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(624, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 37);
            this.button5.TabIndex = 28;
            this.button5.Text = "Add";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 83);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(116, 18);
            this.label23.TabIndex = 24;
            this.label23.Text = "SurgeryDate:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 16);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(98, 18);
            this.label24.TabIndex = 23;
            this.label24.Text = "AdmitDate:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dtDischarge);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.btn_Discharge);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(865, 430);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 108);
            this.panel3.TabIndex = 58;
            this.panel3.Visible = false;
            // 
            // dtDischarge
            // 
            this.dtDischarge.Location = new System.Drawing.Point(133, 13);
            this.dtDischarge.Name = "dtDischarge";
            this.dtDischarge.Size = new System.Drawing.Size(200, 28);
            this.dtDischarge.TabIndex = 57;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(624, 168);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 37);
            this.button6.TabIndex = 31;
            this.button6.Text = "Delete";
            // 
            // btn_Discharge
            // 
            this.btn_Discharge.Location = new System.Drawing.Point(89, 48);
            this.btn_Discharge.Name = "btn_Discharge";
            this.btn_Discharge.Size = new System.Drawing.Size(150, 37);
            this.btn_Discharge.TabIndex = 53;
            this.btn_Discharge.Text = "Discharge";
            this.btn_Discharge.Click += new System.EventHandler(this.btn_Discharge_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(624, 116);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(150, 37);
            this.button8.TabIndex = 30;
            this.button8.Text = "Update";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(624, 65);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(150, 37);
            this.button9.TabIndex = 29;
            this.button9.Text = "Find";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(624, 13);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(150, 37);
            this.button10.TabIndex = 28;
            this.button10.Text = "Add";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 18);
            this.label12.TabIndex = 23;
            this.label12.Text = "Date:";
            // 
            // frmSinglePatient
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 21);
            this.ClientSize = new System.Drawing.Size(1311, 692);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmSinglePatient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.frmDoctors_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion


        private void frmDoctors_Load(object sender, System.EventArgs e)
        {
            LoadPatientData();
            LoadWardRoomData();
            LoadDoctors();
        }
        /// <summary>
        /// 加载下拉框选择的房间
        /// </summary>
        private void LoadWardRoomData()
        {
            Beds beds = new Beds();
            HashSet<string> names = new HashSet<string>();
            var tab = beds.GetData();
            foreach (DataRow row in tab.Rows)
            {
                if (Convert.ToBoolean(row["Occupied"]))
                    continue;
                if (!names.Contains(row["WardName"].ToString()))
                {
                    names.Add(row["WardName"].ToString());
                }
            }
            var ds = names.ToList();
            //添加测试房间 什么床也没有
            ds.Add("TestEmpty");
            cb_rooms.DataSource =ds;
        }
        private void LoadPatientData()
        {
        }
        private void LoadDoctors() {
            Doctors d = new Doctors();
            List<Doctor1> dts = new List<Doctor1>();
            foreach (DataRow item in d.GetData().Tables["Doctors"].Rows)
            {
                dts.Add(new Doctor1 { 
                     ID= item["DoctorID"].ToString(),
                     LName= item["LastName"].ToString(),
                     FName= item["FirstName"].ToString(),
                });
            }
            dropDoctor.DataSource = dts;
        }
        private void btnDelete_Click111(object sender, System.EventArgs e)
        {
            string docID = txtPatientID.Text;
            string sMsg = "";

            Doctors oDoctors = new Doctors();

            try
            {
                sMsg = oDoctors.DeleteData(docID);
                LoadPatientData();
                sMsg = "Doctor record deleted.";

            }
            catch
            {
                sMsg = "Error deleting data." + "\n\n" + e.ToString();
            }
            finally
            {
                MessageBox.Show(sMsg, "Delete Record", MessageBoxButtons.OK);
            }

        }

        private void btnQuit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }


        private void btn_Discharge_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatientID.Text))
            {
                MessageBox.Show("please input patient healthid");
                return;
            }
            try
            {
                Admissions adm = new Admissions();
                Beds bds = new Beds();
                using (var cnn = Settings.InitializeConnection())
                {
                    var trans = cnn.BeginTransaction();
                    var adrow = adm.FindLatest(txtPatientID.Text);
                    if (adrow == null)
                    {
                        MessageBox.Show("The patient has no record");
                        return;
                    }
                    var bdnum = adrow["BedNumber"] as string;
                    var ok1 = adm.SetPatientDischarge(adrow["AdmissionID"].ToString(), dtDischarge.Value, cnn,trans);
                    ///解除床铺占用
                    var ok2 = bds.SetOccupy(bdnum, false, cnn,trans);
                    if (ok1 && ok2)
                    {
                        trans.Commit();
                        MessageBox.Show("success");
                    }
                    else
                    {
                        trans.Rollback();
                        MessageBox.Show("no this patient or patient is not in hospatal");
                    }
                    LoadWardRoomData();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("fail");
            }

        }

        private void btn_Admit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatientID.Text))
            {
                MessageBox.Show("please input patient healthid");
                return;
            }
            try
            {
                Beds bd = new Beds();
                Admissions adm = new Admissions();
                Patients pt = new Patients();
                Extras exts = new Extras();
                var adrow = adm.FindLatest(txtPatientID.Text);
                if (adrow != null)
                {
                    MessageBox.Show("The patient is in hospital now");
                    return;
                }
                DataRow ptrow = pt.FindData(txtPatientID.Text);
                if (ptrow == null)
                {
                    MessageBox.Show("no this patient");
                    return;
                }
                //有保险
                var hasInsurance = ptrow["InsuranceCompany"] != DBNull.Value && ptrow["InsuranceNumber"] != DBNull.Value;
                var age = (DateTime.Now - Convert.ToDateTime(ptrow["DateOfBirth"])).Days / 365;
                var pid = txtPatientID.Text;
                var doctor=(dropDoctor.SelectedItem as Doctor1).ID;
                //尝试获取一个可入住的房间
                var er = bd.TryEnter(cb_rooms.SelectedValue as string, cSurgery.Checked, hasInsurance, age, cPri.Checked ? 2 : cSpri.Checked ? 1 : 0);
                if ((int)er[0] == -2)
                {
                    MessageBox.Show("try other ward and bed type");
                    return;
                }
                if ((int)er[0] == -1)
                {
                    MessageBox.Show("The ward is full");
                    return;
                }
                //免费更好的病房
                if ((int)er[0] % 2 == 0)
                {
                    var sel = MessageBox.Show("Free admission to a better ward?", "tip", MessageBoxButtons.OKCancel);
                    if (sel != DialogResult.OK)
                    {
                        return;
                    }
                }

                using (var cnn = Settings.InitializeConnection())
                {
                    var trans = cnn.BeginTransaction();
                    var aid = "" + (adm.GetData().Tables["AdmissionRecords"].Rows.Count + 1);
                    var bedupdate = bd.SetOccupy(er[2] as string, true, cnn,trans);
                    if (!bedupdate)
                    {
                        MessageBox.Show("try again");
                        return;
                    }
                    var admaddres = adm.Add(aid, pid, er[2] as string, cSurgery.Checked, dtSurgery.Value, dtAdmit.Value, null, doctor, cnn,trans);
                    if (!admaddres)
                    {
                        MessageBox.Show("try again");
                        return;
                    }
                    var extaddres = exts.AddData(aid, txtPatientID.Text, cTV.Checked, cPhone.Checked, cSpri.Checked,cPri.Checked, cnn, trans);
                    if (!extaddres)
                    {
                        MessageBox.Show("try again");
                        return;
                    }
                    trans.Commit();

                    if ((int)er[0] == 1 || (int)er[0] == 2)
                    {
                        MessageBox.Show("Automatic admission to the surgery room");

                    }
                    else if ((int)er[0] == 3 || (int)er[0] == 4)
                    {
                        MessageBox.Show("Automatic admission to the pediatrics room");

                    }
                    else
                    {
                        MessageBox.Show("success");
                    }
                    LoadWardRoomData();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("fail" + ex.Message);
            }


        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                Patients patients = new Patients();
                var msg = patients.UpdateData(txtLastName.Text, txtFirstName.Text, txtPatientID.Text, dtBirth.Value,
                    txtAddress.Text, txtCity.Text, txtProvice.Text, txtPosCode.Text, txtPhone.Text,
                    txtInsuranceCompany.Text, txtInsuranceNumber.Text, nextOfKin.Text, nextOfKinRship.Text, "nouse");
                MessageBox.Show(msg);
                LoadPatientData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed " + ex.Message);
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Patients patients = new Patients();
                var msg = patients.AddData(txtLastName.Text, txtFirstName.Text, txtPatientID.Text, dtBirth.Value,
                    txtAddress.Text, txtCity.Text, txtProvice.Text, txtPosCode.Text, txtPhone.Text,
                    txtInsuranceCompany.Text, txtInsuranceNumber.Text, nextOfKin.Text, nextOfKinRship.Text, "nouse");

                MessageBox.Show(msg);
                LoadPatientData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed " + ex.Message);
                return;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            try
            {
                Patients patients = new Patients();
                var row = patients.FindData(txtPatientID.Text);
                if (row == null)
                {
                    MessageBox.Show("no record.");
                    return;
                }
                txtLastName.Text = row["LastName"].ToString();
                txtFirstName.Text = row["FirstName"].ToString();
                txtPatientID.Text = row["HealthNumber"].ToString();
                txtAddress.Text = row["Address"].ToString();
                txtCity.Text = row["City"].ToString();
                txtProvice.Text = row["Province"].ToString();
                txtPosCode.Text = row["PostalCode"].ToString();
                txtPhone.Text = row["Phone"].ToString();
                txtInsuranceCompany.Text = row["InsuranceCompany"].ToString();
                txtInsuranceNumber.Text = row["InsuranceNumber"].ToString();
                nextOfKin.Text = row["NextOfKin"].ToString();
                nextOfKinRship.Text = row["NextOfKinRelationship"].ToString(); 
                dtBirth.Value= Convert.ToDateTime( row["DateOfBirth"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting data." + "\n\n" + ex.ToString());
            }

        }
    }
}

class Doctor1 {
    public string ID;
    public string FName;
    public string LName;


    public override string ToString()
    {
        return ID+":" + FName+" "+LName; 
    }

}