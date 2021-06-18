using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNITY
{
    public interface IMembro
    {
        string Nome
        {
            get;
            set;
        }
        string Time
        {
            get;
            set;
        }

        void Detalhes();
    }
}
