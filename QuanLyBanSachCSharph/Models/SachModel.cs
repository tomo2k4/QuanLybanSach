using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSachCSharph.Models
{
    public class SachModel
    {
        public string idsach { get; set; }
        public string tensach { get; set; }
        public string idtacgia { get; set; }
        public string tentacgia {  get; set; }
        public string idtheloai {  get; set; }
        public string tentheloai {  get; set; }
        public string nhaxuatban { get; set; }
        public string giasach {  get; set; }
        public string soluong {  get; set; }
        public string ngaynhan {  get; set; }
        public byte[] anhsach {  get; set; }

        public SachModel()
        {
        }

        public SachModel(string idsach, string tensach, string idtacgia, string tentacgia, string idtheloai,
                 string tentheloai, string soluong, string giasach, string nhaxuatban,
                 string ngaynhan, byte[] anhsach)
        {
            this.idsach = idsach;
            this.tensach = tensach;
            this.idtacgia = idtacgia;
            this.tentacgia = tentacgia;
            this.idtheloai = idtheloai;
            this.tentheloai = tentheloai;
            this.soluong = soluong;
            this.giasach = giasach;
            this.nhaxuatban = nhaxuatban;
            this.ngaynhan = ngaynhan;
            this.anhsach = anhsach;
        }




    }
}
