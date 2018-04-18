
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

namespace BaskiCiltHesaplama
{
    public partial class Form1 : Form, IBaskiCilt
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string UzunlukVerisi { get => return GelenUzunluk; set => GelenUzunluk = value; }
        public string GenislikVerisi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MalzemeVerisi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SonucAlani { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
