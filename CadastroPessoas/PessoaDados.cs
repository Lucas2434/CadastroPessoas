using System;
namespace PessoaDados
{
   public class Pessoa
   {
    public string? Nome { get; set;} 
    public int Idade { get; set; }

    public double Peso { get; set; }  
    public double Altura { get; set;}
    public string? Identidade { get; set;}
    
    public void Apresentar()
    {
       System.Console.WriteLine($"olá meu nome {Nome} e tenho {Idade} anos e peso {Peso} kg e tenho altura {Altura} e minha indentidade é {Identidade}");
    }
    
    }
 
}
