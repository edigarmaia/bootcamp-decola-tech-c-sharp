# POO com C#
Paradigma - modelo de técnicas, estruturas e formas de solucionar um problema.
Uma linguagem de programação implementa um ou mais paradigmas.

Paradigmas:
* Orientada a objetos;
* Estruturada;
* Imperativa;
* Procedural;
* Orientada a eventos;
* Lógica;

Pilares: abstração, encapsulamento, herança e polimorfismo. 

## Abstração
Abstrair um objeto do mundo real para um contexto específico, considerando apenas os atributos importantes.

## Encapsulamento
Serve para proteger uma classe e definir limites para alteração de suas propriedades. Ocultar seu comportamento e expor somente o necessário.

## Herança
Nos permite reutilizar atributos, métodos e comportamentos de uma classe em outras classes.
Serve para agrupar objetos que são do mesmo tipo, porém, com características diferentes.

## Polimorfismo
Significa "muitas formas"
Podemos sobrescrever métodos das classes filhas para que se comportem de maneira diferente e ter sua própria implementação.

## Classes abstratas
Tem como obejtivo ser exclusivamente um modelo para ser herdado, portanto não pode ser instanciada.
Você pode implementar métodos ou deixá-los a cargo de quem herdar.

## Classes seladas
Tem como objetivo impedir que outras classes façam uma herança dela, ou seja, nenhuma classe pode ser derivada.
Também existe métodos e propriedades seladas.

## Classe Object
A classe System.Object é a mãe de todas as classes na hierarquia .Net
Todas as classes derivam, direta ou indiretamente da classe Object, e ela tem como objetivo prover serviços de baixo nivel para as suas classes filhas.

## Interfaces
Uma interface é um contrato que pode ser implementado por uma classe.
É como de fosse uma classe abstrata, podendo definir métodos abstratos para serem implementados.
Assim como uma classe abstrata, uma interface não pode ser instanciada.