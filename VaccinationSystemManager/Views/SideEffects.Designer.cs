
namespace VaccinationSystemManager.Views
{
    partial class frmSideEffects
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
            this.btnSideEffectsSave = new System.Windows.Forms.Button();
            this.btnSideEffectsCancel = new System.Windows.Forms.Button();
            this.lblSideEffectsTitle = new System.Windows.Forms.Label();
            this.lblSideEffectsEfecto = new System.Windows.Forms.Label();
            this.cmbSideEffectsList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSideEffectsSave
            // 
            this.btnSideEffectsSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(140)))));
            this.btnSideEffectsSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideEffectsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideEffectsSave.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSideEffectsSave.Location = new System.Drawing.Point(287, 535);
            this.btnSideEffectsSave.Name = "btnSideEffectsSave";
            this.btnSideEffectsSave.Size = new System.Drawing.Size(170, 57);
            this.btnSideEffectsSave.TabIndex = 8;
            this.btnSideEffectsSave.Text = "Registrar";
            this.btnSideEffectsSave.UseVisualStyleBackColor = false;
            this.btnSideEffectsSave.Click += new System.EventHandler(this.btnSideEffectsSave_Click);
            // 
            // btnSideEffectsCancel
            // 
            this.btnSideEffectsCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(140)))));
            this.btnSideEffectsCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideEffectsCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideEffectsCancel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSideEffectsCancel.Location = new System.Drawing.Point(40, 535);
            this.btnSideEffectsCancel.Name = "btnSideEffectsCancel";
            this.btnSideEffectsCancel.Size = new System.Drawing.Size(170, 57);
            this.btnSideEffectsCancel.TabIndex = 7;
            this.btnSideEffectsCancel.Text = "Cancelar";
            this.btnSideEffectsCancel.UseVisualStyleBackColor = false;
            this.btnSideEffectsCancel.Click += new System.EventHandler(this.btnSideEffectsCancel_Click);
            // 
            // lblSideEffectsTitle
            // 
            this.lblSideEffectsTitle.AutoSize = true;
            this.lblSideEffectsTitle.Location = new System.Drawing.Point(105, 34);
            this.lblSideEffectsTitle.Name = "lblSideEffectsTitle";
            this.lblSideEffectsTitle.Size = new System.Drawing.Size(260, 26);
            this.lblSideEffectsTitle.TabIndex = 9;
            this.lblSideEffectsTitle.Text = "Registrar efecto secundario";
            // 
            // lblSideEffectsEfecto
            // 
            this.lblSideEffectsEfecto.AutoSize = true;
            this.lblSideEffectsEfecto.Location = new System.Drawing.Point(105, 181);
            this.lblSideEffectsEfecto.Name = "lblSideEffectsEfecto";
            this.lblSideEffectsEfecto.Size = new System.Drawing.Size(278, 26);
            this.lblSideEffectsEfecto.TabIndex = 10;
            this.lblSideEffectsEfecto.Text = "Efecto secundario presentado";
            // 
            // cmbSideEffectsList
            // 
            this.cmbSideEffectsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSideEffectsList.FormattingEnabled = true;
            this.cmbSideEffectsList.Location = new System.Drawing.Point(50, 233);
            this.cmbSideEffectsList.Name = "cmbSideEffectsList";
            this.cmbSideEffectsList.Size = new System.Drawing.Size(393, 34);
            this.cmbSideEffectsList.TabIndex = 11;
            // 
            // frmSideEffects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(492, 622);
            this.Controls.Add(this.cmbSideEffectsList);
            this.Controls.Add(this.lblSideEffectsEfecto);
            this.Controls.Add(this.lblSideEffectsTitle);
            this.Controls.Add(this.btnSideEffectsSave);
            this.Controls.Add(this.btnSideEffectsCancel);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSideEffects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Side Effects";
            this.Load += new System.EventHandler(this.frmSideEffects_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSideEffectsSave;
        private System.Windows.Forms.Button btnSideEffectsCancel;
        private System.Windows.Forms.Label lblSideEffectsTitle;
        private System.Windows.Forms.Label lblSideEffectsEfecto;
        private System.Windows.Forms.ComboBox cmbSideEffectsList;
    }
}