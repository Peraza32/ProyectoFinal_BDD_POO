
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
            this.btnStartVaccinationSave = new System.Windows.Forms.Button();
            this.btnStartVaccinationCancel = new System.Windows.Forms.Button();
            this.lblStartVaccinationTitle = new System.Windows.Forms.Label();
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
            this.txtStartVaccinationDUI = new System.Windows.Forms.TextBox();
            this.txtStartVaccinationName = new System.Windows.Forms.TextBox();
            this.txtStartVaccinationAddress = new System.Windows.Forms.TextBox();
            this.txtStartVaccinationPhone = new System.Windows.Forms.TextBox();
            this.txtStartVaccinationMail = new System.Windows.Forms.TextBox();
            this.txtStartVaccinationDisease = new System.Windows.Forms.TextBox();
            this.txtStartVaccinationDisability = new System.Windows.Forms.TextBox();
            this.txtStartVaccinationIdentifier = new System.Windows.Forms.TextBox();
            this.dtpStartVaccinationDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartVaccinationStart = new System.Windows.Forms.DateTimePicker();
            this.dtpStartVaccinationVaccine = new System.Windows.Forms.DateTimePicker();
            this.dtpStartVaccinationEnd = new System.Windows.Forms.DateTimePicker();
            this.txtStartVaccinationDose = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStartVaccinationSave
            // 
            this.btnStartVaccinationSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(140)))));
            this.btnStartVaccinationSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartVaccinationSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartVaccinationSave.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartVaccinationSave.Location = new System.Drawing.Point(432, 818);
            this.btnStartVaccinationSave.Name = "btnStartVaccinationSave";
            this.btnStartVaccinationSave.Size = new System.Drawing.Size(170, 57);
            this.btnStartVaccinationSave.TabIndex = 6;
            this.btnStartVaccinationSave.Text = "Registrar";
            this.btnStartVaccinationSave.UseVisualStyleBackColor = false;
            this.btnStartVaccinationSave.Click += new System.EventHandler(this.btnVerifyCitizenSearch_Click);
            // 
            // btnStartVaccinationCancel
            // 
            this.btnStartVaccinationCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(140)))));
            this.btnStartVaccinationCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartVaccinationCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartVaccinationCancel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartVaccinationCancel.Location = new System.Drawing.Point(185, 818);
            this.btnStartVaccinationCancel.Name = "btnStartVaccinationCancel";
            this.btnStartVaccinationCancel.Size = new System.Drawing.Size(170, 57);
            this.btnStartVaccinationCancel.TabIndex = 5;
            this.btnStartVaccinationCancel.Text = "Cancelar";
            this.btnStartVaccinationCancel.UseVisualStyleBackColor = false;
            this.btnStartVaccinationCancel.Click += new System.EventHandler(this.btnVerifyCitizenCancel_Click);
            // 
            // lblStartVaccinationTitle
            // 
            this.lblStartVaccinationTitle.AutoSize = true;
            this.lblStartVaccinationTitle.Location = new System.Drawing.Point(318, 9);
            this.lblStartVaccinationTitle.Name = "lblStartVaccinationTitle";
            this.lblStartVaccinationTitle.Size = new System.Drawing.Size(163, 26);
            this.lblStartVaccinationTitle.TabIndex = 7;
            this.lblStartVaccinationTitle.Text = "Registrar vacuna";
            // 
            // lblStartVaccinationDUI
            // 
            this.lblStartVaccinationDUI.AutoSize = true;
            this.lblStartVaccinationDUI.Location = new System.Drawing.Point(57, 84);
            this.lblStartVaccinationDUI.Name = "lblStartVaccinationDUI";
            this.lblStartVaccinationDUI.Size = new System.Drawing.Size(44, 26);
            this.lblStartVaccinationDUI.TabIndex = 8;
            this.lblStartVaccinationDUI.Text = "DUI";
            // 
            // lblStartVaccinationName
            // 
            this.lblStartVaccinationName.AutoSize = true;
            this.lblStartVaccinationName.Location = new System.Drawing.Point(57, 174);
            this.lblStartVaccinationName.Name = "lblStartVaccinationName";
            this.lblStartVaccinationName.Size = new System.Drawing.Size(173, 26);
            this.lblStartVaccinationName.TabIndex = 9;
            this.lblStartVaccinationName.Text = "Nombre completo";
            // 
            // lblStartVaccinationAddress
            // 
            this.lblStartVaccinationAddress.AutoSize = true;
            this.lblStartVaccinationAddress.Location = new System.Drawing.Point(57, 266);
            this.lblStartVaccinationAddress.Name = "lblStartVaccinationAddress";
            this.lblStartVaccinationAddress.Size = new System.Drawing.Size(96, 26);
            this.lblStartVaccinationAddress.TabIndex = 10;
            this.lblStartVaccinationAddress.Text = "Dirección";
            // 
            // lblStartVaccinationPhone
            // 
            this.lblStartVaccinationPhone.AutoSize = true;
            this.lblStartVaccinationPhone.Location = new System.Drawing.Point(432, 266);
            this.lblStartVaccinationPhone.Name = "lblStartVaccinationPhone";
            this.lblStartVaccinationPhone.Size = new System.Drawing.Size(190, 26);
            this.lblStartVaccinationPhone.TabIndex = 11;
            this.lblStartVaccinationPhone.Text = "Número de teléfono";
            // 
            // lblStartVaccinationMail
            // 
            this.lblStartVaccinationMail.AutoSize = true;
            this.lblStartVaccinationMail.Location = new System.Drawing.Point(57, 365);
            this.lblStartVaccinationMail.Name = "lblStartVaccinationMail";
            this.lblStartVaccinationMail.Size = new System.Drawing.Size(175, 26);
            this.lblStartVaccinationMail.TabIndex = 12;
            this.lblStartVaccinationMail.Text = "Correo electrónico";
            // 
            // lblStartVaccinationDisease
            // 
            this.lblStartVaccinationDisease.AutoSize = true;
            this.lblStartVaccinationDisease.Location = new System.Drawing.Point(57, 453);
            this.lblStartVaccinationDisease.Name = "lblStartVaccinationDisease";
            this.lblStartVaccinationDisease.Size = new System.Drawing.Size(222, 26);
            this.lblStartVaccinationDisease.TabIndex = 13;
            this.lblStartVaccinationDisease.Text = "Enfermedades crónicas";
            // 
            // lblStartVaccinationDisabilities
            // 
            this.lblStartVaccinationDisabilities.AutoSize = true;
            this.lblStartVaccinationDisabilities.Location = new System.Drawing.Point(432, 453);
            this.lblStartVaccinationDisabilities.Name = "lblStartVaccinationDisabilities";
            this.lblStartVaccinationDisabilities.Size = new System.Drawing.Size(153, 26);
            this.lblStartVaccinationDisabilities.TabIndex = 14;
            this.lblStartVaccinationDisabilities.Text = "Discapacidades";
            // 
            // lblStartVaccinationIdentifier
            // 
            this.lblStartVaccinationIdentifier.AutoSize = true;
            this.lblStartVaccinationIdentifier.Location = new System.Drawing.Point(432, 365);
            this.lblStartVaccinationIdentifier.Name = "lblStartVaccinationIdentifier";
            this.lblStartVaccinationIdentifier.Size = new System.Drawing.Size(236, 26);
            this.lblStartVaccinationIdentifier.TabIndex = 15;
            this.lblStartVaccinationIdentifier.Text = "Número de identificación";
            // 
            // lblStartVaccinationDose
            // 
            this.lblStartVaccinationDose.AutoSize = true;
            this.lblStartVaccinationDose.Location = new System.Drawing.Point(57, 560);
            this.lblStartVaccinationDose.Name = "lblStartVaccinationDose";
            this.lblStartVaccinationDose.Size = new System.Drawing.Size(128, 26);
            this.lblStartVaccinationDose.TabIndex = 16;
            this.lblStartVaccinationDose.Text = "Tipo de dosis";
            // 
            // lblStartVaccinationDate
            // 
            this.lblStartVaccinationDate.AutoSize = true;
            this.lblStartVaccinationDate.Location = new System.Drawing.Point(432, 560);
            this.lblStartVaccinationDate.Name = "lblStartVaccinationDate";
            this.lblStartVaccinationDate.Size = new System.Drawing.Size(66, 26);
            this.lblStartVaccinationDate.TabIndex = 17;
            this.lblStartVaccinationDate.Text = "Fecha";
            // 
            // lblStartVaccinationStart
            // 
            this.lblStartVaccinationStart.AutoSize = true;
            this.lblStartVaccinationStart.Location = new System.Drawing.Point(57, 672);
            this.lblStartVaccinationStart.Name = "lblStartVaccinationStart";
            this.lblStartVaccinationStart.Size = new System.Drawing.Size(133, 26);
            this.lblStartVaccinationStart.TabIndex = 18;
            this.lblStartVaccinationStart.Text = "Hora de inicio";
            // 
            // lblStartVaccinationVaccine
            // 
            this.lblStartVaccinationVaccine.AutoSize = true;
            this.lblStartVaccinationVaccine.Location = new System.Drawing.Point(312, 672);
            this.lblStartVaccinationVaccine.Name = "lblStartVaccinationVaccine";
            this.lblStartVaccinationVaccine.Size = new System.Drawing.Size(186, 26);
            this.lblStartVaccinationVaccine.TabIndex = 19;
            this.lblStartVaccinationVaccine.Text = "Hora de vacunación";
            // 
            // lblStartVaccinationEnd
            // 
            this.lblStartVaccinationEnd.AutoSize = true;
            this.lblStartVaccinationEnd.Location = new System.Drawing.Point(565, 672);
            this.lblStartVaccinationEnd.Name = "lblStartVaccinationEnd";
            this.lblStartVaccinationEnd.Size = new System.Drawing.Size(187, 26);
            this.lblStartVaccinationEnd.TabIndex = 20;
            this.lblStartVaccinationEnd.Text = "Hora de finalización";
            // 
            // txtStartVaccinationDUI
            // 
            this.txtStartVaccinationDUI.Enabled = false;
            this.txtStartVaccinationDUI.Location = new System.Drawing.Point(57, 113);
            this.txtStartVaccinationDUI.Name = "txtStartVaccinationDUI";
            this.txtStartVaccinationDUI.Size = new System.Drawing.Size(397, 31);
            this.txtStartVaccinationDUI.TabIndex = 21;
            // 
            // txtStartVaccinationName
            // 
            this.txtStartVaccinationName.Enabled = false;
            this.txtStartVaccinationName.Location = new System.Drawing.Point(57, 203);
            this.txtStartVaccinationName.Name = "txtStartVaccinationName";
            this.txtStartVaccinationName.Size = new System.Drawing.Size(397, 31);
            this.txtStartVaccinationName.TabIndex = 22;
            // 
            // txtStartVaccinationAddress
            // 
            this.txtStartVaccinationAddress.Enabled = false;
            this.txtStartVaccinationAddress.Location = new System.Drawing.Point(57, 295);
            this.txtStartVaccinationAddress.Name = "txtStartVaccinationAddress";
            this.txtStartVaccinationAddress.Size = new System.Drawing.Size(320, 31);
            this.txtStartVaccinationAddress.TabIndex = 23;
            // 
            // txtStartVaccinationPhone
            // 
            this.txtStartVaccinationPhone.Enabled = false;
            this.txtStartVaccinationPhone.Location = new System.Drawing.Point(432, 295);
            this.txtStartVaccinationPhone.Name = "txtStartVaccinationPhone";
            this.txtStartVaccinationPhone.Size = new System.Drawing.Size(320, 31);
            this.txtStartVaccinationPhone.TabIndex = 24;
            // 
            // txtStartVaccinationMail
            // 
            this.txtStartVaccinationMail.Enabled = false;
            this.txtStartVaccinationMail.Location = new System.Drawing.Point(57, 394);
            this.txtStartVaccinationMail.Name = "txtStartVaccinationMail";
            this.txtStartVaccinationMail.Size = new System.Drawing.Size(320, 31);
            this.txtStartVaccinationMail.TabIndex = 25;
            // 
            // txtStartVaccinationDisease
            // 
            this.txtStartVaccinationDisease.Enabled = false;
            this.txtStartVaccinationDisease.Location = new System.Drawing.Point(57, 494);
            this.txtStartVaccinationDisease.Name = "txtStartVaccinationDisease";
            this.txtStartVaccinationDisease.Size = new System.Drawing.Size(320, 31);
            this.txtStartVaccinationDisease.TabIndex = 26;
            // 
            // txtStartVaccinationDisability
            // 
            this.txtStartVaccinationDisability.Enabled = false;
            this.txtStartVaccinationDisability.Location = new System.Drawing.Point(432, 494);
            this.txtStartVaccinationDisability.Name = "txtStartVaccinationDisability";
            this.txtStartVaccinationDisability.Size = new System.Drawing.Size(320, 31);
            this.txtStartVaccinationDisability.TabIndex = 27;
            // 
            // txtStartVaccinationIdentifier
            // 
            this.txtStartVaccinationIdentifier.Enabled = false;
            this.txtStartVaccinationIdentifier.Location = new System.Drawing.Point(432, 394);
            this.txtStartVaccinationIdentifier.Name = "txtStartVaccinationIdentifier";
            this.txtStartVaccinationIdentifier.Size = new System.Drawing.Size(320, 31);
            this.txtStartVaccinationIdentifier.TabIndex = 28;
            // 
            // dtpStartVaccinationDate
            // 
            this.dtpStartVaccinationDate.Enabled = false;
            this.dtpStartVaccinationDate.Location = new System.Drawing.Point(432, 592);
            this.dtpStartVaccinationDate.Name = "dtpStartVaccinationDate";
            this.dtpStartVaccinationDate.Size = new System.Drawing.Size(320, 31);
            this.dtpStartVaccinationDate.TabIndex = 35;
            // 
            // dtpStartVaccinationStart
            // 
            this.dtpStartVaccinationStart.CustomFormat = "";
            this.dtpStartVaccinationStart.Enabled = false;
            this.dtpStartVaccinationStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartVaccinationStart.Location = new System.Drawing.Point(57, 701);
            this.dtpStartVaccinationStart.Name = "dtpStartVaccinationStart";
            this.dtpStartVaccinationStart.Size = new System.Drawing.Size(200, 31);
            this.dtpStartVaccinationStart.TabIndex = 36;
            // 
            // dtpStartVaccinationVaccine
            // 
            this.dtpStartVaccinationVaccine.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartVaccinationVaccine.Location = new System.Drawing.Point(312, 701);
            this.dtpStartVaccinationVaccine.Name = "dtpStartVaccinationVaccine";
            this.dtpStartVaccinationVaccine.Size = new System.Drawing.Size(200, 31);
            this.dtpStartVaccinationVaccine.TabIndex = 37;
            // 
            // dtpStartVaccinationEnd
            // 
            this.dtpStartVaccinationEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartVaccinationEnd.Location = new System.Drawing.Point(552, 701);
            this.dtpStartVaccinationEnd.Name = "dtpStartVaccinationEnd";
            this.dtpStartVaccinationEnd.Size = new System.Drawing.Size(200, 31);
            this.dtpStartVaccinationEnd.TabIndex = 38;
            // 
            // txtStartVaccinationDose
            // 
            this.txtStartVaccinationDose.Enabled = false;
            this.txtStartVaccinationDose.Location = new System.Drawing.Point(57, 590);
            this.txtStartVaccinationDose.Name = "txtStartVaccinationDose";
            this.txtStartVaccinationDose.Size = new System.Drawing.Size(320, 31);
            this.txtStartVaccinationDose.TabIndex = 39;
            // 
            // frmStartVaccinationProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(796, 896);
            this.Controls.Add(this.txtStartVaccinationDose);
            this.Controls.Add(this.dtpStartVaccinationEnd);
            this.Controls.Add(this.dtpStartVaccinationVaccine);
            this.Controls.Add(this.dtpStartVaccinationStart);
            this.Controls.Add(this.dtpStartVaccinationDate);
            this.Controls.Add(this.txtStartVaccinationIdentifier);
            this.Controls.Add(this.txtStartVaccinationDisability);
            this.Controls.Add(this.txtStartVaccinationDisease);
            this.Controls.Add(this.txtStartVaccinationMail);
            this.Controls.Add(this.txtStartVaccinationPhone);
            this.Controls.Add(this.txtStartVaccinationAddress);
            this.Controls.Add(this.txtStartVaccinationName);
            this.Controls.Add(this.txtStartVaccinationDUI);
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
            this.Controls.Add(this.lblStartVaccinationTitle);
            this.Controls.Add(this.btnStartVaccinationSave);
            this.Controls.Add(this.btnStartVaccinationCancel);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmStartVaccinationProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Vaccination Process";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartVaccinationSave;
        private System.Windows.Forms.Button btnStartVaccinationCancel;
        private System.Windows.Forms.Label lblStartVaccinationTitle;
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
        private System.Windows.Forms.TextBox txtStartVaccinationDUI;
        private System.Windows.Forms.TextBox txtStartVaccinationName;
        private System.Windows.Forms.TextBox txtStartVaccinationAddress;
        private System.Windows.Forms.TextBox txtStartVaccinationPhone;
        private System.Windows.Forms.TextBox txtStartVaccinationMail;
        private System.Windows.Forms.TextBox txtStartVaccinationDisease;
        private System.Windows.Forms.TextBox txtStartVaccinationDisability;
        private System.Windows.Forms.TextBox txtStartVaccinationIdentifier;
        private System.Windows.Forms.DateTimePicker dtpStartVaccinationDate;
        private System.Windows.Forms.DateTimePicker dtpStartVaccinationStart;
        private System.Windows.Forms.DateTimePicker dtpStartVaccinationVaccine;
        private System.Windows.Forms.DateTimePicker dtpStartVaccinationEnd;
        private System.Windows.Forms.TextBox txtStartVaccinationDose;
    }
}