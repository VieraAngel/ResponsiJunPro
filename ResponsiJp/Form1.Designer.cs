namespace ResponsiJp
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbDep = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDep = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 65);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 100);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(91, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Nama Karyawan :";
            // 
            // lbDep
            // 
            this.lbDep.AutoSize = true;
            this.lbDep.Location = new System.Drawing.Point(12, 132);
            this.lbDep.Name = "lbDep";
            this.lbDep.Size = new System.Drawing.Size(86, 13);
            this.lbDep.TabIndex = 2;
            this.lbDep.Text = "Dep. Karyawan :";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(109, 97);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(394, 20);
            this.tbName.TabIndex = 3;
            // 
            // tbDep
            // 
            this.tbDep.Location = new System.Drawing.Point(109, 129);
            this.tbDep.Name = "tbDep";
            this.tbDep.Size = new System.Drawing.Size(394, 20);
            this.tbDep.TabIndex = 4;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(15, 171);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(101, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(136, 171);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(258, 171);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(15, 209);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(488, 216);
            this.dgvData.TabIndex = 8;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(400, 171);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(103, 23);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbDep);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbDep);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDep;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDep;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnLoad;
    }
}

