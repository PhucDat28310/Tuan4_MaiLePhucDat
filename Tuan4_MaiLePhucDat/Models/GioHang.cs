using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tuan4_MaiLePhucDat.Models
{
    public class GioHang
    {
        MyDataDataContext data = new MyDataDataContext();
        public int maSach { get; set; }

        [Display(Name = "Tên sách")]
        public string tenSach { get; set; }

        [Display(Name = "Ảnh bìa")]
        public string hinh { get; set; }

        [Display(Name = "Giá bán")]
        public Double giaBan { get; set; }

        [Display(Name = "soLuong")]
        public int soLuong { get; set; }

        [Display(Name = "Thành tiền")]
        public Double thanhTien
        {
            get { return soLuong * giaBan; }
        }

        public GioHang(int id)
        {
            maSach = id;
            Sach sach = data.Saches.Single(n => n.masach == maSach);
            tenSach = sach.tensach;
            hinh = sach.hinh;
            giaBan = double.Parse(sach.giaban.ToString());
            soLuong = 1;
        }
    }
}