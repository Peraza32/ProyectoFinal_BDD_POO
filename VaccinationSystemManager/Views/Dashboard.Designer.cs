
namespace VaccinationSystemManager.Views
{
    partial class Dashboard
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
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnVacProcess = new System.Windows.Forms.Button();
            this.btnShowAppointments = new System.Windows.Forms.Button();
            this.lblCurrenEmployee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAppointment
            // 
            this.btnAppointment.Location = new System.Drawing.Point(268, 189);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(260, 119);
            this.btnAppointment.TabIndex = 0;
            this.btnAppointment.Text = "Agendar Cita";
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(268, 460);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(260, 119);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Cerrar sesión";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnVacProcess
            // 
            this.btnVacProcess.Location = new System.Drawing.Point(268, 323);
            this.btnVacProcess.Name = "btnVacProcess";
            this.btnVacProcess.Size = new System.Drawing.Size(260, 119);
            this.btnVacProcess.TabIndex = 2;
            this.btnVacProcess.Text = "Proceso de vacunación";
            this.btnVacProcess.UseVisualStyleBackColor = true;
            // 
            // btnShowAppointments
            // 
            this.btnShowAppointments.Location = new System.Drawing.Point(268, 55);
            this.btnShowAppointments.Name = "btnShowAppointments";
            this.btnShowAppointments.Size = new System.Drawing.Size(260, 119);
            this.btnShowAppointments.TabIndex = 3;
            this.btnShowAppointments.Text = "Ver Citas";
            this.btnShowAppointments.UseVisualStyleBackColor = true;
            // 
            // lblCurrenEmployee
            // 
            this.lblCurrenEmployee.AutoSize = true;
            this.lblCurrenEmployee.Location = new System.Drawing.Point(51, 279);
            this.lblCurrenEmployee.Name = "lblCurrenEmployee";
            this.lblCurrenEmployee.Size = new System.Drawing.Size(50, 20);
            this.lblCurrenEmployee.TabIndex = 4;
            this.lblCurrenEmployee.Text = "label1";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 672);
            this.Controls.Add(this.lblCurrenEmployee);
            this.Controls.Add(this.btnShowAppointments);
            this.Controls.Add(this.btnVacProcess);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnAppointment);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnVacProcess;
        private System.Windows.Forms.Button btnShowAppointments;
        private System.Windows.Forms.Label lblCurrenEmployee;
    }
}