
namespace Playstation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_PS4 = new System.Windows.Forms.Button();
            this.btn_PS5 = new System.Windows.Forms.Button();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_PS4
            // 
            this.btn_PS4.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PS4.Location = new System.Drawing.Point(171, 395);
            this.btn_PS4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_PS4.Name = "btn_PS4";
            this.btn_PS4.Size = new System.Drawing.Size(237, 100);
            this.btn_PS4.TabIndex = 0;
            this.btn_PS4.Text = "PS4";
            this.btn_PS4.UseVisualStyleBackColor = true;
            this.btn_PS4.Click += new System.EventHandler(this.btn_PS4_Click);
            // 
            // btn_PS5
            // 
            this.btn_PS5.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PS5.Location = new System.Drawing.Point(665, 395);
            this.btn_PS5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_PS5.Name = "btn_PS5";
            this.btn_PS5.Size = new System.Drawing.Size(245, 97);
            this.btn_PS5.TabIndex = 1;
            this.btn_PS5.Text = "PS5";
            this.btn_PS5.UseVisualStyleBackColor = true;
            this.btn_PS5.Click += new System.EventHandler(this.btn_PS5_Click);
            // 
            // img1
            // 
            this.img1.Image = ((System.Drawing.Image)(resources.GetObject("img1.Image")));
            this.img1.Location = new System.Drawing.Point(607, 135);
            this.img1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(367, 209);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img1.TabIndex = 4;
            this.img1.TabStop = false;
            // 
            // img2
            // 
            this.img2.Image = ((System.Drawing.Image)(resources.GetObject("img2.Image")));
            this.img2.Location = new System.Drawing.Point(96, 135);
            this.img2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(367, 209);
            this.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img2.TabIndex = 5;
            this.img2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(333, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(421, 62);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "PLAYSTATION";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 90);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.btn_PS5);
            this.Controls.Add(this.btn_PS4);
            this.Controls.Add(this.img1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_PS4;
        private System.Windows.Forms.Button btn_PS5;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.PictureBox img2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

