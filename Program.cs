using System;
namespace UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Structure of values are: AccountNumber,InitialBalance,Withdraw,Deposit
            double case1 = Case1(1234,100,300);
            Console.WriteLine(case1);

            double case2 = Case2(2001,35000,5000,12500,300);
            Console.WriteLine(case2);
            
            double case3firstaccount = Case3FirstAccount(1010,7425,7300,13726);
            Console.WriteLine(case3firstaccount);

            double case3secondaccount = Case3SecondAccount(5500,15000,5000,7300);
            Console.WriteLine(case3secondaccount);

            double case4firstaccount = Case4FirstAccount(0123,150,70,23.75);
            Console.WriteLine(case4firstaccount);

            double case4secondaccount = Case4SecondAccount(0456,65000,23.75,23789);
            Console.WriteLine(case4secondaccount);

            double case5 = Case5(1010,7425,100);
            Console.WriteLine(case5);

        }
       
       public static double Case1(int accountnumber,double initialbalance, double amountdepositusd)
       {
            double case1 = 0;
            if(accountnumber==1234)
            {
                Cases newcase=new Cases(777,"Stewie Griffin",accountnumber,initialbalance);
                case1 = newcase.Case1(accountnumber,initialbalance,amountdepositusd);
                newcase.PrintDetail();
            }
            else
            {
                Console.WriteLine("Please provide corrct Account Number");
            }
            return case1;
        }
        public static double Case2(int accountnumber,double initialbalance,double amountwithdrawmxn, double amountwithdrawusd,double amountdepositcad)
        {
            double case2 = 0;
            if(accountnumber==2001)
            {

                Cases newcase=new Cases(504,"Glenn Quagmire",accountnumber,initialbalance);
                case2 = newcase.Case2(accountnumber,initialbalance,amountwithdrawmxn,amountwithdrawusd,amountdepositcad);
                newcase.PrintDetail();
            }
            else
            {
                Console.WriteLine("Please provide corrct Account Number");
            }
            return case2;
        }
        public static double Case3FirstAccount(int accountnumber,double initialbalance,double amountwithdrawcad, double amountdepositmxn)
        {
            double case3 = 0;
            if(accountnumber==1010)
            {
            Cases newcase=new Cases(002,"Joe Swanson",accountnumber,initialbalance);
            case3 = newcase.Case3FirstAccount(accountnumber,initialbalance,amountwithdrawcad,amountdepositmxn);
            newcase.PrintDetail();
            }
            else
            {
                 Console.WriteLine("Please provide corrct Account Number");
            }
            return case3;
        }
        public static double Case3SecondAccount(int accountnumber,double initialbalance,double amountwithdrawcad, double amountdepositcad)
        {
            double case3 = 0;
            if(accountnumber==5500)
            {
                Cases newcase=new Cases(002,"Joe Swanson",accountnumber,initialbalance);
                case3 = newcase.Case3SecondAccount(accountnumber,initialbalance,amountwithdrawcad,amountdepositcad);
                newcase.PrintDetail();
            }
            else
            {
                 Console.WriteLine("Please provide corrct Account Number");
            }
            return case3;
        }
        public static double Case4FirstAccount(int accountnumber,double initialbalance,double amountwithdrawusd, double amountdepositcad)
        {
            double case4 = 0;
            if(accountnumber==0123)
            {
                Cases newcase=new Cases(0123,"Peter Griffin",accountnumber,initialbalance);
                case4 = newcase.Case4FirstAccount(accountnumber,initialbalance,amountwithdrawusd,amountdepositcad);
                newcase.PrintDetail();
            }
            else
            {
                 Console.WriteLine("Please provide corrct Account Number");
            }
            return case4;
        }
        public static double Case4SecondAccount(int accountnumber,double initialbalance,double amountwithdrawcad, double amountdepositusd)
        {
            double case4 = 0;
            if(accountnumber==456)
            {
                Cases newcase=new Cases(456,"Lois Griffin",accountnumber,initialbalance);
                case4 = newcase.Case4SecondAccount(accountnumber,initialbalance,amountwithdrawcad,amountdepositusd);
                newcase.PrintDetail();
            }
            else
            {
                Console.WriteLine("Please provide corrct Account Number");
            }
            return case4;
        }
        public static double Case5(int accountnumber,double initialbalance,double amountwithdrawusd)
        {
            double case5 = 0;
            if(accountnumber==1010)
            {
                Cases newcase=new Cases(002,"Joe Swanson",accountnumber,initialbalance);
                case5 = newcase.Case5(accountnumber,initialbalance,amountwithdrawusd);
                newcase.PrintDetail();
            }
            else
            {
                Console.WriteLine("Please provide corrct Account Number");
            }
            return case5;
        }        
    }   
}
