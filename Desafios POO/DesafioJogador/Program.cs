using System;

class Jogador
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }

    public Jogador()
    {
    }
    public Jogador(string nome, string nacionalidade, int idade, string posicao)
    {
        Nome = nome;
        Nacionalidade = nacionalidade;
        Idade = idade;
        Posicao = posicao;
        
    }
}

class Program
{
    static void Main()
    {
        string nome = Console.ReadLine();
        string nacionalidades = Console.ReadLine();
        int idade = Convert.ToInt32(Console.ReadLine());
        string posicao = Console.ReadLine();

        Jogador jogador = new Jogador();

        Console.WriteLine($"Jogador criado!\n{nome}\n{nacionalidades}\n{idade}\nPosição: {posicao}");
    }
}