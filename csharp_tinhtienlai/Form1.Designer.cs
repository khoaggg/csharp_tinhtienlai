namespace csharp_tinhtienlai
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
            this.btnTinh = new System.Windows.Forms.Button();
            this.lblsotien = new System.Windows.Forms.Label();
            this.txtsotien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbllaisuat = new System.Windows.Forms.Label();
            this.txtlaisuat = new System.Windows.Forms.TextBox();
            this.txtnamgui = new System.Windows.Forms.TextBox();
            this.lbx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(428, 328);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 0;
            this.btnTinh.Text = "tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lblsotien
            // 
            this.lblsotien.AutoSize = true;
            this.lblsotien.Location = new System.Drawing.Point(315, 152);
            this.lblsotien.Name = "lblsotien";
            this.lblsotien.Size = new System.Drawing.Size(38, 13);
            this.lblsotien.TabIndex = 1;
            this.lblsotien.Text = "số tiền";
            // 
            // txtsotien
            // 
            this.txtsotien.Location = new System.Drawing.Point(403, 152);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Size = new System.Drawing.Size(100, 20);
            this.txtsotien.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "số năm gửi ";
            // 
            // lbllaisuat
            // 
            this.lbllaisuat.AutoSize = true;
            this.lbllaisuat.Location = new System.Drawing.Point(315, 208);
            this.lbllaisuat.Name = "lbllaisuat";
            this.lbllaisuat.Size = new System.Drawing.Size(47, 13);
            this.lbllaisuat.TabIndex = 3;
            this.lbllaisuat.Text = "Lãi suất ";
            // 
            // txtlaisuat
            // 
            this.txtlaisuat.Location = new System.Drawing.Point(403, 208);
            this.txtlaisuat.Name = "txtlaisuat";
            this.txtlaisuat.Size = new System.Drawing.Size(100, 20);
            this.txtlaisuat.TabIndex = 4;
            // 
            // txtnamgui
            // 
            this.txtnamgui.Location = new System.Drawing.Point(403, 263);
            this.txtnamgui.Name = "txtnamgui";
            this.txtnamgui.Size = new System.Drawing.Size(100, 20);
            this.txtnamgui.TabIndex = 5;
            // 
            // lbx
            // 
            this.lbx.FormattingEnabled = true;
            this.lbx.Location = new System.Drawing.Point(180, 402);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(372, 160);
            this.lbx.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 665);
            this.Controls.Add(this.lbx);
            this.Controls.Add(this.txtnamgui);
            this.Controls.Add(this.txtlaisuat);
            this.Controls.Add(this.lbllaisuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsotien);
            this.Controls.Add(this.lblsotien);
            this.Controls.Add(this.btnTinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label lblsotien;
        private System.Windows.Forms.TextBox txtsotien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbllaisuat;
        private System.Windows.Forms.TextBox txtlaisuat;
        private System.Windows.Forms.TextBox txtnamgui;
        private System.Windows.Forms.ListBox lbx;
    }
}

