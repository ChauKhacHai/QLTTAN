using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongHoc
    {
        public string _maphong;
        public string _tenphong;
        public string _diadiem;
        PhongHoc() { }
        PhongHoc(string maphong,string tenphong,string diadiem)
        {
            this._diadiem = maphong;
            this._tenphong = tenphong;
            this._diadiem = diadiem;
        }

    }
}
