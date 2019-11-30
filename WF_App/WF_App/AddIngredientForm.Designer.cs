namespace WF_App
{
    partial class AddIngredientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIngredientID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.cboxType = new System.Windows.Forms.ComboBox();
            this.cboxPack = new System.Windows.Forms.ComboBox();
            this.cboxUnit = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Артикул";
            // 
            // txtIngredientID
            // 
            this.txtIngredientID.Location = new System.Drawing.Point(6, 47);
            this.txtIngredientID.Name = "txtIngredientID";
            this.txtIngredientID.Size = new System.Drawing.Size(242, 22);
            this.txtIngredientID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Наименование";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 92);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 22);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Тип";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Цена";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(6, 184);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(242, 22);
            this.txtPrice.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Фасовка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Количество";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(6, 276);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(242, 22);
            this.txtQuantity.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Единицы измерения";
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(18, 385);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(242, 30);
            this.btnAddIngredient.TabIndex = 0;
            this.btnAddIngredient.Text = "Добавить";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // cboxType
            // 
            this.cboxType.FormattingEnabled = true;
            this.cboxType.Location = new System.Drawing.Point(6, 137);
            this.cboxType.Name = "cboxType";
            this.cboxType.Size = new System.Drawing.Size(242, 24);
            this.cboxType.TabIndex = 4;
            // 
            // cboxPack
            // 
            this.cboxPack.FormattingEnabled = true;
            this.cboxPack.Location = new System.Drawing.Point(6, 229);
            this.cboxPack.Name = "cboxPack";
            this.cboxPack.Size = new System.Drawing.Size(242, 24);
            this.cboxPack.TabIndex = 4;
            // 
            // cboxUnit
            // 
            this.cboxUnit.FormattingEnabled = true;
            this.cboxUnit.Location = new System.Drawing.Point(6, 321);
            this.cboxUnit.Name = "cboxUnit";
            this.cboxUnit.Size = new System.Drawing.Size(242, 24);
            this.cboxUnit.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxUnit);
            this.groupBox1.Controls.Add(this.cboxPack);
            this.groupBox1.Controls.Add(this.cboxType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIngredientID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 358);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление ингредиента";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AddIngredientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddIngredient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddIngredientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddIngredientForm";
            this.Load += new System.EventHandler(this.AddIngredientForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIngredientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.ComboBox cboxType;
        private System.Windows.Forms.ComboBox cboxPack;
        private System.Windows.Forms.ComboBox cboxUnit;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}