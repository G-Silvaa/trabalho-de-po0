// O código fornecido funciona porque, embora a classe abstrata Poligono não possa ser instanciada diretamente, o array Poligono[] não cria instâncias de Poligono. Ele apenas cria um array de referências para objetos do tipo Poligono ou de classes que estendem Poligono. Em Java, é permitido criar arrays de classes abstratas ou interfaces, pois o array em si não contém instâncias, apenas referências.

// Aqui está a explicação detalhada:

// Classe abstrata: Uma classe abstrata não pode ser instanciada diretamente porque pode conter métodos abstratos (métodos sem implementação), e a ideia é que subclasses concretas forneçam essas implementações.

// Array de classe abstrata: Quando você cria um array de uma classe abstrata (Poligono[] p = new Poligono[10];), o array contém referências que podem apontar para objetos de subclasses concretas de Poligono. Ele não tenta instanciar diretamente a classe Poligono.

// Array de referências: No código, Poligono[] p = new Poligono[10]; cria um array de 10 posições, onde cada posição pode armazenar uma referência a um objeto que seja uma instância de uma subclasse de Poligono. Nenhuma instância real de Poligono é criada neste ponto, então a restrição de não poder instanciar a classe abstrata não é violada.

// Portanto, o código funciona porque você está criando apenas um array de referências para um tipo abstrato, não instâncias do tipo abstrato.
// using System;

public abstract class Poligono
{
    public abstract void Desenhar();
}

public class Triangulo : Poligono
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando um Triângulo.");
    }
}

public class Quadrado : Poligono
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando um Quadrado.");
    }
}

class Program
{
    static void Main(string[] args)
    {

        Poligono[] poligonos = new Poligono[2];
        poligonos[0] = new Triangulo();
        poligonos[1] = new Quadrado();


        foreach (Poligono p in poligonos)
        {
            p.Desenhar();
        }
    }
}