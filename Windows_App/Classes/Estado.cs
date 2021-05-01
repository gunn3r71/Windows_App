using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_App.Classes
{
    public class Estado
    {
        private string Nome { get; set; }

        public static List<Estado> RetornaEstados()
        {
            return new List<Estado>
            {
                new Estado { Nome = "SP" },
                new Estado { Nome = "BA" },
                new Estado { Nome = "MG" },
                new Estado { Nome = "GO" },
                new Estado { Nome = "RJ" }
            };
        }


        public override string ToString()
        {
            return this.Nome; 
        }
    }
}
