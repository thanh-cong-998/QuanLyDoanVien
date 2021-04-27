using QuanLyDoanVien.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoanVien.BLL
{
    public class ChiDoan_BLL
    {
        //lay du lieu trong ds chi doan
        QuanLyDoanVienDbContext ql = new QuanLyDoanVienDbContext();
        public List<ChiDoan> GetALL()
        {
            return ql.ChiDoan.ToList();
        }
        //lay danh sach theo machidoan
        public List<ChiDoan> getBYMaChiDoan(string machidoan)
        {
            return ql.ChiDoan.Where(m => m.MaChiDoan == machidoan).ToList();
        }
        //them thong tin
        public void Create()
        {
            ChiDoan cd = new ChiDoan();
            ql.ChiDoan.Add(cd);
            ql.SaveChanges();
        }
        public void Create(ChiDoan cd)
        {
            ql.ChiDoan.Add(cd);
            ql.SaveChanges();
        } 
        public void Edit(string machidoan, string tenchidoan)
        {
            var ChiDoan = ql.ChiDoan.Find(machidoan);
            ChiDoan.TenChiDoan = tenchidoan;
            ql.SaveChanges();
        }

        internal bool CheckChiDoan(string maChiDoan)
        {
            var checkCD = ql.ChiDoan.Where(m => m.MaChiDoan == maChiDoan).Count();
            if (checkCD > 0)
            {
                //co ton tai Unit voi UnitID == id
                return true;
            }
            else
            {
                return false;
            }
        }
        //sua chi doan
        public void Edit(string MCD, string TCD)
        {
            var CD = ql.ChiDoan.Find(MCD);
            CD.TenChiDoan = TCD;
            ql.SaveChanges();
        }
        //Xoa
        public void Delete(string MCD)
        {
            var std = ql.ChiDoan.Find(MCD);
            ql.ChiDoan.Remove(std);
            ql.SaveChanges();
        }
    }
}
