using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TyNhanLongKhoi_DAL;

namespace TyNhanLongKhoi_BUS
{
    public class NXBLibrary
    {
        public List<NhaXB> GetAll()
        {
            QLTVContextDB context = new QLTVContextDB();
            return context.NhaXBs.ToList();
        }
        public NhaXB FindById(string maNXB)
        {
            QLTVContextDB context = new QLTVContextDB();
            return context.NhaXBs.FirstOrDefault(p => p.MaNXB == maNXB);
        }
        public void InsertOrUpdate(NhaXB nhaXB) 
        {
            QLTVContextDB context = new QLTVContextDB();
            NhaXB dbUpdate = context.NhaXBs.FirstOrDefault(p => p.MaNXB == nhaXB.MaNXB);
            if (dbUpdate != null)
            {
                dbUpdate.MaNXB = nhaXB.MaNXB;
                dbUpdate.TenNXB=nhaXB.TenNXB;
                dbUpdate.DiaChi=nhaXB.DiaChi;
                dbUpdate.Email =nhaXB.Email;
                dbUpdate.SDT = nhaXB.SDT;
  
                context.SaveChanges();
            }
            else
            {
                context.NhaXBs.Add(nhaXB);
                context.SaveChanges();
            }
        }

        public void Delete(NhaXB nhaXB)
        {
            if (nhaXB.MaNXB is null || nhaXB.MaNXB == "")
            {
                return;
            }
            else
            {
                QLTVContextDB context = new QLTVContextDB();
                NhaXB delete = context.NhaXBs.FirstOrDefault(p => p.MaNXB == nhaXB.MaNXB);
                if (delete != null)
                {
                    context.NhaXBs.Remove(delete);
                    context.SaveChanges();
                }
            }
        }
    }
}
