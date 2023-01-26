/*
 Classes and Constructors:

1. Create a class called Accounts which has data members(fields) like Account no, Customer name, Account type, Transaction type (d/w), amount, balance
D->Deposit
W->Withdrawal

-write a function that updates the balance depending upon the transaction type

	-If transaction type is deposit call the credit(int amount) function and update balance
	-If transaction type is withdraw call debit(int amt)function and update balance
-Pass the other information like Acount no,name,acc type through constructor
-call the show data method to display the values.
 */


using System;

namespace Assignment_2
{
    public class Accounts
    {
        public int Account_no;
        public string Cust_name;
        public string Account_type;
        public string Transaction_type;
        public float amount;
        public float balance = 2000;

        public Accounts() 
        {
            Console.WriteLine("Please Enter Account Number: ");
            this.Account_no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Customer Name: ");
            this.Cust_name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Please Enter Account Type: ");
            this.Account_type = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Please Enter Transaction Type (D-Deposite / W-Withdrawl): ");
            this.Transaction_type = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Please Enter Amount: ");
            this.amount = Convert.ToInt32(Console.ReadLine());

            if (Transaction_type == "d" || Transaction_type == "D")
            {
                balance = balance + amount;
            }
            else if (Transaction_type == "w" || Transaction_type == "W" && amount < balance)
            {
                balance = balance - amount;
            }
            else if (Transaction_type == "w" || Transaction_type == "W" && amount > balance)
            {
                Console.WriteLine("Insufficient Balance..!!");
            }
            else
            {
                Console.WriteLine("--------");
            }
        }

        public void Show()
        {
            Console.WriteLine($"\nAccount Number: {Account_no}\n" +
                   $"Customer Name: {Cust_name}\nAccount Type: {Account_type}\n" +
                   $"Transaction Type: {Transaction_type}\nAmount: {amount}\nBalance: {balance}\n");
        }

        static void Main(String[] args)
        {
            Accounts a = new Accounts();
            a.Show();
            Console.ReadLine();
        }
    }
}
