using BankAccountEnscapulation;

var account1 = new BankAccount();
Console.WriteLine("Please inut the amount you'd like to deposit.");
double userinput = System.Convert.ToInt32(Console.ReadLine());
BankAccount.Deposit(userinput);
BankAccount.GetBalance();
Console.WriteLine("How Much would you like to withdraw?");
double userinput2 = System.Convert.ToInt32(Console.ReadLine());
BankAccount.Withdrawl(userinput2);
BankAccount.GetBalance();