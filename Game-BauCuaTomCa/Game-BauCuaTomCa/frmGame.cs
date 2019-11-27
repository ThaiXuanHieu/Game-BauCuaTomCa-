using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_BauCuaTomCa
{
    public partial class frmGame : Form
    {
        bool locked = false;

        public frmGame()
        {
            InitializeComponent();
        }

        private void cb_DatCuoc_Ca_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SoTien = Convert.ToInt32(lblSoTien.Text);
            int DatCuoc = Convert.ToInt32(cb_DatCuoc_Ca.GetItemText(cb_DatCuoc_Ca.SelectedItem));
            lblSoTien.Text = (SoTien - DatCuoc).ToString();
            cb_DatCuoc_Ca.Enabled = false;
        }

        
        private void cb_DatCuoc_Ga_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SoTien = Convert.ToInt32(lblSoTien.Text);
            int DatCuoc = Convert.ToInt32(cb_DatCuoc_Ga.GetItemText(cb_DatCuoc_Ga.SelectedItem));
            lblSoTien.Text = (SoTien - DatCuoc).ToString();
            cb_DatCuoc_Ga.Enabled = false;
        }

        private void cb_DatCuoc_Cua_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SoTien = Convert.ToInt32(lblSoTien.Text);
            int DatCuoc = Convert.ToInt32(cb_DatCuoc_Cua.GetItemText(cb_DatCuoc_Cua.SelectedItem));
            lblSoTien.Text = (SoTien - DatCuoc).ToString();
            cb_DatCuoc_Cua.Enabled = false;
        }

        private void cb_DatCuoc_Nai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SoTien = Convert.ToInt32(lblSoTien.Text);
            int DatCuoc = Convert.ToInt32(cb_DatCuoc_Nai.GetItemText(cb_DatCuoc_Nai.SelectedItem));
            lblSoTien.Text = (SoTien - DatCuoc).ToString();
            cb_DatCuoc_Nai.Enabled = false;
        }

        private void cb_DatCuoc_Tom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SoTien = Convert.ToInt32(lblSoTien.Text);
            int DatCuoc = Convert.ToInt32(cb_DatCuoc_Tom.GetItemText(cb_DatCuoc_Tom.SelectedItem));
            lblSoTien.Text = (SoTien - DatCuoc).ToString();
            cb_DatCuoc_Tom.Enabled = false;
        }

        private void cb_DatCuoc_Bau_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SoTien = Convert.ToInt32(lblSoTien.Text);
            int DatCuoc = Convert.ToInt32(cb_DatCuoc_Bau.GetItemText(cb_DatCuoc_Bau.SelectedItem));
            lblSoTien.Text = (SoTien - DatCuoc).ToString();
            cb_DatCuoc_Bau.Enabled = false;
        }


        private void btnChoi_Click(object sender, EventArgs e)
        {
            btnChoi.Enabled = false;
            btnChoiTiep.Enabled = true;
            int ketqua1, ketqua2, ketqua3;
            Random rand = new Random();
            ketqua1 = rand.Next(1, 6);
            ketqua2 = rand.Next(1, 6);
            ketqua3 = rand.Next(1, 6);

            switch (ketqua1)
            {
                case 1:
                    pic_KetQua1.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_ca;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Ca.GetItemText(cb_DatCuoc_Ca.SelectedItem))).ToString();
                    break;
                case 2:
                    pic_KetQua1.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_ga;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Ga.GetItemText(cb_DatCuoc_Ga.SelectedItem))).ToString();
                    break;
                case 3:
                    pic_KetQua1.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_cua;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Cua.GetItemText(cb_DatCuoc_Cua.SelectedItem))).ToString();
                    break;
                case 4:
                    pic_KetQua1.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_nai;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Nai.GetItemText(cb_DatCuoc_Nai.SelectedItem))).ToString();
                    break;
                case 5:
                    pic_KetQua1.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_tom;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Tom.GetItemText(cb_DatCuoc_Tom.SelectedItem))).ToString();
                    break;
                case 6:
                    pic_KetQua1.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_bau;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Bau.GetItemText(cb_DatCuoc_Bau.SelectedItem))).ToString();
                    break;
            }

            switch (ketqua2)
            {
                case 1:
                    pic_KetQua2.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_ca;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Ca.GetItemText(cb_DatCuoc_Ca.SelectedItem))).ToString();
                    break;
                case 2:
                    pic_KetQua2.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_ga;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Ga.GetItemText(cb_DatCuoc_Ga.SelectedItem))).ToString();
                    break;
                case 3:
                    pic_KetQua2.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_cua;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Cua.GetItemText(cb_DatCuoc_Cua.SelectedItem))).ToString();
                    break;
                case 4:
                    pic_KetQua2.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_nai;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Nai.GetItemText(cb_DatCuoc_Nai.SelectedItem))).ToString();
                    break;
                case 5:
                    pic_KetQua2.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_tom;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Tom.GetItemText(cb_DatCuoc_Tom.SelectedItem))).ToString();
                    break;
                case 6:
                    pic_KetQua2.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_bau;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Bau.GetItemText(cb_DatCuoc_Bau.SelectedItem))).ToString();
                    break;
            }

            switch (ketqua3)
            {
                case 1:
                    pic_KetQua3.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_ca;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Ca.GetItemText(cb_DatCuoc_Ca.SelectedItem))).ToString();
                    break;
                case 2:
                    pic_KetQua3.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_ga;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Ga.GetItemText(cb_DatCuoc_Ga.SelectedItem))).ToString();
                    break;
                case 3:
                    pic_KetQua3.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_cua;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Cua.GetItemText(cb_DatCuoc_Cua.SelectedItem))).ToString();
                    break;
                case 4:
                    pic_KetQua3.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_nai;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Nai.GetItemText(cb_DatCuoc_Nai.SelectedItem))).ToString();
                    break;
                case 5:
                    pic_KetQua3.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_tom;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Tom.GetItemText(cb_DatCuoc_Tom.SelectedItem))).ToString();
                    break;
                case 6:
                    pic_KetQua3.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_bau;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Bau.GetItemText(cb_DatCuoc_Bau.SelectedItem))).ToString();
                    break;
            }

            lblSoTien.Text = (Convert.ToInt32(lblSoTien.Text) + (Convert.ToInt32(lblSoTienThuong.Text))).ToString();
        }

        void reset()
        {
            lblSoTienThuong.Text = "0";
            cb_DatCuoc_Ca.Text = "0";
            cb_DatCuoc_Ga.Text = "0";
            cb_DatCuoc_Cua.Text = "0";
            cb_DatCuoc_Nai.Text = "0";
            cb_DatCuoc_Tom.Text = "0";
            cb_DatCuoc_Bau.Text = "0";

            
        }

        private void btnChoiTiep_Click(object sender, EventArgs e)
        {
            btnChoiTiep.Enabled = false;
            btnChoi.Enabled = true;
            reset();
            checkLocked(true);
        }


        private void checkLocked(bool locked)
        {
            cb_DatCuoc_Ca.Enabled = true;
            cb_DatCuoc_Ga.Enabled = true;
            cb_DatCuoc_Cua.Enabled = true;
            cb_DatCuoc_Nai.Enabled = true;
            cb_DatCuoc_Tom.Enabled = true;
            cb_DatCuoc_Bau.Enabled = true;
        }

        private void frmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("BẠN CHẮC CHẮN ĐÓNG ỨNG DỤNG KHÔNG?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            Application.ExitThread();
        }
    }

}
