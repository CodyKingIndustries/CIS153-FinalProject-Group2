namespace CIS153_FinalProject_Group2
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
            this.btn_TempLoadForm = new System.Windows.Forms.Button();
            this.btn_tempLoadTPC4F = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_TempLoadForm
            // 
            this.btn_TempLoadForm.Location = new System.Drawing.Point(73, 63);
            this.btn_TempLoadForm.Name = "btn_TempLoadForm";
            this.btn_TempLoadForm.Size = new System.Drawing.Size(144, 23);
            this.btn_TempLoadForm.TabIndex = 0;
            this.btn_TempLoadForm.Text = "Load SinglePlayerC4Form";
            this.btn_TempLoadForm.UseVisualStyleBackColor = true;
            this.btn_TempLoadForm.Click += new System.EventHandler(this.btn_TempLoadForm_Click);
            // 
            // btn_tempLoadTPC4F
            // 
            this.btn_tempLoadTPC4F.Location = new System.Drawing.Point(73, 108);
            this.btn_tempLoadTPC4F.Name = "btn_tempLoadTPC4F";
            this.btn_tempLoadTPC4F.Size = new System.Drawing.Size(144, 23);
            this.btn_tempLoadTPC4F.TabIndex = 1;
            this.btn_tempLoadTPC4F.Text = "Load TwoPlayerC4Form";
            this.btn_tempLoadTPC4F.UseVisualStyleBackColor = true;
            this.btn_tempLoadTPC4F.Click += new System.EventHandler(this.btn_tempLoadTPC4F_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.btn_tempLoadTPC4F);
            this.Controls.Add(this.btn_TempLoadForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_TempLoadForm;
        private System.Windows.Forms.Button btn_tempLoadTPC4F;
    }
}

