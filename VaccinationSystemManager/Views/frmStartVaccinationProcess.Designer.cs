
namespace VaccinationSystemManager.Views
{
    partial class frmStartVaccinationProcess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartVaccinationProcess));
            this.btnStartVaccinationSave = new System.Windows.Forms.Button();
            this.btnStartVaccinationCancel = new System.Windows.Forms.Button();
            this.lblStartVaccinationDUI = new System.Windows.Forms.Label();
            this.lblStartVaccinationName = new System.Windows.Forms.Label();
            this.lblStartVaccinationAddress = new System.Windows.Forms.Label();
            this.lblStartVaccinationPhone = new System.Windows.Forms.Label();
            this.lblStartVaccinationMail = new System.Windows.Forms.Label();
            this.lblStartVaccinationDisease = new System.Windows.Forms.Label();
            this.lblStartVaccinationDisabilities = new System.Windows.Forms.Label();
            this.lblStartVaccinationIdentifier = new System.Windows.Forms.Label();
            this.lblStartVaccinationDose = new System.Windows.Forms.Label();
            this.lblStartVaccinationDate = new System.Windows.Forms.Label();
            this.lblStartVaccinationStart = new System.Windows.Forms.Label();
            this.lblStartVaccinationVaccine = new System.Windows.Forms.Label();
            this.lblStartVaccinationEnd = new System.Windows.Forms.Label();
            this.dtpStartVaccinationDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartVaccinationVaccine = new System.Windows.Forms.DateTimePicker();
            this.dtpStartVaccinationEnd = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDui = new System.Windows.Forms.Label();
            this.lblCitizenName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.lblIdentifiationNumber = new System.Windows.Forms.Label();
            this.lblVaccinationDate = new System.Windows.Forms.Label();
            this.lblDoseType = new System.Windows.Forms.Label();
            this.cmbDiseasies = new System.Windows.Forms.ComboBox();
            this.cmbDisabilities = new System.Windows.Forms.ComboBox();
            this.lblDiseasies = new System.Windows.Forms.Label();
            this.lblDisabilities = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartVaccinationSave
            // 
            this.btnStartVaccinationSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(140)))));
            this.btnStartVaccinationSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartVaccinationSave.FlatAppearance.BorderSize = 0;
            this.btnStartVaccinationSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartVaccinationSave.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartVaccinationSave.Location = new System.Drawing.Point(434, 859);
            this.btnStartVaccinationSave.Name = "btnStartVaccinationSave";
            this.btnStartVaccinationSave.Size = new System.Drawing.Size(170, 67);
            this.btnStartVaccinationSave.TabIndex = 6;
            this.btnStartVaccinationSave.Text = "Registrar";
            this.btnStartVaccinationSave.UseVisualStyleBackColor = false;
            this.btnStartVaccinationSave.Click += new System.EventHandler(this.btnStarVaccinationSave_Click);
            // 
            // btnStartVaccinationCancel
            // 
            this.btnStartVaccinationCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(140)))));
            this.btnStartVaccinationCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartVaccinationCancel.FlatAppearance.BorderSize = 0;
            this.btnStartVaccinationCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartVaccinationCancel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartVaccinationCancel.Location = new System.Drawing.Point(203, 859);
            this.btnStartVaccinationCancel.Name = "btnStartVaccinationCancel";
            this.btnStartVaccinationCancel.Size = new System.Drawing.Size(176, 67);
            this.btnStartVaccinationCancel.TabIndex = 5;
            this.btnStartVaccinationCancel.Text = "Cancelar";
            this.btnStartVaccinationCancel.UseVisualStyleBackColor = false;
            this.btnStartVaccinationCancel.Click += new System.EventHandler(this.btnVerifyCitizenCancel_Click);
            // 
            // lblStartVaccinationDUI
            // 
            this.lblStartVaccinationDUI.AutoSize = true;
            this.lblStartVaccinationDUI.Location = new System.Drawing.Point(59, 171);
            this.lblStartVaccinationDUI.Name = "lblStartVaccinationDUI";
            this.lblStartVaccinationDUI.Size = new System.Drawing.Size(44, 26);
            this.lblStartVaccinationDUI.TabIndex = 8;
            this.lblStartVaccinationDUI.Text = "DUI";
            // 
            // lblStartVaccinationName
            // 
            this.lblStartVaccinationName.AutoSize = true;
            this.lblStartVaccinationName.Location = new System.Drawing.Point(59, 261);
            this.lblStartVaccinationName.Name = "lblStartVaccinationName";
            this.lblStartVaccinationName.Size = new System.Drawing.Size(173, 26);
            this.lblStartVaccinationName.TabIndex = 9;
            this.lblStartVaccinationName.Text = "Nombre completo";
            // 
            // lblStartVaccinationAddress
            // 
            this.lblStartVaccinationAddress.AutoSize = true;
            this.lblStartVaccinationAddress.Location = new System.Drawing.Point(59, 353);
            this.lblStartVaccinationAddress.Name = "lblStartVaccinationAddress";
            this.lblStartVaccinationAddress.Size = new System.Drawing.Size(96, 26);
            this.lblStartVaccinationAddress.TabIndex = 10;
            this.lblStartVaccinationAddress.Text = "Dirección";
            // 
            // lblStartVaccinationPhone
            // 
            this.lblStartVaccinationPhone.AutoSize = true;
            this.lblStartVaccinationPhone.Location = new System.Drawing.Point(434, 353);
            this.lblStartVaccinationPhone.Name = "lblStartVaccinationPhone";
            this.lblStartVaccinationPhone.Size = new System.Drawing.Size(190, 26);
            this.lblStartVaccinationPhone.TabIndex = 11;
            this.lblStartVaccinationPhone.Text = "Número de teléfono";
            // 
            // lblStartVaccinationMail
            // 
            this.lblStartVaccinationMail.AutoSize = true;
            this.lblStartVaccinationMail.Location = new System.Drawing.Point(59, 448);
            this.lblStartVaccinationMail.Name = "lblStartVaccinationMail";
            this.lblStartVaccinationMail.Size = new System.Drawing.Size(175, 26);
            this.lblStartVaccinationMail.TabIndex = 12;
            this.lblStartVaccinationMail.Text = "Correo electrónico";
            // 
            // lblStartVaccinationDisease
            // 
            this.lblStartVaccinationDisease.AutoSize = true;
            this.lblStartVaccinationDisease.Location = new System.Drawing.Point(59, 536);
            this.lblStartVaccinationDisease.Name = "lblStartVaccinationDisease";
            this.lblStartVaccinationDisease.Size = new System.Drawing.Size(222, 26);
            this.lblStartVaccinationDisease.TabIndex = 13;
            this.lblStartVaccinationDisease.Text = "Enfermedades crónicas";
            // 
            // lblStartVaccinationDisabilities
            // 
            this.lblStartVaccinationDisabilities.AutoSize = true;
            this.lblStartVaccinationDisabilities.Location = new System.Drawing.Point(434, 536);
            this.lblStartVaccinationDisabilities.Name = "lblStartVaccinationDisabilities";
            this.lblStartVaccinationDisabilities.Size = new System.Drawing.Size(153, 26);
            this.lblStartVaccinationDisabilities.TabIndex = 14;
            this.lblStartVaccinationDisabilities.Text = "Discapacidades";
            // 
            // lblStartVaccinationIdentifier
            // 
            this.lblStartVaccinationIdentifier.AutoSize = true;
            this.lblStartVaccinationIdentifier.Location = new System.Drawing.Point(434, 448);
            this.lblStartVaccinationIdentifier.Name = "lblStartVaccinationIdentifier";
            this.lblStartVaccinationIdentifier.Size = new System.Drawing.Size(236, 26);
            this.lblStartVaccinationIdentifier.TabIndex = 15;
            this.lblStartVaccinationIdentifier.Text = "Número de identificación";
            // 
            // lblStartVaccinationDose
            // 
            this.lblStartVaccinationDose.AutoSize = true;
            this.lblStartVaccinationDose.Location = new System.Drawing.Point(59, 643);
            this.lblStartVaccinationDose.Name = "lblStartVaccinationDose";
            this.lblStartVaccinationDose.Size = new System.Drawing.Size(128, 26);
            this.lblStartVaccinationDose.TabIndex = 16;
            this.lblStartVaccinationDose.Text = "Tipo de dosis";
            // 
            // lblStartVaccinationDate
            // 
            this.lblStartVaccinationDate.AutoSize = true;
            this.lblStartVaccinationDate.Location = new System.Drawing.Point(434, 643);
            this.lblStartVaccinationDate.Name = "lblStartVaccinationDate";
            this.lblStartVaccinationDate.Size = new System.Drawing.Size(66, 26);
            this.lblStartVaccinationDate.TabIndex = 17;
            this.lblStartVaccinationDate.Text = "Fecha";
            // 
            // lblStartVaccinationStart
            // 
            this.lblStartVaccinationStart.AutoSize = true;
            this.lblStartVaccinationStart.Location = new System.Drawing.Point(56, 742);
            this.lblStartVaccinationStart.Name = "lblStartVaccinationStart";
            this.lblStartVaccinationStart.Size = new System.Drawing.Size(133, 26);
            this.lblStartVaccinationStart.TabIndex = 18;
            this.lblStartVaccinationStart.Text = "Hora de inicio";
            // 
            // lblStartVaccinationVaccine
            // 
            this.lblStartVaccinationVaccine.AutoSize = true;
            this.lblStartVaccinationVaccine.Location = new System.Drawing.Point(312, 742);
            this.lblStartVaccinationVaccine.Name = "lblStartVaccinationVaccine";
            this.lblStartVaccinationVaccine.Size = new System.Drawing.Size(186, 26);
            this.lblStartVaccinationVaccine.TabIndex = 19;
            this.lblStartVaccinationVaccine.Text = "Hora de vacunación";
            // 
            // lblStartVaccinationEnd
            // 
            this.lblStartVaccinationEnd.AutoSize = true;
            this.lblStartVaccinationEnd.Location = new System.Drawing.Point(551, 742);
            this.lblStartVaccinationEnd.Name = "lblStartVaccinationEnd";
            this.lblStartVaccinationEnd.Size = new System.Drawing.Size(187, 26);
            this.lblStartVaccinationEnd.TabIndex = 20;
            this.lblStartVaccinationEnd.Text = "Hora de finalización";
            // 
            // dtpStartVaccinationDate
            // 
            this.dtpStartVaccinationDate.CustomFormat = "";
            this.dtpStartVaccinationDate.Enabled = false;
            this.dtpStartVaccinationDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartVaccinationDate.Location = new System.Drawing.Point(59, 771);
            this.dtpStartVaccinationDate.Name = "dtpStartVaccinationDate";
            this.dtpStartVaccinationDate.ShowUpDown = true;
            this.dtpStartVaccinationDate.Size = new System.Drawing.Size(200, 31);
            this.dtpStartVaccinationDate.TabIndex = 36;
            // 
            // dtpStartVaccinationVaccine
            // 
            this.dtpStartVaccinationVaccine.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartVaccinationVaccine.Location = new System.Drawing.Point(314, 771);
            this.dtpStartVaccinationVaccine.Name = "dtpStartVaccinationVaccine";
            this.dtpStartVaccinationVaccine.ShowUpDown = true;
            this.dtpStartVaccinationVaccine.Size = new System.Drawing.Size(200, 31);
            this.dtpStartVaccinationVaccine.TabIndex = 37;
            // 
            // dtpStartVaccinationEnd
            // 
            this.dtpStartVaccinationEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartVaccinationEnd.Location = new System.Drawing.Point(554, 771);
            this.dtpStartVaccinationEnd.Name = "dtpStartVaccinationEnd";
            this.dtpStartVaccinationEnd.ShowUpDown = true;
            this.dtpStartVaccinationEnd.Size = new System.Drawing.Size(200, 31);
            this.dtpStartVaccinationEnd.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(720, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(225, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(396, 31);
            this.label9.TabIndex = 41;
            this.label9.Text = "PROCESO DE VACUNACIÓN";
            // 
            // lblDui
            // 
            this.lblDui.AutoSize = true;
            this.lblDui.Location = new System.Drawing.Point(59, 203);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(120, 26);
            this.lblDui.TabIndex = 42;
            this.lblDui.Text = "123456789";
            // 
            // lblCitizenName
            // 
            this.lblCitizenName.AutoSize = true;
            this.lblCitizenName.Location = new System.Drawing.Point(59, 296);
            this.lblCitizenName.Name = "lblCitizenName";
            this.lblCitizenName.Size = new System.Drawing.Size(240, 26);
            this.lblCitizenName.TabIndex = 43;
            this.lblCitizenName.Text = "Juan Antonio Pérez López";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(58, 387);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(247, 26);
            this.lblAddress.TabIndex = 44;
            this.lblAddress.Text = "Búlevar Los Próceres, UCA";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(434, 387);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(108, 26);
            this.lblPhoneNumber.TabIndex = 45;
            this.lblPhoneNumber.Text = "22225555";
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Location = new System.Drawing.Point(61, 482);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(231, 26);
            this.lblEMail.TabIndex = 46;
            this.lblEMail.Text = "juan.antonio@gmail.com";
            // 
            // lblIdentifiationNumber
            // 
            this.lblIdentifiationNumber.AutoSize = true;
            this.lblIdentifiationNumber.Location = new System.Drawing.Point(434, 482);
            this.lblIdentifiationNumber.Name = "lblIdentifiationNumber";
            this.lblIdentifiationNumber.Size = new System.Drawing.Size(120, 26);
            this.lblIdentifiationNumber.TabIndex = 47;
            this.lblIdentifiationNumber.Text = "123456789";
            // 
            // lblVaccinationDate
            // 
            this.lblVaccinationDate.AutoSize = true;
            this.lblVaccinationDate.Location = new System.Drawing.Point(434, 673);
            this.lblVaccinationDate.Name = "lblVaccinationDate";
            this.lblVaccinationDate.Size = new System.Drawing.Size(118, 26);
            this.lblVaccinationDate.TabIndex = 48;
            this.lblVaccinationDate.Text = "24-06-2021";
            // 
            // lblDoseType
            // 
            this.lblDoseType.AutoSize = true;
            this.lblDoseType.Location = new System.Drawing.Point(59, 673);
            this.lblDoseType.Name = "lblDoseType";
            this.lblDoseType.Size = new System.Drawing.Size(139, 26);
            this.lblDoseType.TabIndex = 49;
            this.lblDoseType.Text = "Primera Dosis";
            // 
            // cmbDiseasies
            // 
            this.cmbDiseasies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiseasies.FormattingEnabled = true;
            this.cmbDiseasies.Location = new System.Drawing.Point(61, 569);
            this.cmbDiseasies.Name = "cmbDiseasies";
            this.cmbDiseasies.Size = new System.Drawing.Size(286, 34);
            this.cmbDiseasies.TabIndex = 50;
            this.cmbDiseasies.Visible = false;
            // 
            // cmbDisabilities
            // 
            this.cmbDisabilities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisabilities.FormattingEnabled = true;
            this.cmbDisabilities.Location = new System.Drawing.Point(434, 569);
            this.cmbDisabilities.Name = "cmbDisabilities";
            this.cmbDisabilities.Size = new System.Drawing.Size(286, 34);
            this.cmbDisabilities.TabIndex = 51;
            this.cmbDisabilities.Visible = false;
            // 
            // lblDiseasies
            // 
            this.lblDiseasies.AutoSize = true;
            this.lblDiseasies.Location = new System.Drawing.Point(58, 572);
            this.lblDiseasies.Name = "lblDiseasies";
            this.lblDiseasies.Size = new System.Drawing.Size(311, 26);
            this.lblDiseasies.TabIndex = 52;
            this.lblDiseasies.Text = "No posee enfermedades crónicas";
            this.lblDiseasies.Visible = false;
            // 
            // lblDisabilities
            // 
            this.lblDisabilities.AutoSize = true;
            this.lblDisabilities.Location = new System.Drawing.Point(434, 572);
            this.lblDisabilities.Name = "lblDisabilities";
            this.lblDisabilities.Size = new System.Drawing.Size(239, 26);
            this.lblDisabilities.TabIndex = 53;
            this.lblDisabilities.Text = "No posee discapacidades";
            this.lblDisabilities.Visible = false;
            // 
            // frmStartVaccinationProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(821, 965);
            this.Controls.Add(this.lblDisabilities);
            this.Controls.Add(this.lblDiseasies);
            this.Controls.Add(this.cmbDisabilities);
            this.Controls.Add(this.cmbDiseasies);
            this.Controls.Add(this.lblDoseType);
            this.Controls.Add(this.lblVaccinationDate);
            this.Controls.Add(this.lblIdentifiationNumber);
            this.Controls.Add(this.lblEMail);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCitizenName);
            this.Controls.Add(this.lblDui);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpStartVaccinationEnd);
            this.Controls.Add(this.dtpStartVaccinationVaccine);
            this.Controls.Add(this.dtpStartVaccinationDate);
            this.Controls.Add(this.lblStartVaccinationEnd);
            this.Controls.Add(this.lblStartVaccinationVaccine);
            this.Controls.Add(this.lblStartVaccinationStart);
            this.Controls.Add(this.lblStartVaccinationDate);
            this.Controls.Add(this.lblStartVaccinationDose);
            this.Controls.Add(this.lblStartVaccinationIdentifier);
            this.Controls.Add(this.lblStartVaccinationDisabilities);
            this.Controls.Add(this.lblStartVaccinationDisease);
            this.Controls.Add(this.lblStartVaccinationMail);
            this.Controls.Add(this.lblStartVaccinationPhone);
            this.Controls.Add(this.lblStartVaccinationAddress);
            this.Controls.Add(this.lblStartVaccinationName);
            this.Controls.Add(this.lblStartVaccinationDUI);
            this.Controls.Add(this.btnStartVaccinationSave);
            this.Controls.Add(this.btnStartVaccinationCancel);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmStartVaccinationProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Vaccination Process";
            this.Load += new System.EventHandler(this.frmStartVaccinationProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartVaccinationSave;
        private System.Windows.Forms.Button btnStartVaccinationCancel;
        private System.Windows.Forms.Label lblStartVaccinationDUI;
        private System.Windows.Forms.Label lblStartVaccinationName;
        private System.Windows.Forms.Label lblStartVaccinationAddress;
        private System.Windows.Forms.Label lblStartVaccinationPhone;
        private System.Windows.Forms.Label lblStartVaccinationMail;
        private System.Windows.Forms.Label lblStartVaccinationDisease;
        private System.Windows.Forms.Label lblStartVaccinationDisabilities;
        private System.Windows.Forms.Label lblStartVaccinationIdentifier;
        private System.Windows.Forms.Label lblStartVaccinationDose;
        private System.Windows.Forms.Label lblStartVaccinationDate;
        private System.Windows.Forms.Label lblStartVaccinationStart;
        private System.Windows.Forms.Label lblStartVaccinationVaccine;
        private System.Windows.Forms.Label lblStartVaccinationEnd;
        private System.Windows.Forms.DateTimePicker dtpStartVaccinationDate;
        private System.Windows.Forms.DateTimePicker dtpStartVaccinationVaccine;
        private System.Windows.Forms.DateTimePicker dtpStartVaccinationEnd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDui;
        private System.Windows.Forms.Label lblCitizenName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label lblIdentifiationNumber;
        private System.Windows.Forms.Label lblVaccinationDate;
        private System.Windows.Forms.Label lblDoseType;
        private System.Windows.Forms.ComboBox cmbDiseasies;
        private System.Windows.Forms.ComboBox cmbDisabilities;
        private System.Windows.Forms.Label lblDiseasies;
        private System.Windows.Forms.Label lblDisabilities;
    }
}