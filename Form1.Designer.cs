namespace ChuanHoaThoiGian
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputHour = new System.Windows.Forms.TextBox();
            this.inputMinute = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputSecond = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.outputTime = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F);
            this.label1.Location = new System.Drawing.Point(226, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập giờ:";
            // 
            // inputHour
            // 
            this.inputHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inputHour.Location = new System.Drawing.Point(381, 75);
            this.inputHour.Name = "inputHour";
            this.inputHour.Size = new System.Drawing.Size(153, 36);
            this.inputHour.TabIndex = 1;
            this.inputHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputMinute
            // 
            this.inputMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inputMinute.Location = new System.Drawing.Point(381, 136);
            this.inputMinute.Name = "inputMinute";
            this.inputMinute.Size = new System.Drawing.Size(153, 36);
            this.inputMinute.TabIndex = 3;
            this.inputMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F);
            this.label2.Location = new System.Drawing.Point(226, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập phút:";
            // 
            // inputSecond
            // 
            this.inputSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inputSecond.Location = new System.Drawing.Point(381, 196);
            this.inputSecond.Name = "inputSecond";
            this.inputSecond.Size = new System.Drawing.Size(153, 36);
            this.inputSecond.TabIndex = 5;
            this.inputSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F);
            this.label3.Location = new System.Drawing.Point(226, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập giây:";
            // 
            // outputTime
            // 
            this.outputTime.BackColor = System.Drawing.SystemColors.ControlLight;
            this.outputTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputTime.Font = new System.Drawing.Font("Arial", 15F);
            this.outputTime.Location = new System.Drawing.Point(359, 322);
            this.outputTime.Name = "outputTime";
            this.outputTime.Size = new System.Drawing.Size(213, 42);
            this.outputTime.TabIndex = 6;
            this.outputTime.Text = " ";
            this.outputTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showButton
            // 
            this.showButton.AutoSize = true;
            this.showButton.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Location = new System.Drawing.Point(231, 329);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(108, 38);
            this.showButton.TabIndex = 7;
            this.showButton.Text = "Hiển thị";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.outputTime);
            this.Controls.Add(this.inputSecond);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputMinute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputHour);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chuẩn hóa thời gian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputHour;
        private System.Windows.Forms.TextBox inputMinute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputSecond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label outputTime;
        private System.Windows.Forms.Button showButton;
    }
}

