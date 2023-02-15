using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Informe a primeira nota:");
    double n1 = double.Parse(Console.ReadLine());

    Console.WriteLine ("Informe a segunda nota:");
    double n2 = double.Parse(Console.ReadLine());

    Console.WriteLine ("Informe a terceira nota:");
    double n3 = double.Parse(Console.ReadLine());

    double media = (n1 + n2 + n3) /3;
    String situacao = "";

    if (media >=5){
      situacao = "Aprovado";
      
    }
    else if ( media <3){
      situacao = "Reprovado";
      
    }
    else{
      
      situacao = "Recuperacao";
      
    }

    Console.WriteLine ("A média é:" + media);
    Console.WriteLine ("Situação do aluno:" + situacao);
  }
}