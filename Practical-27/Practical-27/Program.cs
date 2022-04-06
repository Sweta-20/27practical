namespace Practical_27
{
    //Use C#10 Features in Practical - 2
    class Customer_Account
    {
        public string bank_name;
        long customer_accountNo;
        string customer_name;
        public Customer_Account(long customer_accountNo, string customer_name)
        {
            this.customer_accountNo = customer_accountNo;
            this.customer_name = customer_name;
        }
        //printInfo method print all detail about customer.
        public void printInfo()
        {
            Console.WriteLine($"Bank Name : {bank_name}");
            Console.WriteLine($"Customer Name : {customer_name}");
            Console.WriteLine($"Customer Account No : {customer_accountNo}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Customer Name : ");
            string customer_name = Console.ReadLine();
            Console.Write("Enter Customer AccountNo : ");
            long customer_accountno = Convert.ToInt64(Console.ReadLine());
            Customer_Account obj = new Customer_Account(customer_accountno, customer_name);
            obj.bank_name = "Bank Of Baroda";
            obj.printInfo();

            Console.WriteLine();

            //Extra just test the C# 10 Feature -- Constant interpolated strings
            const string str = "C# 10 Feature";
            var result = $"This is {str} -- Constant interpolated strings... ";
            Console.WriteLine(result);
        }
    }
}
