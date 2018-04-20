using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaskiCiltHesaplama.Views
{
    public interface IBaskiCilt
    {
        string UzunlukVerisi { get; set; }
        string GenislikVerisi { get; set; }
        //string MalzemeVerisi { get; set; }
        string SonucAlani { get; set; }
    }
}
