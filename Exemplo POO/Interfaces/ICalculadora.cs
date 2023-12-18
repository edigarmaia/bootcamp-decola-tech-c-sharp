using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_POO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);

        int Multiplicar(int num1, int num2); // métodos que não tem corpo são obrigatórios para a implementação

        int Dividir(int num1, int num2){
            return num1 / num2; // método que tem corpo a implementação é opcional
        }



    }
}