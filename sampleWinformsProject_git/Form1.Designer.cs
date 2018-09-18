namespace sampleWinformsProject_git
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
            this.btnAlert = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlert
            // 
            this.btnAlert.Location = new System.Drawing.Point(12, 58);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Size = new System.Drawing.Size(75, 23);
            this.btnAlert.TabIndex = 0;
            this.btnAlert.Text = "OK";
            this.btnAlert.UseVisualStyleBackColor = true;
            this.btnAlert.Click += new System.EventHandler(this.btnAlert_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "txtName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // btnShowForm2
            // 
            this.btnShowForm2.Location = new System.Drawing.Point(12, 87);
            this.btnShowForm2.Name = "btnShowForm2";
            this.btnShowForm2.Size = new System.Drawing.Size(75, 23);
            this.btnShowForm2.TabIndex = 3;
            this.btnShowForm2.Text = "Show Form 2";
            this.btnShowForm2.UseVisualStyleBackColor = true;
            this.btnShowForm2.Click += new System.EventHandler(this.btnShowForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 141);
            this.Controls.Add(this.btnShowForm2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAlert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlert;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowForm2;
    }
}

