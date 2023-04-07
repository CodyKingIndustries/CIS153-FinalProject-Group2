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
            this.lbl_TPC4F_TempBoardDisplay = new System.Windows.Forms.Label();
            this.btn_TPC4F_tempPlacePiece = new System.Windows.Forms.Button();
            this.txtbox_TPC4F_ColumSelector = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_TPC4F_tempLoadForm
            // 
            this.btn_TPC4F_tempLoadForm.Location = new System.Drawing.Point(47, 371);
            this.btn_TPC4F_tempLoadForm.Name = "btn_TPC4F_tempLoadForm";
            this.btn_TPC4F_tempLoadForm.Size = new System.Drawing.Size(140, 23);
            this.btn_TPC4F_tempLoadForm.TabIndex = 0;
            this.btn_TPC4F_tempLoadForm.Text = "Load Form1/Main Screen Form";
            this.btn_TPC4F_tempLoadForm.UseVisualStyleBackColor = true;
            this.btn_TPC4F_tempLoadForm.Click += new System.EventHandler(this.btn_TPC4F_tempLoadForm_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(222, 372);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(140, 22);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_TPC4F_TempBoardDisplay
            // 
            this.lbl_TPC4F_TempBoardDisplay.AutoSize = true;
            this.lbl_TPC4F_TempBoardDisplay.Location = new System.Drawing.Point(109, 68);
            this.lbl_TPC4F_TempBoardDisplay.Name = "lbl_TPC4F_TempBoardDisplay";
            this.lbl_TPC4F_TempBoardDisplay.Size = new System.Drawing.Size(102, 13);
            this.lbl_TPC4F_TempBoardDisplay.TabIndex = 2;
            this.lbl_TPC4F_TempBoardDisplay.Text = "Temp Board Display";
            // 
            // btn_TPC4F_tempPlacePiece
            // 
            this.btn_TPC4F_tempPlacePiece.Location = new System.Drawing.Point(113, 302);
            this.btn_TPC4F_tempPlacePiece.Name = "btn_TPC4F_tempPlacePiece";
            this.btn_TPC4F_tempPlacePiece.Size = new System.Drawing.Size(98, 23);
            this.btn_TPC4F_tempPlacePiece.TabIndex = 3;
            this.btn_TPC4F_tempPlacePiece.Text = "Place In Colum:";
            this.btn_TPC4F_tempPlacePiece.UseVisualStyleBackColor = true;
            this.btn_TPC4F_tempPlacePiece.Click += new System.EventHandler(this.btn_TPC4F_tempPlacePiece_Click);
            // 
            // txtbox_TPC4F_ColumSelector
            // 
            this.txtbox_TPC4F_ColumSelector.Location = new System.Drawing.Point(217, 305);
            this.txtbox_TPC4F_ColumSelector.Name = "txtbox_TPC4F_ColumSelector";
            this.txtbox_TPC4F_ColumSelector.Size = new System.Drawing.Size(100, 20);
            this.txtbox_TPC4F_ColumSelector.TabIndex = 4;
            // 
            // TwoPlayerC4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.txtbox_TPC4F_ColumSelector);
            this.Controls.Add(this.btn_TPC4F_tempPlacePiece);
            this.Controls.Add(this.lbl_TPC4F_TempBoardDisplay);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_TPC4F_tempLoadForm);
            this.Name = "TwoPlayerC4Form";
            this.Text = "TwoPlayerC4Form";
            this.Load += new System.EventHandler(this.TwoPlayerC4Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TPC4F_tempLoadForm;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_TPC4F_TempBoardDisplay;
        private System.Windows.Forms.Button btn_TPC4F_tempPlacePiece;
        private System.Windows.Forms.TextBox txtbox_TPC4F_ColumSelector;
    }
}