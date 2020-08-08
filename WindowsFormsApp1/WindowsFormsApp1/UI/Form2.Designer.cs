namespace WindowsFormsApp1
{
    partial class Form2
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
            this.TXTUSER = new System.Windows.Forms.TextBox();
            this.TXTPASS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_LOGIN = new System.Windows.Forms.Button();
            this.BTN_CANCLE = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTUSER
            // 
            this.TXTUSER.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTUSER.Location = new System.Drawing.Point(380, 76);
            this.TXTUSER.Name = "TXTUSER";
            this.TXTUSER.Size = new System.Drawing.Size(204, 38);
            this.TXTUSER.TabIndex = 0;
            // 
            // TXTPASS
            // 
            this.TXTPASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPASS.Location = new System.Drawing.Point(380, 167);
            this.TXTPASS.Name = "TXTPASS";
            this.TXTPASS.Size = new System.Drawing.Size(204, 38);
            this.TXTPASS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "USERNAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "PASSWORD";
            // 
            // BTN_LOGIN
            // 
            this.BTN_LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LOGIN.Location = new System.Drawing.Point(85, 277);
            this.BTN_LOGIN.Name = "BTN_LOGIN";
            this.BTN_LOGIN.Size = new System.Drawing.Size(147, 46);
            this.BTN_LOGIN.TabIndex = 4;
            this.BTN_LOGIN.Text = "LOGIN";
            this.BTN_LOGIN.UseVisualStyleBackColor = true;
            // 
            // BTN_CANCLE
            // 
            this.BTN_CANCLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CANCLE.Location = new System.Drawing.Point(505, 277);
            this.BTN_CANCLE.Name = "BTN_CANCLE";
            this.BTN_CANCLE.Size = new System.Drawing.Size(166, 46);
            this.BTN_CANCLE.TabIndex = 5;
            this.BTN_CANCLE.Text = "CANCEL";
            this.BTN_CANCLE.UseVisualStyleBackColor = true;
            this.BTN_CANCLE.Click += new System.EventHandler(this.BTN_CANCLE_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.dona_orient;
            this.pictureBox1.Location = new System.Drawing.Point(658, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_CANCLE);
            this.Controls.Add(this.BTN_LOGIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTPASS);
            this.Controls.Add(this.TXTUSER);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTUSER;
        private System.Windows.Forms.TextBox TXTPASS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_LOGIN;
        private System.Windows.Forms.Button BTN_CANCLE;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}