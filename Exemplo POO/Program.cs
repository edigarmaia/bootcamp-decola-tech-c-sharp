﻿using Exemplo_POO.Models;
/*
Pessoa p1 = new Pessoa();
p1.Nome = "Edigar";
p1.Idade = 41;

p1.Apresentar();
*/

ContaCorrente c1 = new ContaCorrente(123, 1000); 
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();