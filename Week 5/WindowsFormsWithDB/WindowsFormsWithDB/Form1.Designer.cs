namespace WindowsFormsWithDB
{
    partial class Form1
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
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.btLoadData = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.lbAge = new System.Windows.Forms.Label();
            this.btInsertData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPerson
            // 
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Location = new System.Drawing.Point(31, 33);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.Size = new System.Drawing.Size(428, 200);
            this.dgvPerson.TabIndex = 0;
            // 
            // btLoadData
            // 
            this.btLoadData.Location = new System.Drawing.Point(178, 268);
            this.btLoadData.Name = "btLoadData";
            this.btLoadData.Size = new System.Drawing.Size(164, 33);
            this.btLoadData.TabIndex = 1;
            this.btLoadData.Text = "Load Data";
            this.btLoadData.UseVisualStyleBackColor = true;
            this.btLoadData.Click += new System.EventHandler(this.btLoadData_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(651, 69);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(125, 20);
            this.tbName.TabIndex = 2;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(595, 76);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(651, 121);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(125, 20);
            this.tbAge.TabIndex = 4;
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(604, 128);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(26, 13);
            this.lbAge.TabIndex = 5;
            this.lbAge.Text = "Age";
            this.lbAge.Click += new System.EventHandler(this.label2_Click);
            // 
            // btInsertData
            // 
            this.btInsertData.Location = new System.Drawing.Point(612, 268);
            this.btInsertData.Name = "btInsertData";
            this.btInsertData.Size = new System.Drawing.Size(164, 33);
            this.btInsertData.TabIndex = 6;
            this.btInsertData.Text = "Insert Data";
            this.btInsertData.UseVisualStyleBackColor = true;
            this.btInsertData.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btInsertData);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btLoadData);
            this.Controls.Add(this.dgvPerson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.Button btLoadData;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Button btInsertData;
    }
}

