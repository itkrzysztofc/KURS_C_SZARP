using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A18_PorownanieObiektow
{
    public class AutoPorownywacz : IComparer<Auto>
    {
        public int Compare(Auto x, Auto y)
        {
            string s1 = x.Model.ToString();
            string s2 = y.Model.ToString();
            return string.Compare(s1, s2);
        }
    }
}
