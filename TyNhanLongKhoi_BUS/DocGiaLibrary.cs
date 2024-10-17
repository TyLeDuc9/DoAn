using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TyNhanLongKhoi_DAL;

namespace TyNhanLongKhoi_BUS
{
    public class DocGiaLibrary
    {
        public List<DocGia> GetAll()
        {
            QLTVContextDB context = new QLTVContextDB();
            return context.DocGias.ToList();
        }


        public void InsertOrUpdate(DocGia docGia)
        {
            QLTVContextDB context = new QLTVContextDB();
            DocGia dbUpdate = context.DocGias.FirstOrDefault(p => p.MaDocGia == docGia.MaDocGia);
            if (dbUpdate != null)
            {
                dbUpdate.SoThe = docGia.SoThe;
                dbUpdate.TenDocGia = docGia.TenDocGia;
                dbUpdate.SDT = docGia.SDT;
                dbUpdate.Email = docGia.Email;
                dbUpdate.DiaChi = docGia.DiaChi;

                context.SaveChanges();
            }
            else
            {
                context.DocGias.Add(docGia);
                context.SaveChanges();
            }
        }
        public DocGia FindById(string maDocGia)
        {
            QLTVContextDB context = new QLTVContextDB();
            return context.DocGias.FirstOrDefault(p => p.MaDocGia == maDocGia);
        }

        public void Delete(DocGia docGia)
        {
            if (docGia.MaDocGia is null || docGia.MaDocGia == "")
            {
                return;
            }
            else
            {
                QLTVContextDB context = new QLTVContextDB();
                DocGia delete = context.DocGias.FirstOrDefault(p => p.MaDocGia == docGia.MaDocGia);
                if (delete != null)
                {
                    context.DocGias.Remove(delete);
                    context.SaveChanges();
                }
            }
        }
    }
}
