namespace POS_System
{
    partial class before
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
            this.bntUser = new System.Windows.Forms.Button();
            this.btnAdmn = new System.Windows.Forms.Button();
            this.extLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntUser
            // 
            this.bntUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bntUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.bntUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntUser.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntUser.Location = new System.Drawing.Point(194, 133);
            this.bntUser.Name = "bntUser";
            this.bntUser.Size = new System.Drawing.Size(170, 52);
            this.bntUser.TabIndex = 1;
            this.bntUser.Text = "Utilisateur";
            this.bntUser.UseVisualStyleBackColor = false;
            this.bntUser.Click += new System.EventHandler(this.bntUser_Click);
            // 
            // btnAdmn
            // 
            this.btnAdmn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdmn.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdmn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmn.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmn.Location = new System.Drawing.Point(194, 52);
            this.btnAdmn.Name = "btnAdmn";
            this.btnAdmn.Size = new System.Drawing.Size(170, 52);
            this.btnAdmn.TabIndex = 2;
            this.btnAdmn.Text = "Administrateur";
            this.btnAdmn.UseVisualStyleBackColor = false;
            this.btnAdmn.Click += new System.EventHandler(this.btnAdmn_Click);
            // 
            // extLbl
            // 
            this.extLbl.AutoSize = true;
            this.extLbl.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extLbl.ForeColor = System.Drawing.Color.Red;
            this.extLbl.Location = new System.Drawing.Point(399, 9);
            this.extLbl.Name = "extLbl";
            this.extLbl.Size = new System.Drawing.Size(17, 18);
            this.extLbl.TabIndex = 3;
            this.extLbl.Text = "x";
            this.extLbl.Click += new System.EventHandler(this.extLbl_Click);
            // 
            // before
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 215);
            this.Controls.Add(this.extLbl);
            this.Controls.Add(this.btnAdmn);
            this.Controls.Add(this.bntUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "before";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Se connecter en tant que";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntUser;
        private System.Windows.Forms.Button btnAdmn;
        private System.Windows.Forms.Label extLbl;
    }
}