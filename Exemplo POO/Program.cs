﻿using Exemplo_POO.Interfaces;
using Exemplo_POO.Models;
/*
Pessoa p1 = new Pessoa();
p1.Nome = "Edigar";
p1.Idade = 41;

p1.Apresentar();
*/
/*
ContaCorrente c1 = new ContaCorrente(123, 1000); 
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();

Console.WriteLine();
*/
/*
Aluno a1 = new Aluno();
a1.Nome = "Edigar";
a1.Idade = 40;
a1.Nota = 10;
a1.Apresentar();
*/

/*
Professor p1 = new Professor();
p1.Nome = "Edigar";
p1.Idade = 40;
p1.Salario = 1000;
p1.Apresentar();
*/

/*
Corrente c = new Corrente();
c.Creditar(500);
c.ExibirSaldo(); 
*/
/*
Pessoa p1 = new Pessoa("Edigar");   
Aluno a1 = new Aluno("Maria");
a1.Apresentar();
*/

//Computador c = new Computador();
//Console.WriteLine(c.ToString());

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3,9));