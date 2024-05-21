using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface_DAL
{
    public interface I_DAL_Order
    {

        List<tblDichVu> LayDuLieu_BangDichVu();
        List<tblLoaiDichVu> LayDuLieu_BangLoaiDichVu();
        List<tblMatHang> LayDuLieu_BangMatHang();
        List<tblLoaiHang> LayDuLieu_BangLoaiHang();
        List<tblGoiMatHang> LayDuLieu_BangGoiMatHang();
        List<tblGoiDichVu> LayDuLieu_BangGoiDichVu();

        void Update_GoiMatHang(tblGoiMatHang tblGoiMatHang);
        void Create_GoiDichVu(tblGoiDichVu tblGoiDichVu);
        void Create_GoiMatHang(tblGoiMatHang tblGoiMatHang);


    }
}
