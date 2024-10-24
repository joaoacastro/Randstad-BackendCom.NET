using ExemploFundamentos.Models;

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "John";
// pessoa1.Idade = 34;

Pessoa pessoa1 = new() //Convenção: nome de variavel sempre em camelCase
{
    Nome = "John",
    Idade = 34
};

pessoa1.Apresentar();
