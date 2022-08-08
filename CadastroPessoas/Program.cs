using System;
using PessoaDados;
namespace CadastroPessoa;

class Program
{
    static void Main(string[] args)
    {
      Pessoa p = new Pessoa();
      p.Nome = "Geovana";
      p.Idade = 22;
      p.Peso = 75.44;
      p.Altura = 1.77;
      p.Identidade = "4569852314";
      p.Apresentar();
      

    }
    
}



