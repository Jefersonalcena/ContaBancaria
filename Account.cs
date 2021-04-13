using System;

namespace ContaBancaria
{
    public class Account
    {
        // Contrutor (é usado no momento de criar(chamar) a classe)
        // Propriedade é a primera na ordem do contrutor
        public Account(string name, int number, double balance)
        {
            Name = name;
            Number = number;
            Balance = balance;
        }

        // Propriedades da classe
        public string Name { get; set; }
        public int Number { get; set; }
        public double Balance { get; set; }
        public double Credit { get; set; }


       //Deposito
        public string Deposit(double valuesDeposit)
        {
              try
              {
                  Balance = Balance + valuesDeposit;
                  return "Depósito realizado com sucesso";
              }
              catch (System.Exception error)
              {
                  Console.WriteLine(error.Message);
                  return "O depósito não foi realizado";
              }
        }  

         //Saque
        public string Saque(double valuesSaque)
        {
              try
              {
                  Balance = Balance - valuesSaque;
                  return "Saque realizado com sucesso";
              }
              catch (System.Exception error)
              {
                  Console.WriteLine(error.Message);
                  return "Saldo insuficiente!";
              }  

        } 


        

        // Método nativo para escrever as propriedades da classe
        // public override string ToString()
        // {
        //     return $"Name: {Name}, Number: {Number}, Balance: {Balance}"; 
        // }
    }
}