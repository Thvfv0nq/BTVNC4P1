namespace B1C4
{
    partial class TinhTong
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
            components = new System.ComponentModel.Container();
            lable1 = new Label();
            lable2 = new Label();
            lblKQ = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            btnTong = new Button();
            btnLamLai = new Button();
            btnThoat = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // lable1
            // 
            lable1.AutoSize = true;
            lable1.Location = new Point(61, 39);
            lable1.Name = "lable1";
            lable1.Size = new Size(86, 25);
            lable1.TabIndex = 0;
            lable1.Text = "Nhập a =";
            // 
            // lable2
            // 
            lable2.AutoSize = true;
            lable2.Location = new Point(61, 133);
            lable2.Name = "lable2";
            lable2.Size = new Size(93, 25);
            lable2.TabIndex = 1;
            lable2.Text = "Nhập b = ";
            lable2.Click += label2_Click;
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Location = new Point(61, 228);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(276, 25);
            lblKQ.TabIndex = 2;
            lblKQ.Text = "Tổng các số từ 1 đến 100 = 5050";
            lblKQ.Click += label3_Click;
            // 
            // txtA
            // 
            txtA.Location = new Point(169, 39);
            txtA.Name = "txtA";
            txtA.Size = new Size(150, 31);
            txtA.TabIndex = 3;
            txtA.KeyPress += txtA_KeyPress;
            // 
            // txtB
            // 
            txtB.Location = new Point(169, 133);
            txtB.Name = "txtB";
            txtB.Size = new Size(150, 31);
            txtB.TabIndex = 4;
            txtB.KeyPress += txtB_KeyPress;
            // 
            // btnTong
            // 
            btnTong.Location = new Point(61, 356);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(112, 34);
            btnTong.TabIndex = 5;
            btnTong.Text = "Tổng";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // btnLamLai
            // 
            btnLamLai.Location = new Point(311, 356);
            btnLamLai.Name = "btnLamLai";
            btnLamLai.Size = new Size(112, 34);
            btnLamLai.TabIndex = 6;
            btnLamLai.Text = "Làm lại";
            btnLamLai.UseVisualStyleBackColor = true;
            btnLamLai.Click += btnLamLai_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(580, 356);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // TinhTong
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnLamLai);
            Controls.Add(btnTong);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblKQ);
            Controls.Add(lable2);
            Controls.Add(lable1);
            Name = "TinhTong";
            Text = "TinhTong";
            Load += TinhTong_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lable1;
        private Label lable2;
        private Label lblKQ;
        private TextBox txtA;
        private TextBox txtB;
        private Button btnTong;
        private Button btnLamLai;
        private Button btnThoat;
        private ToolTip toolTip1;
    }
}