namespace Winอุณภูมิ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butomแปลง = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boxc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxf = new System.Windows.Forms.TextBox();
            this.botton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butomแปลง
            // 
            this.butomแปลง.Location = new System.Drawing.Point(212, 12);
            this.butomแปลง.Name = "butomแปลง";
            this.butomแปลง.Size = new System.Drawing.Size(75, 23);
            this.butomแปลง.TabIndex = 0;
            this.butomแปลง.Text = "เเปลง";
            this.butomแปลง.UseVisualStyleBackColor = true;
            this.butomแปลง.Click += new System.EventHandler(this.butomแปลง_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ฟาเรนไฮ";
            // 
            // boxc
            // 
            this.boxc.Location = new System.Drawing.Point(106, 12);
            this.boxc.Name = "boxc";
            this.boxc.Size = new System.Drawing.Size(100, 23);
            this.boxc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "เซลเซียส";
            // 
            // boxf
            // 
            this.boxf.Location = new System.Drawing.Point(107, 41);
            this.boxf.Name = "boxf";
            this.boxf.Size = new System.Drawing.Size(100, 23);
            this.boxf.TabIndex = 4;
            // 
            // botton2
            // 
            this.botton2.Location = new System.Drawing.Point(213, 40);
            this.botton2.Name = "botton2";
            this.botton2.Size = new System.Drawing.Size(75, 23);
            this.botton2.TabIndex = 5;
            this.botton2.Text = "แปลง";
            this.botton2.UseVisualStyleBackColor = true;
            this.botton2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 111);
            this.Controls.Add(this.botton2);
            this.Controls.Add(this.boxf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butomแปลง);
            this.Name = "Form1";
            this.Text = "แปลงอุณภูมิ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button butomแปลง;
        private Label label1;
        private TextBox boxc;
        private Label label2;
        private TextBox boxf;
        private Button botton2;
    }
}