namespace TestApp
{
    partial class MainForm
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
            this.btnStartSearch = new System.Windows.Forms.Button();
            this.txtNameOrID = new System.Windows.Forms.TextBox();
            this.lblNameOrID = new System.Windows.Forms.Label();
            this.dgvPatientList = new System.Windows.Forms.DataGridView();
            this.PatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentityNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartSearch
            // 
            this.btnStartSearch.Location = new System.Drawing.Point(422, 24);
            this.btnStartSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartSearch.Name = "btnStartSearch";
            this.btnStartSearch.Size = new System.Drawing.Size(100, 28);
            this.btnStartSearch.TabIndex = 0;
            this.btnStartSearch.Text = "Search";
            this.btnStartSearch.UseVisualStyleBackColor = true;
            this.btnStartSearch.Click += new System.EventHandler(this.btnStartSearch_Click);
            // 
            // txtNameOrID
            // 
            this.txtNameOrID.Location = new System.Drawing.Point(207, 27);
            this.txtNameOrID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNameOrID.Name = "txtNameOrID";
            this.txtNameOrID.Size = new System.Drawing.Size(207, 23);
            this.txtNameOrID.TabIndex = 1;
            // 
            // lblNameOrID
            // 
            this.lblNameOrID.AutoSize = true;
            this.lblNameOrID.Location = new System.Drawing.Point(56, 31);
            this.lblNameOrID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameOrID.Name = "lblNameOrID";
            this.lblNameOrID.Size = new System.Drawing.Size(141, 17);
            this.lblNameOrID.TabIndex = 2;
            this.lblNameOrID.Text = "Identity No. or Name:";
            // 
            // dgvPatientList
            // 
            this.dgvPatientList.AllowUserToAddRows = false;
            this.dgvPatientList.AllowUserToDeleteRows = false;
            this.dgvPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientId,
            this.PatientName,
            this.CardNo,
            this.IdentityNo,
            this.Gender,
            this.Birth});
            this.dgvPatientList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPatientList.Location = new System.Drawing.Point(0, 69);
            this.dgvPatientList.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.dgvPatientList.Name = "dgvPatientList";
            this.dgvPatientList.Size = new System.Drawing.Size(965, 388);
            this.dgvPatientList.TabIndex = 3;
            // 
            // PatientId
            // 
            this.PatientId.HeaderText = "PatientId";
            this.PatientId.Name = "PatientId";
            this.PatientId.Visible = false;
            // 
            // PatientName
            // 
            this.PatientName.DataPropertyName = "Name";
            this.PatientName.HeaderText = "Name";
            this.PatientName.Name = "PatientName";
            // 
            // CardNo
            // 
            this.CardNo.DataPropertyName = "CardNo";
            this.CardNo.HeaderText = "CardNo";
            this.CardNo.Name = "CardNo";
            // 
            // IdentityNo
            // 
            this.IdentityNo.DataPropertyName = "IdentityNo";
            this.IdentityNo.HeaderText = "IdentityNo";
            this.IdentityNo.Name = "IdentityNo";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "GenderString";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // Birth
            // 
            this.Birth.DataPropertyName = "Birth";
            this.Birth.HeaderText = "Birthdate";
            this.Birth.Name = "Birth";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 457);
            this.Controls.Add(this.dgvPatientList);
            this.Controls.Add(this.lblNameOrID);
            this.Controls.Add(this.txtNameOrID);
            this.Controls.Add(this.btnStartSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartSearch;
        private System.Windows.Forms.TextBox txtNameOrID;
        private System.Windows.Forms.Label lblNameOrID;
        private System.Windows.Forms.DataGridView dgvPatientList;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentityNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birth;
    }
}

