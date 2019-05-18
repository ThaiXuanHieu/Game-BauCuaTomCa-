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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cb_DatCuoc_Ca_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SoTien = Convert.ToInt32(lblSoTien.Text);
            int DatCuoc = Convert.ToInt32(cb_DatCuoc_Ca.GetItemText(cb_DatCuoc_Ca.SelectedItem));
            lblSoTien.Text = (SoTien - DatCuoc).ToString();
        }

        
        private void cb_DatCuoc_Ga_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SoTien = Convert.ToInt32(lblSoTien.Text);
            int DatCuoc = Convert.ToInt32(cb_DatCuoc_Ga.GetItemText(cb_DatCuoc_Ga.SelectedItem));
            lblSoTien.Text = (SoTien - DatCuoc).ToString();
        }

        private void cb_DatCuoc_Cua_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SoTien = Convert.ToInt32(lblSoTien.Text);
            int DatCuoc = Convert.ToInt32(cb_DatCuoc_Cua.GetItemText(cb_DatCuoc_Cua.SelectedItem));
            lblSoTien.Text = (SoTien - DatCuoc).ToString();
        }

        private void cb_DatCuoc_Nai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SoTien = Convert.ToInt32(lblSoTien.Text);
            int DatCuoc = Convert.ToInt32(cb_DatCuoc_Nai.GetItemText(cb_DatCuoc_Nai.SelectedItem));
            lblSoTien.Text = (SoTien - DatCuoc).ToString();
        }

        private void cb_DatCuoc_Tom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SoTien = Convert.ToInt32(lblSoTien.Text);
            int DatCuoc = Convert.ToInt32(cb_DatCuoc_Tom.GetItemText(cb_DatCuoc_Tom.SelectedItem));
            lblSoTien.Text = (SoTien - DatCuoc).ToString();
        }

        private void cb_DatCuoc_Bau_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SoTien = Convert.ToInt32(lblSoTien.Text);
            int DatCuoc = Convert.ToInt32(cb_DatCuoc_Bau.GetItemText(cb_DatCuoc_Bau.SelectedItem));
            lblSoTien.Text = (SoTien - DatCuoc).ToString();
        }


        private void btnChoi_Click(object sender, EventArgs e)
        {
            btnChoi.Enabled = false;
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
                    //lblSoTien.Text = (Convert.ToInt32(lblSoTien.Text) + (Convert.ToInt32(lblSoTienThuong.Text))).ToString();
                    break;
                case 2:
                    pic_KetQua1.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_ga;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Ga.GetItemText(cb_DatCuoc_Ga.SelectedItem))).ToString();
                    //lblSoTien.Text = (Convert.ToInt32(lblSoTien.Text) + (Convert.ToInt32(lblSoTienThuong.Text))).ToString();
                    break;
                case 3:
                    pic_KetQua1.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_cua;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Cua.GetItemText(cb_DatCuoc_Cua.SelectedItem))).ToString();
                    //lblSoTien.Text = (Convert.ToInt32(lblSoTien.Text) + (Convert.ToInt32(lblSoTienThuong.Text))).ToString();
                    break;
                case 4:
                    pic_KetQua1.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_nai;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Nai.GetItemText(cb_DatCuoc_Nai.SelectedItem))).ToString();
                    //lblSoTien.Text = (Convert.ToInt32(lblSoTien.Text) + (Convert.ToInt32(lblSoTienThuong.Text))).ToString();
                    break;
                case 5:
                    pic_KetQua1.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_tom;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Tom.GetItemText(cb_DatCuoc_Tom.SelectedItem))).ToString();
                    //lblSoTien.Text = (Convert.ToInt32(lblSoTien.Text) + (Convert.ToInt32(lblSoTienThuong.Text))).ToString();
                    break;
                case 6:
                    pic_KetQua1.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_bau;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Bau.GetItemText(cb_DatCuoc_Bau.SelectedItem))).ToString();
                    //lblSoTien.Text = (Convert.ToInt32(lblSoTien.Text) + (Convert.ToInt32(lblSoTienThuong.Text))).ToString();
                    break;
            }

            switch (ketqua2)
            {
                case 1:
                    pic_KetQua2.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_ca;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Ca.GetItemText(cb_DatCuoc_Ca.SelectedItem))).ToString();
                    //lblSoTien.Text = (Convert.ToInt32(lblSoTien.Text) + (Convert.ToInt32(lblSoTienThuong.Text))).ToString();
                    break;
                case 2:
                    pic_KetQua2.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_ga;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Ga.GetItemText(cb_DatCuoc_Ga.SelectedItem))).ToString();
                    //lblSoTien.Text = (Convert.ToInt32(lblSoTien.Text) + (Convert.ToInt32(lblSoTienThuong.Text))).ToString();
                    break;
                case 3:
                    pic_KetQua2.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_cua;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Cua.GetItemText(cb_DatCuoc_Cua.SelectedItem))).ToString();
                    //lblSoTien.Text = (Convert.ToInt32(lblSoTien.Text) + (Convert.ToInt32(lblSoTienThuong.Text))).ToString();
                    break;
                case 4:
                    pic_KetQua2.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_nai;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Nai.GetItemText(cb_DatCuoc_Nai.SelectedItem))).ToString();
                    //lblSoTien.Text = (Convert.ToInt32(lblSoTien.Text) + (Convert.ToInt32(lblSoTienThuong.Text))).ToString();
                    break;
                case 5:
                    pic_KetQua2.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_tom;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Tom.GetItemText(cb_DatCuoc_Tom.SelectedItem))).ToString();
                    //lblSoTien.Text = (Convert.ToInt32(lblSoTien.Text) + (Convert.ToInt32(lblSoTienThuong.Text))).ToString();
                    break;
                case 6:
                    pic_KetQua2.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_bau;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Bau.GetItemText(cb_DatCuoc_Bau.SelectedItem))).ToString();
                    //lblSoTien.Text = (Convert.ToInt32(lblSoTien.Text) + (Convert.ToInt32(lblSoTienThuong.Text))).ToString();
                    break;
            }

            switch (ketqua3)
            {
                case 1:
                    pic_KetQua3.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_ca;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Ca.GetItemText(cb_DatCuoc_Ca.SelectedItem))).ToString();
                    //lblSoTien.Text = (Convert.ToInt32(lblSoTien.Text) + (Convert.ToInt32(lblSoTienThuong.Text))).ToString();
                    break;
                case 2:
                    pic_KetQua3.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_ga;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Ga.GetItemText(cb_DatCuoc_Ga.SelectedItem))).ToString();
                    //lblSoTien.Text = (Convert.ToInt32(lblSoTien.Text) + (Convert.ToInt32(lblSoTienThuong.Text))).ToString();
                    break;
                case 3:
                    pic_KetQua3.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_cua;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Cua.GetItemText(cb_DatCuoc_Cua.SelectedItem))).ToString();
                    //lblSoTien.Text = (Convert.ToInt32(lblSoTien.Text) + (Convert.ToInt32(lblSoTienThuong.Text))).ToString();
                    break;
                case 4:
                    pic_KetQua3.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_nai;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Nai.GetItemText(cb_DatCuoc_Nai.SelectedItem))).ToString();
                    //lblSoTien.Text = (Convert.ToInt32(lblSoTien.Text) + (Convert.ToInt32(lblSoTienThuong.Text))).ToString();
                    break;
                case 5:
                    pic_KetQua3.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_tom;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Tom.GetItemText(cb_DatCuoc_Tom.SelectedItem))).ToString();
                    //lblSoTien.Text = (Convert.ToInt32(lblSoTien.Text) + (Convert.ToInt32(lblSoTienThuong.Text))).ToString();
                    break;
                case 6:
                    pic_KetQua3.Image = global::Game_BauCuaTomCa.Properties.Resources.icon_bau;
                    lblSoTienThuong.Text = (Convert.ToInt32(lblSoTienThuong.Text) + Convert.ToInt32(cb_DatCuoc_Bau.GetItemText(cb_DatCuoc_Bau.SelectedItem))).ToString();
                    //lblSoTien.Text = (Convert.ToInt32(lblSoTien.Text) + (Convert.ToInt32(lblSoTienThuong.Text))).ToString();
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
            btnChoi.Enabled = true;
            reset();
        }
    }

}
