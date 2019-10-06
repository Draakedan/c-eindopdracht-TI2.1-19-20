namespace Client
{
    partial class DateSelectGUI
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
            this.lbl_dateSelectHeader = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.cbx_day = new System.Windows.Forms.ComboBox();
            this.cbx_time = new System.Windows.Forms.ComboBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_dateSelectHeader
            // 
            this.lbl_dateSelectHeader.AutoSize = true;
            this.lbl_dateSelectHeader.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dateSelectHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateSelectHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_dateSelectHeader.Location = new System.Drawing.Point(71, 9);
            this.lbl_dateSelectHeader.Name = "lbl_dateSelectHeader";
            this.lbl_dateSelectHeader.Size = new System.Drawing.Size(103, 24);
            this.lbl_dateSelectHeader.TabIndex = 0;
            this.lbl_dateSelectHeader.Text = "Select date";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(86, 58);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(80, 20);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "username";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.BackColor = System.Drawing.Color.Transparent;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_result.Location = new System.Drawing.Point(12, 180);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(186, 20);
            this.lbl_result.TabIndex = 2;
            this.lbl_result.Text = "selected date is taken";
            this.lbl_result.Visible = false;
            // 
            // cbx_day
            // 
            this.cbx_day.FormattingEnabled = true;
            this.cbx_day.Location = new System.Drawing.Point(53, 97);
            this.cbx_day.Name = "cbx_day";
            this.cbx_day.Size = new System.Drawing.Size(121, 21);
            this.cbx_day.TabIndex = 3;
            this.cbx_day.SelectedIndexChanged += new System.EventHandler(this.cbx_day_SelectedIndexChanged);
            // 
            // cbx_time
            // 
            this.cbx_time.FormattingEnabled = true;
            this.cbx_time.Location = new System.Drawing.Point(53, 142);
            this.cbx_time.Name = "cbx_time";
            this.cbx_time.Size = new System.Drawing.Size(121, 21);
            this.cbx_time.TabIndex = 4;
            this.cbx_time.SelectedIndexChanged += new System.EventHandler(this.cbx_time_SelectedIndexChanged);
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.Location = new System.Drawing.Point(75, 224);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(68, 25);
            this.btn_enter.TabIndex = 5;
            this.btn_enter.Text = "ok";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // DateSelectGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Client.Properties.Resources.program_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(250, 295);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.cbx_time);
            this.Controls.Add(this.cbx_day);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_dateSelectHeader);
            this.Name = "DateSelectGUI";
            this.Text = "Select date";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dateSelectHeader;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.ComboBox cbx_day;
        private System.Windows.Forms.ComboBox cbx_time;
        private System.Windows.Forms.Button btn_enter;
    }
}