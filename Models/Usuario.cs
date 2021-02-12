using System.IO;
using instaDev.Interfaces;

namespace instaDev.Models
{
    public class Usuario : InstaDevBase, IUsuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Foto { get; set; }
        public string DataDeNascimento { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }

        

        public const string PATH = "Database/Usuario.csv";

        public string Preparar(Usuario u)
        {
            return $"{u.IdUsuario};{u.Nome};{u.Foto};{u.DataDeNascimento};{u.Email};{u.Username};{u.Senha}";
        }
        public void Cadastrar(Usuario User)
        {
            string[] linha = { Preparar(User) };
            File.AppendAllLines(PATH, linha);

        }
    }
}