using System;

namespace PolimorfismoExemplo
{
    
    public class Animal
    {
       
        public virtual void EmitirSom()
        {
            Console.WriteLine("O animal faz um som.");
        }
    }

    
    public class Cachorro : Animal
    {
        
        public override void EmitirSom()
        {
            Console.WriteLine("O cachorro late.");
        }
    }

   
    public class Gato : Animal
    {
        
        public override void EmitirSom()
        {
            Console.WriteLine("O gato mia.");
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
           
            Animal meuCachorro = new Cachorro();
            Animal meuGato = new Gato();

            
            FazerAnimalEmitirSom(meuCachorro);
            FazerAnimalEmitirSom(meuGato);
        }

       
        static void FazerAnimalEmitirSom(Animal animal)
        {
            animal.EmitirSom();
        }
    }
}

/*
Explicação:

- Classe Base `Animal`: Define um método virtual `EmitirSom` que pode ser sobrescrito pelas classes derivadas.
- Classes Derivadas `Cachorro` e `Gato`: Sobrescrevem o método `EmitirSom` para fornecer implementações específicas.
- Método `FazerAnimalEmitirSom`: Aceita um objeto do tipo `Animal` e chama o método `EmitirSom`. Graças ao polimorfismo, a implementação correta do método é chamada com base no tipo real do objeto (`Cachorro` ou `Gato`).

Polimorfismo é um conceito fundamental da programação orientada a objetos que permite que objetos de diferentes classes sejam tratados como objetos de uma classe base comum. Ele permite que um único método ou função opere em diferentes tipos de objetos, proporcionando flexibilidade e reutilização de código.

Situações em que o Polimorfismo é Útil:
1. Reutilização de Código: Permite escrever código mais genérico e reutilizável.
2. Flexibilidade: Facilita a extensão e manutenção do código, permitindo que novos tipos de objetos sejam introduzidos com pouca ou nenhuma modificação no código existente.
3. Interoperabilidade: Permite que diferentes classes trabalhem juntas de maneira uniforme.

Desvantagens do Polimorfismo:
1. Complexidade: Pode aumentar a complexidade do código, tornando-o mais difícil de entender e manter.
2. Performance: Pode introduzir uma pequena sobrecarga de desempenho devido à resolução dinâmica de métodos em tempo de execução.
3. Erros de Tempo de Execução: Pode levar a erros que só são detectados em tempo de execução, como chamadas de métodos em objetos que não suportam esses métodos.
*/