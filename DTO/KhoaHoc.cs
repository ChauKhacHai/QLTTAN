using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoaHoc
    {
        public string _makhoahoc;
        public string _tenkhoahoc;
        public DateTime _ngaykhaigiang;
        public KhoaHoc() { }
        public KhoaHoc(string makhoahoc, string tenkhoahoc, DateTime ngaykhaigiang)
        {
            this._makhoahoc = makhoahoc;
            this._tenkhoahoc = tenkhoahoc;
            this._ngaykhaigiang = ngaykhaigiang;
        }
    }
}
