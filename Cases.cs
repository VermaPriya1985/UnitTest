using System;
namespace UnitTest
{
    public class Cases
    {

        // Constructor to initialize values
        public Cases(long customerid, string customername,int accountnumber,double initialbalance) 
        {
            CustomerId = customerid;
            CustomerName = customername;
            AccountNumber = accountnumber;
            InitialBalance = initialbalance;
        }

        // Set Properties 
        public long CustomerId{get; private set;}
        public string CustomerName{get; private set;}
        public int AccountNumber{get; private set;}
        public double InitialBalance{get; private set;}  
        
        // Method to print customer details
        public void PrintDetail()
        {
            Console.WriteLine($"Customer Details: Customer ID: {CustomerId}, Customer Name: {CustomerName}, Account Number: {AccountNumber}, Initial Balance: {InitialBalance}");
        }   

        // 1st Case 
        public double Case1(int accountnumber,double initialbalance,double amountdepositusd)
        {
            double balance = (amountdepositusd*2 + initialbalance); 
            return balance;
        } 

        // 2nd Case
        public double Case2(int accountnumber,double initialbalance,double amountwithdrawmxn, double amountwithdrawusd,double amountdepositcad)
        {
            double balance = (initialbalance - (amountwithdrawmxn/10) - (amountwithdrawusd*2)  + amountdepositcad); 
            return balance;
        } 

        // 3rd Case for First Account Number
        public double Case3FirstAccount(int accountnumber,double initialbalance,double amountwithdrawcad, double accountdepositmxn)
        {
            double balance = (initialbalance - amountwithdrawcad + (accountdepositmxn/10)); 
            return balance;
        } 

        // 3th Case for Second Account Number
        public double Case3SecondAccount(int accountnumber,double initialbalance,double amountwithdrawcad, double accountdepositcad)
        {
            double balance = (initialbalance - amountwithdrawcad + accountdepositcad); 
            return balance;
        } 

        // 4th Case for First Account Number
        public double Case4FirstAccount(int accountnumber,double initialbalance,double amountwithdrawusd, double accountdepositcad)
        {
            double balance = (initialbalance - (amountwithdrawusd * 2) + accountdepositcad); 
            return balance;
        } 
        
        // 4th Case for Second Account Number
        public double Case4SecondAccount(int accountnumber,double initialbalance,double amountwithdrawcad, double accountdepositusd)
        {
            double balance = (initialbalance - amountwithdrawcad + (accountdepositusd * 2)); 
            return balance;
        } 

        // 5th Case 
        public double Case5(int accountnumber,double initialbalance,double amountwithdrawusd)
        {
            double balance = initialbalance;
            return balance;
        } 
    }
}