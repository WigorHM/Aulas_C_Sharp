using System;
namespace Course{
class HelloWorld {
  static void Main() {
      ContaBancaria conta;
      Console.Write("Entre com o número da conta: ");
      int numero = int.Parse(Console.ReadLine());
      Console.Write("Entre com o nome do titular da conta: ");
      string titular = Console.ReadLine();
      Console.Write("Haverá depósito inicial? (s/n): ");
      char resp = char.Parse(Console.ReadLine());
      if(resp=='s' || resp =='S'){
          Console.Write("Digite o valor do depósito inicial: ");
          double depositoInicial = double.Parse(Console.ReadLine());
          conta = new ContaBancaria(numero, titular, depositoInicial);
      }else{
          conta= new ContaBancaria(numero, titular);
      }
      
      Console.WriteLine($"\nDados da conta\n{conta}");
      
      Console.Write("\nEntre com uma quantia para depósito: ");
      double quantia = double.Parse(Console.ReadLine());
      conta.Deposito(quantia);
      Console.WriteLine($"\nDados da conta atualizados\n{conta}");
      
      Console.Write("\nEntre com uma quantia para saque: ");
      quantia = double.Parse(Console.ReadLine());
      conta.Saque(quantia);
      Console.WriteLine($"\nDados da conta atualizados\n{conta}");
      
  }
}
}
