using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSachCSharph.Models
{
    public class TheloaiModel
    {
        public string idtheloai { get; set; }
        public string tentheloai { get;set; }

        public TheloaiModel(string Matheloai, string Tentheloai)
        {
            this.idtheloai = Matheloai;
            this.tentheloai = Tentheloai;
        }

    }
}
