namespace POS_System
{
    partial class Produit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModifProduit = new System.Windows.Forms.Button();
            this.btnSupProduit = new System.Windows.Forms.Button();
            this.btnAjoutProduit = new System.Windows.Forms.Button();
            this.btnClearProduit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.countLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listUsers = new System.Windows.Forms.ListBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de Produit :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date d\'éxpiration :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(347, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category :";
            // 
            // btnModifProduit
            // 
            this.btnModifProduit.Location = new System.Drawing.Point(447, 461);
            this.btnModifProduit.Name = "btnModifProduit";
            this.btnModifProduit.Size = new System.Drawing.Size(75, 23);
            this.btnModifProduit.TabIndex = 7;
            this.btnModifProduit.Text = "Modifier";
            this.btnModifProduit.UseVisualStyleBackColor = true;
            // 
            // btnSupProduit
            // 
            this.btnSupProduit.Location = new System.Drawing.Point(344, 461);
            this.btnSupProduit.Name = "btnSupProduit";
            this.btnSupProduit.Size = new System.Drawing.Size(75, 23);
            this.btnSupProduit.TabIndex = 8;
            this.btnSupProduit.Text = "Supprimer";
            this.btnSupProduit.UseVisualStyleBackColor = true;
            // 
            // btnAjoutProduit
            // 
            this.btnAjoutProduit.Location = new System.Drawing.Point(344, 112);
            this.btnAjoutProduit.Name = "btnAjoutProduit";
            this.btnAjoutProduit.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutProduit.TabIndex = 9;
            this.btnAjoutProduit.Text = "Ajouter";
            this.btnAjoutProduit.UseVisualStyleBackColor = true;
            // 
            // btnClearProduit
            // 
            this.btnClearProduit.Location = new System.Drawing.Point(439, 112);
            this.btnClearProduit.Name = "btnClearProduit";
            this.btnClearProduit.Size = new System.Drawing.Size(75, 23);
            this.btnClearProduit.TabIndex = 10;
            this.btnClearProduit.Text = "Clear";
            this.btnClearProduit.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 487);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(533, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // countLbl
            // 
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(81, 17);
            this.countLbl.Text = "0 enregistré(s)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listUsers);
            this.groupBox1.Location = new System.Drawing.Point(2, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 289);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List de l\'employé(es) enregistrer";
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.Location = new System.Drawing.Point(0, 20);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(531, 264);
            this.listUsers.TabIndex = 0;
            // 
            // Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnClearProduit);
            this.Controls.Add(this.btnAjoutProduit);
            this.Controls.Add(this.btnSupProduit);
            this.Controls.Add(this.btnModifProduit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Produit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produit";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModifProduit;
        private System.Windows.Forms.Button btnSupProduit;
        private System.Windows.Forms.Button btnAjoutProduit;
        private System.Windows.Forms.Button btnClearProduit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel countLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listUsers;
    }
}