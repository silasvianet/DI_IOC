using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace UNITY
{
    public class Fabrica
    {        static public IMembro CreateInstance()
        {
            IUnityContainer _container = new UnityContainer();

            _container.RegisterType<IMembro, Membro>();

            IMembro obj = _container.Resolve<IMembro>();

            return obj;
        }
    }
}
