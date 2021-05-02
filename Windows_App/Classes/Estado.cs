using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_App.Classes
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public static List<Estado> RetornaEstados()
        {
            return new List<Estado>
            {
                new Estado { Id=1, Nome = "SP" },
                new Estado { Id=2, Nome = "BA" },
                new Estado { Id=3, Nome = "MG" },
                new Estado { Id=4, Nome = "GO" },
                new Estado { Id=5, Nome = "RJ" }
            };
        }


        public override string ToString()
        {
            return this.Nome; 
        }
    }
}
