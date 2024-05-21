using DAL.Interface_DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement_DAL
{
    public class DAL_Order : I_DAL_Order
    {
        DatabaseKaraoke DB = new DatabaseKaraoke();
        public List<tblDichVu> LayDuLieu_BangDichVu()
        {
            return DB.tblDichVus.ToList();
        }

        public List<tblLoaiDichVu> LayDuLieu_BangLoaiDichVu()
        {
            return DB.tblLoaiDichVus.ToList();
        }

        public List<tblMatHang> LayDuLieu_BangMatHang()
        {
            return DB.tblMatHangs.ToList();
        }

        public void Create_GoiDichVu(tblGoiDichVu tblGoiDichVu)
        {
            DB.tblGoiDichVus.Add(tblGoiDichVu);
            DB.SaveChanges();
        }
        public void Create_GoiMatHang(tblGoiMatHang tblGoiMatHang)
        {
            DB.tblGoiMatHangs.Add(tblGoiMatHang);
            DB.SaveChanges();
        }

        public List<tblGoiMatHang> LayDuLieu_BangGoiMatHang()
        {
            return DB.tblGoiMatHangs.ToList();
        }

        public List<tblLoaiHang> LayDuLieu_BangLoaiHang()
        {
            return DB.tblLoaiHangs.ToList();
        }

        public void Update_GoiMatHang(tblGoiMatHang tblGoiMatHang)
        {
            using (DatabaseKaraoke _DB = new DatabaseKaraoke())
            {
                _DB.sp_UpdateOrderItemQuantity(tblGoiMatHang.MaPhongDat, tblGoiMatHang.MaMatHang, tblGoiMatHang.SoLuong);
                _DB.SaveChanges();
            }

        }

        public List<tblGoiDichVu> LayDuLieu_BangGoiDichVu()
        {
            return new DatabaseKaraoke().tblGoiDichVus.ToList();
        }
    }
}
