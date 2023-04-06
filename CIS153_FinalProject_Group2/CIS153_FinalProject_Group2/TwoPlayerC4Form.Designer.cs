namespace CIS153_FinalProject_Group2
{
    partial class TwoPlayerC4Form
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
            this.btn_TPC4F_tempLoadForm = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_TPC4F_tempLoadForm
            // 
            this.btn_TPC4F_tempLoadForm.Location = new System.Drawing.Point(111, 76);
            this.btn_TPC4F_tempLoadForm.Name = "btn_TPC4F_tempLoadForm";
            this.btn_TPC4F_tempLoadForm.Size = new System.Drawing.Size(140, 23);
            this.btn_TPC4F_tempLoadForm.TabIndex = 0;
            this.btn_TPC4F_tempLoadForm.Text = "Load Form1/Main Screen Form";
            this.btn_TPC4F_tempLoadForm.UseVisualStyleBackColor = true;
            this.btn_TPC4F_tempLoadForm.Click += new System.EventHandler(this.btn_TPC4F_tempLoadForm_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(111, 137);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(140, 22);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // TwoPlayerC4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_TPC4F_tempLoadForm);
            this.Name = "TwoPlayerC4Form";
            this.Text = "TwoPlayerC4Form";
            this.Load += new System.EventHandler(this.TwoPlayerC4Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_TPC4F_tempLoadForm;
        private System.Windows.Forms.Button btn_Exit;
    }
}