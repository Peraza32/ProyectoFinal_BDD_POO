
namespace VaccinationSystemManager.Views
{
    partial class frmVerifyCitizen
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
            this.lblVerifyCitizenTitle = new System.Windows.Forms.Label();
            this.lblVerifyCitizenDUI = new System.Windows.Forms.Label();
            this.txtVerifyCitizenDUI = new System.Windows.Forms.TextBox();
            this.btnVerifyCitizenCancel = new System.Windows.Forms.Button();
            this.btnVerifyCitizenSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVerifyCitizenTitle
            // 
            this.lblVerifyCitizenTitle.AutoSize = true;
            this.lblVerifyCitizenTitle.Location = new System.Drawing.Point(67, 65);
            this.lblVerifyCitizenTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVerifyCitizenTitle.Name = "lblVerifyCitizenTitle";
            this.lblVerifyCitizenTitle.Size = new System.Drawing.Size(442, 26);
            this.lblVerifyCitizenTitle.TabIndex = 0;
            this.lblVerifyCitizenTitle.Text = "¡Veamos si ya llegó tu momento para vacunarte!";
            // 
            // lblVerifyCitizenDUI
            // 
            this.lblVerifyCitizenDUI.AutoSize = true;
            this.lblVerifyCitizenDUI.Location = new System.Drawing.Point(173, 186);
            this.lblVerifyCitizenDUI.Name = "lblVerifyCitizenDUI";
            this.lblVerifyCitizenDUI.Size = new System.Drawing.Size(240, 26);
            this.lblVerifyCitizenDUI.TabIndex = 1;
            this.lblVerifyCitizenDUI.Text = "Ingresa tu número de DUI";
            // 
            // txtVerifyCitizenDUI
            // 
            this.txtVerifyCitizenDUI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtVerifyCitizenDUI.Location = new System.Drawing.Point(123, 227);
            this.txtVerifyCitizenDUI.Name = "txtVerifyCitizenDUI";
            this.txtVerifyCitizenDUI.Size = new System.Drawing.Size(338, 31);
            this.txtVerifyCitizenDUI.TabIndex = 2;
            this.txtVerifyCitizenDUI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVerifyCitizenDUI_KeyPress);
            // 
            // btnVerifyCitizenCancel
            // 
            this.btnVerifyCitizenCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(140)))));
            this.btnVerifyCitizenCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerifyCitizenCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyCitizenCancel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerifyCitizenCancel.Location = new System.Drawing.Point(82, 386);
            this.btnVerifyCitizenCancel.Name = "btnVerifyCitizenCancel";
            this.btnVerifyCitizenCancel.Size = new System.Drawing.Size(170, 57);
            this.btnVerifyCitizenCancel.TabIndex = 3;
            this.btnVerifyCitizenCancel.Text = "Cancelar";
            this.btnVerifyCitizenCancel.UseVisualStyleBackColor = false;
            this.btnVerifyCitizenCancel.Click += new System.EventHandler(this.btnVerifyCitizenCancel_Click);
            // 
            // btnVerifyCitizenSearch
            // 
            this.btnVerifyCitizenSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(140)))));
            this.btnVerifyCitizenSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerifyCitizenSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyCitizenSearch.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerifyCitizenSearch.Location = new System.Drawing.Point(329, 386);
            this.btnVerifyCitizenSearch.Name = "btnVerifyCitizenSearch";
            this.btnVerifyCitizenSearch.Size = new System.Drawing.Size(170, 57);
            this.btnVerifyCitizenSearch.TabIndex = 4;
            this.btnVerifyCitizenSearch.Text = "Buscar";
            this.btnVerifyCitizenSearch.UseVisualStyleBackColor = false;
            this.btnVerifyCitizenSearch.Click += new System.EventHandler(this.btnVerifyCitizenSearch_Click);
            // 
            // frmVerifyCitizen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(574, 506);
            this.Controls.Add(this.btnVerifyCitizenSearch);
            this.Controls.Add(this.btnVerifyCitizenCancel);
            this.Controls.Add(this.txtVerifyCitizenDUI);
            this.Controls.Add(this.lblVerifyCitizenDUI);
            this.Controls.Add(this.lblVerifyCitizenTitle);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmVerifyCitizen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVerifyCitizenTitle;
        private System.Windows.Forms.Label lblVerifyCitizenDUI;
        private System.Windows.Forms.TextBox txtVerifyCitizenDUI;
        private System.Windows.Forms.Button btnVerifyCitizenCancel;
        private System.Windows.Forms.Button btnVerifyCitizenSearch;
    }
}