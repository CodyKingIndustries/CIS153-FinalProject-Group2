namespace CIS153_FinalProject_Group2
{
    partial class SinglePlayerC4Form
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
            this.btn_SPC4_tempLoadForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SPC4_tempLoadForm
            // 
            this.btn_SPC4_tempLoadForm.Location = new System.Drawing.Point(70, 70);
            this.btn_SPC4_tempLoadForm.Name = "btn_SPC4_tempLoadForm";
            this.btn_SPC4_tempLoadForm.Size = new System.Drawing.Size(135, 23);
            this.btn_SPC4_tempLoadForm.TabIndex = 0;
            this.btn_SPC4_tempLoadForm.Text = "Load Form1/Main Screen";
            this.btn_SPC4_tempLoadForm.UseVisualStyleBackColor = true;
            this.btn_SPC4_tempLoadForm.Click += new System.EventHandler(this.btn_SPC4_tempLoadForm_Click);
            // 
            // SinglePlayerC4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.btn_SPC4_tempLoadForm);
            this.Name = "SinglePlayerC4Form";
            this.Text = "SinglePlayerC4Form";
            this.Load += new System.EventHandler(this.SinglePlayerC4Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SPC4_tempLoadForm;
    }
}