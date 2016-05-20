using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Lop
    {
        string _malop;
        string _makhoahoc;
        string _machuongtrinhhoc;
        DateTime _ngaybatdau;
        DateTime _ngayketthuc;
        string _maca;
        string _mangay;
        double _hocphi;
        string _magiangvien;
        string _maphonghoc;
        public Lop() { }
        public Lop(string malop, string makhoahoc, string machuongtrinhhoc, DateTime ngaybatdau, DateTime ngayketthuc, string maca, string mangay, double hocphi, string magiangvien, string maphonghoc)
        {
            this._malop = malop;
            this._makhoahoc = makhoahoc;
            this._machuongtrinhhoc = machuongtrinhhoc;
            this._ngaybatdau = ngaybatdau;
            this._ngayketthuc = ngayketthuc;
            this._maca = maca;
            this._mangay = mangay;
            this._hocphi = hocphi;
            this._magiangvien = magiangvien;
            this._maphonghoc = maphonghoc;
        }
    }
}
