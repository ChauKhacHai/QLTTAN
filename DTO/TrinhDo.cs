using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrinhDo
    {
        public string _matrinhdo;
        public string _tentrinhdo;
        public string _maloaidethi;
        public string _trinhdotienquyet;
        public TrinhDo() { }
        public TrinhDo(string matrinhdo,string tentrinhdo,string maloaidethi,string trinhdotienquyet)
        {
            this._matrinhdo = matrinhdo;
            this._tentrinhdo = tentrinhdo;
            this._maloaidethi = maloaidethi;
            this._trinhdotienquyet = trinhdotienquyet;
        }
    }
}
