using System;
class Program {
  public static void Main (string[] args) {
     string nome, entrada;
    Double n1, n2, media;
//Escreval("texto")
    Console.WriteLine("Digite o nome do aluno");
//leia(variavel)
    nome = Console.ReadLine();
//solicita q o usuario digite a n1
    
    Console.WriteLine("Digite a primeira nota");
//recebe a nota 1 na variavel de texto. Toda a entrada é um texto
    entrada = Console.ReadLine();
// converter a entrada em um Double
    n1 =  Double.Parse(entrada);
//repete para a n2
    Console.WriteLine ("Digite a nota 2");
    entrada = Console.ReadLine();
    n2 = Double.Parse(entrada);
//calculo a media
    media = (n1 +n2)/2;
    Console.WriteLine ("A média do(a) aluno(a) " + nome + " é " +media);
    Console.WriteLine ("PARABÉNS");
  }
}