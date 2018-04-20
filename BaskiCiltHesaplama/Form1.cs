
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BaskiCiltHesaplama.Views;
using BaskiCiltHesaplama.Presenters;

namespace BaskiCiltHesaplama
{
    public partial class Form1 : Form, IBaskiCilt
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string UzunlukVerisi { get => GelenUzunluk.Text; set => GelenUzunluk.Text = value; }
        public string GenislikVerisi { get => GelenUzunluk.Text; set => GelenUzunluk.Text = value; }
        public string SonucAlani { get => GelenSonuc.Text; set => GelenSonuc.Text = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            BaskiCiltPresenter presenter = new BaskiCiltPresenter(this);
            presenter.pMetod();
        }
    }
}
