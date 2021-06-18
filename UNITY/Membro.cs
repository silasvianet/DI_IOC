using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNITY
{
    public class Membro : IMembro
    {
        public Membro()
        { }

        string _nome;
        string _nomeTime;

        public string Nome
        {
            get
            { return _nome; }
            set
            { _nome = value; }
        }
        public string Time
        {
            get
            { return _nomeTime; }
            set
            { _nomeTime = value; }
        }
        public void Detalhes()
        {
            Console.WriteLine("Nome membro = \t" + _nome + " \tNome Time = \t" + _nomeTime);
        }
    }
}
