using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BaskiCiltHesaplama.Views;
using BaskiCiltHesaplama.Models;

namespace BaskiCiltHesaplama.Presenters
{
    class BaskiCiltPresenter
    {
        IBaskiCilt baskiCiltView;

        public BaskiCiltPresenter (IBaskiCilt view)
	    {
            baskiCiltView = view;
	    }

        public void pMetod () 
        {
            Malzemeler Cilt = new Malzemeler();

            Cilt.Uzunluk = double.Parse(baskiCiltView.UzunlukVerisi);
            Cilt.Genislik = double.Parse(baskiCiltView.GenislikVerisi);
            baskiCiltView.SonucAlani = Cilt.Hesapla().ToString();
        }
    }
}
