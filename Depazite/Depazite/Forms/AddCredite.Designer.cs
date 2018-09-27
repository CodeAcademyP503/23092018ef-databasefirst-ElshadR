namespace Depazite.Forms
{
    partial class AddCredite
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
            this.Lb_userName = new System.Windows.Forms.Label();
            this.Txb_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_saveCredite = new System.Windows.Forms.Button();
            this.Dt_DateCredite = new System.Windows.Forms.DateTimePicker();
            this.Btn_allPeople = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_userName
            // 
            this.Lb_userName.AutoSize = true;
            this.Lb_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_userName.Location = new System.Drawing.Point(76, 69);
            this.Lb_userName.Name = "Lb_userName";
            this.Lb_userName.Size = new System.Drawing.Size(51, 20);
            this.Lb_userName.TabIndex = 0;
            this.Lb_userName.Text = "Name";
            // 
            // Txb_price
            // 
            this.Txb_price.Location = new System.Drawing.Point(80, 134);
            this.Txb_price.Name = "Txb_price";
            this.Txb_price.Size = new System.Drawing.Size(152, 20);
            this.Txb_price.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date Credite";
            // 
            // Btn_saveCredite
            // 
            this.Btn_saveCredite.Location = new System.Drawing.Point(157, 229);
            this.Btn_saveCredite.Name = "Btn_saveCredite";
            this.Btn_saveCredite.Size = new System.Drawing.Size(75, 23);
            this.Btn_saveCredite.TabIndex = 2;
            this.Btn_saveCredite.Text = "Save credite";
            this.Btn_saveCredite.UseVisualStyleBackColor = true;
            this.Btn_saveCredite.Click += new System.EventHandler(this.Btn_saveCredite_Click);
            // 
            // Dt_DateCredite
            // 
            this.Dt_DateCredite.Location = new System.Drawing.Point(80, 190);
            this.Dt_DateCredite.Name = "Dt_DateCredite";
            this.Dt_DateCredite.Size = new System.Drawing.Size(152, 20);
            this.Dt_DateCredite.TabIndex = 3;
            // 
            // Btn_allPeople
            // 
            this.Btn_allPeople.Location = new System.Drawing.Point(300, 229);
            this.Btn_allPeople.Name = "Btn_allPeople";
            this.Btn_allPeople.Size = new System.Drawing.Size(75, 23);
            this.Btn_allPeople.TabIndex = 4;
            this.Btn_allPeople.Text = "All";
            this.Btn_allPeople.UseVisualStyleBackColor = true;
            this.Btn_allPeople.Click += new System.EventHandler(this.Btn_allPeople_Click);
            // 
            // AddCredite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 295);
            this.Controls.Add(this.Btn_allPeople);
            this.Controls.Add(this.Dt_DateCredite);
            this.Controls.Add(this.Btn_saveCredite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txb_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lb_userName);
            this.Name = "AddCredite";
            this.Text = "AddCredite";
            this.Load += new System.EventHandler(this.AddCredite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_userName;
        private System.Windows.Forms.TextBox Txb_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_saveCredite;
        private System.Windows.Forms.DateTimePicker Dt_DateCredite;
        private System.Windows.Forms.Button Btn_allPeople;
    }
}