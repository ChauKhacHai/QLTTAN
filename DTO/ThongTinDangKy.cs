using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinDangKy
    {
        public string _mahv;
        public DateTime _ngaydangky;
        public string _trangthai;
        public int _soluongcuochen;
        public string _mangayranh;
        public string _macaranh;
        public string _matrinhdohientai;
        public string _matrinhdomuonhoc;
        public string _matrinhdoduochoc;
        public string _makithixeplop;
        public ThongTinDangKy() { }
        public ThongTinDangKy(string mahv, DateTime ngaydangky, string trangthai, int soluongcuochen, string mangayranh, string macaranh, string matrinhdohientai, string matrinhdomuonhoc, string matrinhdoduochoc, string makithixeplop)
        {
            this._mahv = mahv;
            this._ngaydangky = ngaydangky;
            this._trangthai = trangthai;
            this._soluongcuochen = soluongcuochen;
            this._mangayranh = mangayranh;
            this._macaranh = mangayranh;
            this._matrinhdohientai = matrinhdohientai;
            this._matrinhdomuonhoc = matrinhdomuonhoc;
            this._matrinhdoduochoc = matrinhdoduochoc;
            this._makithixeplop = makithixeplop;
        }
    }
}
