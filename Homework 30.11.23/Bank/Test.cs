using Bank;
using System;

class TestExample
{
    static void Main()
    {
        BankAccountFactory2 accountFactory = new BankAccountFactory2();

        int account1 = accountFactory.CreateAccount("Qundale Dingle", 666);
        Console.WriteLine(account1);
    }
}