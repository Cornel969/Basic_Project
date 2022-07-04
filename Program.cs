using System;

namespace HoodATM
{
   class Program
   {
      static void Main(string[] args)
      {

         var bankAccount = new BankAccount();
         bankAccount.balance = 800;
         System.Console.WriteLine("Current Balance: R" + bankAccount.balance);

         var DepositMoney = 640;
         
         System.Console.WriteLine("The following amount has been Deposited: R" + DepositMoney);
         System.Console.WriteLine("Your new balance: R"+ bankAccount.deposit(DepositMoney));
         
         var DepositMessage = "An amount of R"+ DepositMoney + " has been deposited into your account, and your new balance is R"+ bankAccount.balance;
         
         var Dnotify = new Notification();
         Dnotify.AnSMS(DepositMessage);

         var WithdrawnMoney = 440;
         
         System.Console.WriteLine("The following amount has been withdrawn: R" + WithdrawnMoney);
         System.Console.WriteLine("Your new balance: R"+ bankAccount.withdrawal(WithdrawnMoney));
         
         var WithdrawalMessage = "An amount of R"+ WithdrawnMoney + " was withdrawn from your account, and your new balance is R"+ bankAccount.balance;
         
         var Wnotify = new Notification();
         Wnotify.AnSMS(WithdrawalMessage);

         System.Console.WriteLine("End of Week Balance: R" + bankAccount.balance);
        
      }
   }
}