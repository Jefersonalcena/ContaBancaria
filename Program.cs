// using static System.Console;
using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Informe o nome do proprietario da conta: ");
           string name = Console.ReadLine();
           Console.Write("Informe o numero da conta: ");
           int number = int.Parse(Console.ReadLine());
            
           Account accountOne = new Account(name,number,0.0); //Criando a conta
           Console.Clear();
           Console.WriteLine($"Conta criada com sucesso!\nConta do {accountOne.Name}, saldo = {accountOne.Balance}");

           Console.Write("Você deseja fazer um depósito ou um saque\nPara deposito [Digite 1], para saque [Digite 2]");
           int optionDeposit = int.Parse(Console.ReadLine());
           int optionSaque = int.Parse(Console.ReadLine());

           Console.Clear();

           if (optionDeposit == 1)
           {
               Console.Write("Qual o valor você deseja depositar ?");
               double valueDeposit = double.Parse(Console.ReadLine());
               
               string messageDeposit = accountOne.Deposit(valueDeposit);
               Console.WriteLine(messageDeposit);
               double newValueBalance = accountOne.Balance;
               Console.WriteLine($"O saldo da conta {accountOne.Number} foi atualizado para " + newValueBalance);
           }
           else if(optionSaque == 2) 
           {
               Console.Write("Qual o valor você deseja sacar?");
               double valueSaque = double.Parse(Console.ReadLine());
               
               string messageDeposit = accountOne.Saque(valueSaque);
               //Console.WriteLine(messageSaque);
               double newValueBalance = accountOne.Balance;
               Console.WriteLine($"O saldo da conta {accountOne.Number} foi atualizado para " + newValueBalance);
             
           }

        Console.ReadLine();

        //    ForegroundColor = System.ConsoleColor.Red;
        //    Console.WriteLine($"Conta do {accountOne.Name}");
        //    Console.WriteLine($"Saldo do {accountOne.Name} é: {accountOne.Balance}"); 
        //    double valuesDeposit = 250.50;
        //    string validateDeposit = accountOne.Deposit(valuesDeposit);
        //    ForegroundColor = System.ConsoleColor.Cyan;
        //    Console.WriteLine(validateDeposit);
        //    ForegroundColor = System.ConsoleColor.Green;
        //    Console.WriteLine($"Conta do {accountOne.Name}");
        //    Console.WriteLine($"Saldo do {accountOne.Name} é: {accountOne.Balance}"); 
        //    ForegroundColor = System.ConsoleColor.White;
        }
    }
}
