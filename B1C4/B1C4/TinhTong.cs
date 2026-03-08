using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B1C4
{
    public partial class TinhTong : Form
    {
        public TinhTong()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void TinhTong_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtA, "Nhập số nguyên");
            toolTip1.SetToolTip(txtB, "Nhập số nguyên");
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "" || txtB.Text == "")
            {
                MessageBox.Show("Phải nhập đủ a và b");
                return;
            }

            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);

            int tong = 0;

            if (a < b)
                for (int i = a; i <= b; i++)
                    tong += i;
            else
                for (int i = b; i <= a; i++)
                    tong += i;

            lblKQ.Text = "Tổng các số từ " + a + " đến " + b + " = " + tong;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();

            lblKQ.Text = "";

            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
