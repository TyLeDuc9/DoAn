using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TyNhanLongKhoi_DAL;

namespace TyNhanLongKhoi_BUS
{
    public class NhanVienLibrary
    {
        public List<NhanVien> GetAll()
        {
            QLTVContextDB context = new QLTVContextDB();
            return context.NhanViens.ToList();
        }
        public NhanVien FindById(string maNhanVien)
        {
            QLTVContextDB context = new QLTVContextDB();
            return context.NhanViens.FirstOrDefault(p => p.MaNhanVien == maNhanVien);
        }
        public void InsertOrUpdate(NhanVien nhanVien)
        {
            QLTVContextDB context = new QLTVContextDB();
            NhanVien dbUpdate = context.NhanViens.FirstOrDefault(p => p.MaNhanVien == nhanVien.MaNhanVien);
            if (dbUpdate != null)
            {
                dbUpdate.MaNhanVien = nhanVien.MaNhanVien;

                //dbUpdate.NgaySinh = nhanVien.NgaySinh.Value;
                dbUpdate.HoTen = nhanVien.HoTen;
                dbUpdate.Email = nhanVien.Email;
                dbUpdate.SDT = nhanVien.SDT;
                dbUpdate.GioiTinh = nhanVien.GioiTinh;
                context.SaveChanges();
            }
            else
            {
                context.NhanViens.Add(nhanVien);
                context.SaveChanges();
            }
        }

        public void Delete(NhanVien nhanVien)
        {
            if (nhanVien.MaNhanVien is null || nhanVien.MaNhanVien == "")
            {
                return;
            }
            else
            {
                QLTVContextDB context = new QLTVContextDB();
                NhanVien delete = context.NhanViens.FirstOrDefault(p => p.MaNhanVien == nhanVien.MaNhanVien);
                if (delete != null)
                {
                    context.NhanViens.Remove(delete);
                    context.SaveChanges();
                }
            }
        }
    }
}
