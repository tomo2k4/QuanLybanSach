using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSachCSharph.Models
{
    public class TacgiaModel
    {
        public string idtacgia { get; set; }
        public string tentg { get; set; }
        public string linhvuc { get; set; }
        public string Description { get; set; }

        public TacgiaModel() { }

        public TacgiaModel(string ma, string ten, string linhvuc, string mota)
        {
            idtacgia = ma;
            tentg = ten;
            linhvuc = linhvuc;
            Description = mota;

        }
    }
}
