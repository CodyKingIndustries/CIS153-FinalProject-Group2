namespace CIS153_FinalProject_Group2
{
    partial class StatisticsForm
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_loadMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(107, 107);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(122, 24);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_loadMenu
            // 
            this.btn_loadMenu.Location = new System.Drawing.Point(107, 61);
            this.btn_loadMenu.Name = "btn_loadMenu";
            this.btn_loadMenu.Size = new System.Drawing.Size(122, 23);
            this.btn_loadMenu.TabIndex = 1;
            this.btn_loadMenu.Text = "Load Menu";
            this.btn_loadMenu.UseVisualStyleBackColor = true;
            this.btn_loadMenu.Click += new System.EventHandler(this.btn_loadMenu_Click);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 450);
            this.Controls.Add(this.btn_loadMenu);
            this.Controls.Add(this.btn_Exit);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_loadMenu;
    }
}