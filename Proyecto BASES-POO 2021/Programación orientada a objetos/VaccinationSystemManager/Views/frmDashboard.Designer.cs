
namespace VaccinationSystemManager.Views
{
    partial class frmDashboard
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
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnVacProcess = new System.Windows.Forms.Button();
            this.btnShowAppointments = new System.Windows.Forms.Button();
            this.lblCurrenEmployee = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblCabin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAppointment
            // 
            this.btnAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(51)))));
            this.btnAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppointment.FlatAppearance.BorderSize = 0;
            this.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointment.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAppointment.Location = new System.Drawing.Point(39, 152);
            this.btnAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(260, 175);
            this.btnAppointment.TabIndex = 0;
            this.btnAppointment.Text = "Agendar Cita";
            this.btnAppointment.UseVisualStyleBackColor = false;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(140)))));
            this.btnStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistic.FlatAppearance.BorderSize = 0;
            this.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistic.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStatistic.ForeColor = System.Drawing.Color.White;
            this.btnStatistic.Location = new System.Drawing.Point(332, 358);
            this.btnStatistic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(260, 175);
            this.btnStatistic.TabIndex = 1;
            this.btnStatistic.Text = "Estadísticas";
            this.btnStatistic.UseVisualStyleBackColor = false;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnVacProcess
            // 
            this.btnVacProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(93)))), ((int)(((byte)(240)))));
            this.btnVacProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVacProcess.FlatAppearance.BorderSize = 0;
            this.btnVacProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVacProcess.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVacProcess.ForeColor = System.Drawing.Color.White;
            this.btnVacProcess.Location = new System.Drawing.Point(39, 358);
            this.btnVacProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVacProcess.Name = "btnVacProcess";
            this.btnVacProcess.Size = new System.Drawing.Size(260, 175);
            this.btnVacProcess.TabIndex = 2;
            this.btnVacProcess.Text = "Proceso de vacunación";
            this.btnVacProcess.UseVisualStyleBackColor = false;
            this.btnVacProcess.Click += new System.EventHandler(this.btnVacProcess_Click);
            // 
            // btnShowAppointments
            // 
            this.btnShowAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(133)))), ((int)(((byte)(154)))));
            this.btnShowAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAppointments.FlatAppearance.BorderSize = 0;
            this.btnShowAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAppointments.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowAppointments.ForeColor = System.Drawing.Color.White;
            this.btnShowAppointments.Location = new System.Drawing.Point(332, 152);
            this.btnShowAppointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowAppointments.Name = "btnShowAppointments";
            this.btnShowAppointments.Size = new System.Drawing.Size(260, 175);
            this.btnShowAppointments.TabIndex = 3;
            this.btnShowAppointments.Text = "Ver Citas";
            this.btnShowAppointments.UseVisualStyleBackColor = false;
            this.btnShowAppointments.Click += new System.EventHandler(this.btnShowAppointments_Click);
            // 
            // lblCurrenEmployee
            // 
            this.lblCurrenEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCurrenEmployee.AutoSize = true;
            this.lblCurrenEmployee.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrenEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.lblCurrenEmployee.Location = new System.Drawing.Point(156, 24);
            this.lblCurrenEmployee.Name = "lblCurrenEmployee";
            this.lblCurrenEmployee.Size = new System.Drawing.Size(118, 26);
            this.lblCurrenEmployee.TabIndex = 4;
            this.lblCurrenEmployee.Text = "Empleado 1";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(164, 445);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(211, 61);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Cerrar sesión";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblCabin
            // 
            this.lblCabin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCabin.AutoSize = true;
            this.lblCabin.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCabin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.lblCabin.Location = new System.Drawing.Point(156, 98);
            this.lblCabin.Name = "lblCabin";
            this.lblCabin.Size = new System.Drawing.Size(217, 26);
            this.lblCabin.TabIndex = 6;
            this.lblCabin.Text = "Cabina de Cojutepeque";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnAppointment);
            this.panel1.Controls.Add(this.btnVacProcess);
            this.panel1.Controls.Add(this.btnStatistic);
            this.panel1.Controls.Add(this.btnShowAppointments);
            this.panel1.Location = new System.Drawing.Point(542, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 585);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VaccinationSystemManager.Properties.Resources.Logo_GOES2;
            this.pictureBox1.Location = new System.Drawing.Point(39, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(553, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VaccinationSystemManager.Properties.Resources.logo_covid2;
            this.pictureBox2.Location = new System.Drawing.Point(142, 206);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(258, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCurrenEmployee, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCabin, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(513, 149);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(72, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cabina:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Empleado:";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1162, 584);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnVacProcess;
        private System.Windows.Forms.Button btnShowAppointments;
        private System.Windows.Forms.Label lblCurrenEmployee;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblCabin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}