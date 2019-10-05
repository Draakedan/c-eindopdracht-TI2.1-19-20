namespace Client
{
    partial class LogInGUI
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
            this.lbl_logIn = new System.Windows.Forms.Label();
            this.btn_logIn = new System.Windows.Forms.Button();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_logIn
            // 
            this.lbl_logIn.AutoSize = true;
            this.lbl_logIn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_logIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logIn.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_logIn.Location = new System.Drawing.Point(128, -2);
            this.lbl_logIn.Name = "lbl_logIn";
            this.lbl_logIn.Size = new System.Drawing.Size(62, 24);
            this.lbl_logIn.TabIndex = 0;
            this.lbl_logIn.Text = "Log in";
            // 
            // btn_logIn
            // 
            this.btn_logIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logIn.Location = new System.Drawing.Point(114, 118);
            this.btn_logIn.Name = "btn_logIn";
            this.btn_logIn.Size = new System.Drawing.Size(85, 35);
            this.btn_logIn.TabIndex = 1;
            this.btn_logIn.Text = "Log in";
            this.btn_logIn.UseVisualStyleBackColor = true;
            this.btn_logIn.Click += new System.EventHandler(this.btn_logIn_Click);
            // 
            // tbx_username
            // 
            this.tbx_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_username.Location = new System.Drawing.Point(59, 59);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(214, 29);
            this.tbx_username.TabIndex = 2;
            // 
            // LogInGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Client.Properties.Resources.program_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(324, 212);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.btn_logIn);
            this.Controls.Add(this.lbl_logIn);
            this.Name = "LogInGUI";
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_logIn;
        private System.Windows.Forms.Button btn_logIn;
        private System.Windows.Forms.TextBox tbx_username;
    }
}