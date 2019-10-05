namespace Client
{
    partial class ResultGUI
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
            this.lbl_ResultHeader = new System.Windows.Forms.Label();
            this.lbl_chosenData = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ResultHeader
            // 
            this.lbl_ResultHeader.AutoSize = true;
            this.lbl_ResultHeader.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ResultHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ResultHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_ResultHeader.Location = new System.Drawing.Point(53, -2);
            this.lbl_ResultHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_ResultHeader.Name = "lbl_ResultHeader";
            this.lbl_ResultHeader.Size = new System.Drawing.Size(218, 25);
            this.lbl_ResultHeader.TabIndex = 0;
            this.lbl_ResultHeader.Text = "chosen date and time";
            // 
            // lbl_chosenData
            // 
            this.lbl_chosenData.AutoSize = true;
            this.lbl_chosenData.BackColor = System.Drawing.Color.Transparent;
            this.lbl_chosenData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chosenData.Location = new System.Drawing.Point(106, 56);
            this.lbl_chosenData.Name = "lbl_chosenData";
            this.lbl_chosenData.Size = new System.Drawing.Size(102, 48);
            this.lbl_chosenData.TabIndex = 1;
            this.lbl_chosenData.Text = "31-10-2019\r\n9:30";
            this.lbl_chosenData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(110, 126);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(87, 33);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // ResultGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Client.Properties.Resources.program_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(324, 212);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_chosenData);
            this.Controls.Add(this.lbl_ResultHeader);
            this.Name = "ResultGUI";
            this.Text = "Result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ResultHeader;
        private System.Windows.Forms.Label lbl_chosenData;
        private System.Windows.Forms.Button btn_close;
    }
}