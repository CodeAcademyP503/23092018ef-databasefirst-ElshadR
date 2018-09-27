namespace Depazite
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txb_surname = new System.Windows.Forms.TextBox();
            this.Btn_savePerson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Txb_name
            // 
            this.Txb_name.Location = new System.Drawing.Point(57, 69);
            this.Txb_name.Name = "Txb_name";
            this.Txb_name.Size = new System.Drawing.Size(149, 20);
            this.Txb_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname";
            // 
            // Txb_surname
            // 
            this.Txb_surname.Location = new System.Drawing.Point(57, 126);
            this.Txb_surname.Name = "Txb_surname";
            this.Txb_surname.Size = new System.Drawing.Size(149, 20);
            this.Txb_surname.TabIndex = 1;
            // 
            // Btn_savePerson
            // 
            this.Btn_savePerson.Location = new System.Drawing.Point(129, 173);
            this.Btn_savePerson.Name = "Btn_savePerson";
            this.Btn_savePerson.Size = new System.Drawing.Size(75, 23);
            this.Btn_savePerson.TabIndex = 2;
            this.Btn_savePerson.Text = "SAVE";
            this.Btn_savePerson.UseVisualStyleBackColor = true;
            this.Btn_savePerson.Click += new System.EventHandler(this.Btn_savePerson_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 265);
            this.Controls.Add(this.Btn_savePerson);
            this.Controls.Add(this.Txb_surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txb_name);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txb_surname;
        private System.Windows.Forms.Button Btn_savePerson;
    }
}

