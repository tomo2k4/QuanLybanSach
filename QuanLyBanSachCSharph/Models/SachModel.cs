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

        public SachModel(string mas, string tensach, string matg, string tacgia, string matl,
            string theloai, string soLuong, string giasach, string nhaxb, string ngaynhan, byte[] anhSach)
        { 
            this.idsach = mas;
            this.tensach = tensach;
            this.idtacgia = matg;
            this.tentacgia = tacgia;
            this.idtheloai = matl;
            this.tentheloai = theloai;  
            this.soluong = soLuong;
            this.giasach = giasach;
            this.nhaxuatban = nhaxb;
            this.ngaynhan = ngaynhan;
            this.anhsach = anhSach;
        }


    }
}
