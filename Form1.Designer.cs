namespace csharp_giaiptbac2
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
            this.lbla = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.btnketqua = new System.Windows.Forms.Button();
            this.grb = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.lbldt = new System.Windows.Forms.Label();
            this.lblkq = new System.Windows.Forms.Label();
            this.grb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(99, 98);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(42, 13);
            this.lbla.TabIndex = 1;
            this.lbla.Text = "Nhập a";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(99, 147);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(42, 13);
            this.lblb.TabIndex = 2;
            this.lblb.Text = "Nhập b";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(192, 91);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 3;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(192, 140);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 4;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(192, 186);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 20);
            this.txtc.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ỨNG DỤNG GIẢI PHƯƠNG TRÌNH BẬC 2";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(99, 193);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(42, 13);
            this.lblc.TabIndex = 6;
            this.lblc.Text = "Nhập c";
            // 
            // btnketqua
            // 
            this.btnketqua.Location = new System.Drawing.Point(300, 230);
            this.btnketqua.Name = "btnketqua";
            this.btnketqua.Size = new System.Drawing.Size(110, 23);
            this.btnketqua.TabIndex = 7;
            this.btnketqua.Text = "Giải phương trình";
            this.btnketqua.UseVisualStyleBackColor = true;
            this.btnketqua.Click += new System.EventHandler(this.btnketqua_Click);
            // 
            // grb
            // 
            this.grb.Controls.Add(this.lblkq);
            this.grb.Controls.Add(this.lbldt);
            this.grb.Location = new System.Drawing.Point(192, 287);
            this.grb.Name = "grb";
            this.grb.Size = new System.Drawing.Size(308, 100);
            this.grb.TabIndex = 8;
            this.grb.TabStop = false;
            this.grb.Text = "Kết Quả";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(338, 89);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(136, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(338, 140);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(136, 45);
            this.trackBar2.TabIndex = 10;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(338, 179);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(136, 45);
            this.trackBar3.TabIndex = 11;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // lbldt
            // 
            this.lbldt.AutoSize = true;
            this.lbldt.Location = new System.Drawing.Point(18, 28);
            this.lbldt.Name = "lbldt";
            this.lbldt.Size = new System.Drawing.Size(32, 13);
            this.lbldt.TabIndex = 0;
            this.lbldt.Text = "Delta";
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(18, 63);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(44, 13);
            this.lblkq.TabIndex = 1;
            this.lblkq.Text = "Kết quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.grb);
            this.Controls.Add(this.btnketqua);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grb.ResumeLayout(false);
            this.grb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Button btnketqua;
        private System.Windows.Forms.GroupBox grb;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.Label lbldt;
    }
}

