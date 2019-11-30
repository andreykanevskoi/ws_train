﻿namespace WF_App
{
    partial class UserList
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
            this.dgwUsers = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FM_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwUsers
            // 
            this.dgwUsers.AllowUserToAddRows = false;
            this.dgwUsers.AllowUserToDeleteRows = false;
            this.dgwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SecondName,
            this.FM_Name,
            this.Login,
            this.Role});
            this.dgwUsers.Location = new System.Drawing.Point(12, 12);
            this.dgwUsers.Name = "dgwUsers";
            this.dgwUsers.ReadOnly = true;
            this.dgwUsers.RowHeadersWidth = 51;
            this.dgwUsers.RowTemplate.Height = 24;
            this.dgwUsers.Size = new System.Drawing.Size(857, 366);
            this.dgwUsers.TabIndex = 0;
            this.dgwUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "<--- Назад";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ID
            // 
            this.ID.FillWeight = 26.73797F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // SecondName
            // 
            this.SecondName.FillWeight = 118.3155F;
            this.SecondName.HeaderText = "Фамилия";
            this.SecondName.MinimumWidth = 6;
            this.SecondName.Name = "SecondName";
            this.SecondName.ReadOnly = true;
            this.SecondName.Width = 130;
            // 
            // FM_Name
            // 
            this.FM_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FM_Name.FillWeight = 118.3155F;
            this.FM_Name.HeaderText = "Имя Отчество";
            this.FM_Name.MinimumWidth = 6;
            this.FM_Name.Name = "FM_Name";
            this.FM_Name.ReadOnly = true;
            // 
            // Login
            // 
            this.Login.FillWeight = 118.3155F;
            this.Login.HeaderText = "Логин";
            this.Login.MinimumWidth = 6;
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            this.Login.Width = 90;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Role.FillWeight = 118.3155F;
            this.Role.HeaderText = "Должность";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 428);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgwUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserList";
            this.Load += new System.EventHandler(this.UserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUsers;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FM_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}