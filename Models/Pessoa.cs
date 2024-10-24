using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Pessoa
    {
        // public required string Nome { get; set; }
        // o required torna esse campo obrigatorio, podemos tirar o require, porem retornara um erro, para não ocorrer esse erro, podemos fazer conforme abaixo
        public string Nome { get; set; } = "*NAME NOT FOUND*"; // Nesse caso não tem require, porém tem um valor padrão caso o usuário não indique nenhum valor.
        
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos.");
        }
    }
}
