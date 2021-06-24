
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVerifyCitizenTitle
            // 
            this.lblVerifyCitizenTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVerifyCitizenTitle.AutoSize = true;
            this.lblVerifyCitizenTitle.Location = new System.Drawing.Point(64, 154);
            this.lblVerifyCitizenTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVerifyCitizenTitle.Name = "lblVerifyCitizenTitle";
            this.lblVerifyCitizenTitle.Size = new System.Drawing.Size(442, 26);
            this.lblVerifyCitizenTitle.TabIndex = 0;
            this.lblVerifyCitizenTitle.Text = "¡Veamos si ya llegó tu momento para vacunarte!";
            // 
            // lblVerifyCitizenDUI
            // 
            this.lblVerifyCitizenDUI.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVerifyCitizenDUI.AutoSize = true;
            this.lblVerifyCitizenDUI.Location = new System.Drawing.Point(165, 227);
            this.lblVerifyCitizenDUI.Name = "lblVerifyCitizenDUI";
            this.lblVerifyCitizenDUI.Size = new System.Drawing.Size(240, 26);
            this.lblVerifyCitizenDUI.TabIndex = 1;
            this.lblVerifyCitizenDUI.Text = "Ingresa tu número de DUI";
            // 
            // txtVerifyCitizenDUI
            // 
            this.txtVerifyCitizenDUI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerifyCitizenDUI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtVerifyCitizenDUI.Location = new System.Drawing.Point(116, 272);
            this.txtVerifyCitizenDUI.Name = "txtVerifyCitizenDUI";
            this.txtVerifyCitizenDUI.Size = new System.Drawing.Size(338, 31);
            this.txtVerifyCitizenDUI.TabIndex = 2;
            this.txtVerifyCitizenDUI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVerifyCitizenDUI_KeyPress);
            // 
            // btnVerifyCitizenCancel
            // 
            this.btnVerifyCitizenCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVerifyCitizenCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(140)))));
            this.btnVerifyCitizenCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerifyCitizenCancel.FlatAppearance.BorderSize = 0;
            this.btnVerifyCitizenCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyCitizenCancel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerifyCitizenCancel.Location = new System.Drawing.Point(27, 3);
            this.btnVerifyCitizenCancel.Name = "btnVerifyCitizenCancel";
            this.btnVerifyCitizenCancel.Size = new System.Drawing.Size(170, 57);
            this.btnVerifyCitizenCancel.TabIndex = 3;
            this.btnVerifyCitizenCancel.Text = "Regresar";
            this.btnVerifyCitizenCancel.UseVisualStyleBackColor = false;
            this.btnVerifyCitizenCancel.Click += new System.EventHandler(this.btnVerifyCitizenCancel_Click);
            // 
            // btnVerifyCitizenSearch
            // 
            this.btnVerifyCitizenSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVerifyCitizenSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(140)))));
            this.btnVerifyCitizenSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerifyCitizenSearch.FlatAppearance.BorderSize = 0;
            this.btnVerifyCitizenSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyCitizenSearch.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerifyCitizenSearch.Location = new System.Drawing.Point(253, 3);
            this.btnVerifyCitizenSearch.Name = "btnVerifyCitizenSearch";
            this.btnVerifyCitizenSearch.Size = new System.Drawing.Size(170, 57);
            this.btnVerifyCitizenSearch.TabIndex = 4;
            this.btnVerifyCitizenSearch.Text = "Buscar";
            this.btnVerifyCitizenSearch.UseVisualStyleBackColor = false;
            this.btnVerifyCitizenSearch.Click += new System.EventHandler(this.btnVerifyCitizenSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VaccinationSystemManager.Properties.Resources.Logo_GOES2;
            this.pictureBox1.Location = new System.Drawing.Point(60, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblVerifyCitizenTitle, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblVerifyCitizenDUI, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtVerifyCitizenDUI, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.800525F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.30812F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.134732F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.94258F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.94258F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.66163F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.20983F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(572, 509);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnVerifyCitizenCancel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnVerifyCitizenSearch, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(60, 353);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(451, 65);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // frmVerifyCitizen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(582, 486);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmVerifyCitizen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verify Citizen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblVerifyCitizenTitle;
        private System.Windows.Forms.Label lblVerifyCitizenDUI;
        private System.Windows.Forms.TextBox txtVerifyCitizenDUI;
        private System.Windows.Forms.Button btnVerifyCitizenCancel;
        private System.Windows.Forms.Button btnVerifyCitizenSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}