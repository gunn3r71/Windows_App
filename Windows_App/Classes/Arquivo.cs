using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace Windows_App.Classes
{
    class Arquivo
    {
        public string Nome { get; set; }
        public string Texto { get; set; }
        public string Diretorio { get; private set; }

        public Arquivo()
        {
            this.Diretorio = ConfigurationManager.AppSettings["db"];
        }

        public Arquivo(string nome) : this()
        {
            this.Nome = nome;
        }

        public void SalvarArquivo()
        {
            File.WriteAllText($"{this.Diretorio}{this.Nome}",this.Texto);
        }

        public int ContarLinhas()
        {
            int i = 0;
            foreach (var linha in Texto)
            {
                i++;
            }
            return i;
        }
    }
}
