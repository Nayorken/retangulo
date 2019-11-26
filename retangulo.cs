using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retangulo
{
    class retangulo
    {
        private double _a;  // _a -> ALTURA
        private double _l; // _l -> LARGURA
        public string Altura { set => _a = Convert.ToDouble(value); }
        public string Largura { set => _l = Convert.ToDouble(value); }
        public string Area => (_a * _l).ToString();
        public string Perimetro => ((_a + _l)*2).ToString();
        public string Diagonal => (Math.Sqrt(_l*_l + _a * _a)).ToString();
    }
}
