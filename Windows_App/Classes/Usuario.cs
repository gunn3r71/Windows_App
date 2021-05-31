using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_App.Classes
{
    class Usuario : Arquivo
    {
        public string NomeUsuario { get; set; }
        public int Senha { get; set; }
        public bool IsLogged { get; set; }
        private Arquivo _arquivo = new() { Nome = "usuarios"};

        public Usuario()
        {
        }

        public void Gravar()
        {
            var dir = this.Diretorio + $"{Nome}.csv";
            if (!File.Exists(dir))
            {
                File.WriteAllText(dir,"Usuario;Senha\nlucas01;1234");
            }
            using (var writer = new StreamWriter(dir))
            {
                writer.WriteLine($"{this.NomeUsuario};{this.Senha};");
            }
        }

        public bool Logado(Usuario usuario)
        {
            var dir = this.Diretorio + $"{Nome}.csv";
            using (var reader = new StreamReader(dir))
            {
                string[] linha = null;
                while (!reader.EndOfStream)
                {
                    var user = reader.ReadLine();
                    linha = user.Split(";");
                    if (linha[0] == usuario.NomeUsuario && int.Parse(linha[1]) == usuario.Senha)
                    {
                        this.IsLogged = true;
                        return true;
                    }
                }
            }
            return false;
        } 
    }
}
