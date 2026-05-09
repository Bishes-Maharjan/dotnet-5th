using System;
using System.Collections;
using System.Collections.Generic;

// ─── Shared BankAccount class ───────────────────────────────────────────────

public class BankAccount
{
    public int AccountNumber { get; private set; }
    public string Name { get; private set; }
    public double Balance { get; private set; }

    public BankAccount(int accountNumber, string name, double balance)
    {
        AccountNumber = accountNumber;
        Name = name;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0) { Console.WriteLine("Amount must be positive."); return; }
        Balance += amount;
        Console.WriteLine($"Deposited: {amount:C}. New balance: {Balance:C}");
    }

    public void Withdrawal(double amount)
    {
        if (amount <= 0) { Console.WriteLine("Amount must be positive."); return; }
        if (amount > Balance) { Console.WriteLine("Insufficient funds."); return; }
        Balance -= amount;
        Console.WriteLine($"Withdrawn: {amount:C}. New balance: {Balance:C}");
    }

    public void BankFees()
    {
        double fee = Balance * 0.05;
        Balance -= fee;
        Console.WriteLine($"Bank fee (5%): {fee:C}. New balance: {Balance:C}");
    }

    public void Display()
    {
        Console.WriteLine($"Account: {AccountNumber} | Owner: {Name} | Balance: {Balance:C}");
    }
}

// ─── Version 1: using List<BankAccount> ─────────────────────────────────────

public class BankWithList
{
    private List<BankAccount> accounts = new List<BankAccount>();

    public void AddAccount(BankAccount account) => accounts.Add(account);

    public void DisplayAll()
    {
        Console.WriteLine("\n--- BankWithList ---");
        foreach (BankAccount acc in accounts)
            acc.Display();
    }
}

// ─── Version 2: using ArrayList ─────────────────────────────────────────────

public class BankWithArrayList
{
    private ArrayList accounts = new ArrayList();

    public void AddAccount(BankAccount account) => accounts.Add(account);

    public void DisplayAll()
    {
        Console.WriteLine("\n--- BankWithArrayList ---");
        foreach (object obj in accounts)
        {
            BankAccount acc = (BankAccount)obj; // cast required
            acc.Display();
        }
    }
}

// ─── Entry point ────────────────────────────────────────────────────────────

class Program
{
    static void Main()
    {
        BankAccount alice = new BankAccount(1001, "Alice", 5000);
        BankAccount bob   = new BankAccount(1002, "Bob",   3000);

        // Same objects fed into both collections
        BankWithList listBank = new BankWithList();
        listBank.AddAccount(alice);
        listBank.AddAccount(bob);

        BankWithArrayList arrayListBank = new BankWithArrayList();
        arrayListBank.AddAccount(alice);
        arrayListBank.AddAccount(bob);

        alice.Deposit(500);
        bob.Withdrawal(200);
        alice.BankFees();

        listBank.DisplayAll();
        arrayListBank.DisplayAll(); // same objects — same updated balances
    }
}