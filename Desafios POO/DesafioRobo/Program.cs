using System;
public class Robo
{
    public int velocidadeAtual;
    public int velocidadeMaxima;
    public int velocidadeMinima;

    public Robo(int velocidadeMaxima, int velocidadeMinima)
    {
        this.velocidadeMaxima = velocidadeMaxima;
        this.velocidadeMinima = velocidadeMinima;
        this.velocidadeAtual = velocidadeMinima;
    }

    public void acelerar()
    {
        if (velocidadeAtual < velocidadeMaxima)
        {
            velocidadeAtual++;
        }
    }

    public void desacelerar()
    {
        if (velocidadeAtual > velocidadeMinima)
        {
            velocidadeAtual--;
        }
    }
}

// Exemplo de uso
public class Program
{
    public static void Main()
    {
        // Lê a entrada do usuário
        string[] entrada = Console.ReadLine().Split();

        int vMin = int.Parse(entrada[0]);
        int vMax = int.Parse(entrada[1]);

        string comandos = Console.ReadLine();

       // Cria um objeto Robo
        // AQUI TBM!! faltou instancia a classe Robo
        Robo robo = new Robo(vMax, vMin); // <<<<<<

        // Itera sobre a sequência de comandos e chama os métodos apropriados
        foreach (char comando in comandos)
        {
            if (comando == 'A')
            {
                robo.acelerar();
            }
            else if (comando == 'D')
            {
                robo.desacelerar();
            }
        }

        // Imprime a velocidade final do robô
        Console.WriteLine(robo.velocidadeAtual);
    }
}