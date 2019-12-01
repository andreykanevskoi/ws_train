namespace WF_App
{
    partial class Menu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUsersList = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIngredientsList = new System.Windows.Forms.Button();
            this.btnCabinet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUsersList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Директор";
            // 
            // btnUsersList
            // 
            this.btnUsersList.Location = new System.Drawing.Point(6, 26);
            this.btnUsersList.Name = "btnUsersList";
            this.btnUsersList.Size = new System.Drawing.Size(304, 43);
            this.btnUsersList.TabIndex = 0;
            this.btnUsersList.Text = "Список пользователей";
            this.btnUsersList.UseVisualStyleBackColor = true;
            this.btnUsersList.Click += new System.EventHandler(this.btnUsersList_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(18, 395);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(304, 43);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCabinet);
            this.groupBox2.Controls.Add(this.btnIngredientsList);
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 128);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Персонал";
            // 
            // btnIngredientsList
            // 
            this.btnIngredientsList.Location = new System.Drawing.Point(5, 22);
            this.btnIngredientsList.Name = "btnIngredientsList";
            this.btnIngredientsList.Size = new System.Drawing.Size(305, 43);
            this.btnIngredientsList.TabIndex = 0;
            this.btnIngredientsList.Text = "Таблица ингредиентов";
            this.btnIngredientsList.UseVisualStyleBackColor = true;
            this.btnIngredientsList.Click += new System.EventHandler(this.btnIngredientsList_Click);
            // 
            // btnCabinet
            // 
            this.btnCabinet.Location = new System.Drawing.Point(5, 79);
            this.btnCabinet.Name = "btnCabinet";
            this.btnCabinet.Size = new System.Drawing.Size(305, 43);
            this.btnCabinet.TabIndex = 3;
            this.btnCabinet.Text = "Личный кабинет";
            this.btnCabinet.UseVisualStyleBackColor = true;
            this.btnCabinet.Click += new System.EventHandler(this.btnCabinet_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUsersList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIngredientsList;
        private System.Windows.Forms.Button btnCabinet;
    }
}