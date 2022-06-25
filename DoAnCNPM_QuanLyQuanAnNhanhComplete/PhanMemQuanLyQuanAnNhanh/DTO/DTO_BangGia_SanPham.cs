using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BangGia_SanPham: INotifyPropertyChanged
    {
        public string MaSP { get; set; }
        public string MaNhomSP { get; set; }
        public string TenSP { get; set; }
        //public Image Hinh { get; set; }
        public Image Hinh { get; set; }
        public byte[] HinhInsert { get; set; }

        public bool TrangThai { get; set; }
        public int MaBangGia { get; set; }
        public string MaSize { get; set; }
        public double Gia { get; set; }
        public DateTime NgayCapNhat { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        //public DTO_BangGia_SanPham(string MaSP,string TenSP, string url, bool TrangThai,int MaBangGia,string MaSize,double Gia)
        //{
        //    Hinh = ResourceImageHelper.CreateImageFromResources("DevExpress.XtraEditors.Images.loading.gif", typeof(BackgroundImageLoader).Assembly);
        //    BackgroundImageLoader bg = new BackgroundImageLoader();
        //    bg.Load(url);
        //    bg.Loaded += (s, e) =>
        //    {
        //        Hinh = bg.Result;
        //        if (!(Hinh is Image)) Hinh = ResourceImageHelper.CreateImageFromResources("DevExpress.XtraEditors.Images.Error.png", typeof(BackgroundImageLoader).Assembly);
        //        PropertyChanged(this, new PropertyChangedEventArgs("Image"));
        //        bg.Dispose();
        //    };

        //    this.MaSP = MaSP;
        //    this.TenSP = TenSP;
        //    this.TrangThai = TrangThai;
        //    this.MaBangGia = MaBangGia;
        //    this.MaSize = MaSize;
        //    this.Gia = Gia;
        //}
    }
}
