

class BankSystem
{
    static void Main()
    {
        Customer[] customers = new Customer[10];
        InitializeCustomers(customers);

        bool exitProgram = false;
        while (!exitProgram)  // Main loop to continuously ask for banker or customer mode
        {
            System.Console.WriteLine("Are you Banker/Customer? (or type 'exit' to quit)");
            string mode = System.Console.ReadLine().ToLower();

            if (mode == "banker")
            {
                System.Console.Write("Enter Employee ID: ");
                string empId = System.Console.ReadLine();
                System.Console.Write("Enter Password: ");
                string password = System.Console.ReadLine();

                bool exitBanker = false;
                while (!exitBanker)
                {
                    System.Console.WriteLine("1. Add New Customer Account");
                    System.Console.WriteLine("2. Delete Existing Customer Account");
                    System.Console.WriteLine("3. Check Customer Details");
                    System.Console.WriteLine("4. Display All Customers");
                    System.Console.WriteLine("5. Exit Banker Mode");
                    System.Console.Write("Select an option: ");
                    int option = int.Parse(System.Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            AddNewCustomer(customers);
                            break;
                        case 2:
                            DeleteCustomer(customers);
                            break;
                        case 3:
                            CheckCustomerDetails(customers);
                            break;
                        case 4:
                            DisplayAllCustomers(customers);
                            break;
                        case 5:
                            exitBanker = true;
                            break;
                        default:
                            System.Console.WriteLine("Invalid option. Try again.");
                            break;
                    }
                }
            }
            else if (mode == "customer")
            {
                System.Console.Write("Enter Account Number: ");
                int accountNumber = int.Parse(System.Console.ReadLine());
                Customer customer = FindCustomer(customers, accountNumber);

                if (customer != null)
                {
                    bool exitCustomer = false;
                    while (!exitCustomer)
                    {
                        System.Console.WriteLine("1. Deposit Money");
                        System.Console.WriteLine("2. Withdraw Money");
                        System.Console.WriteLine("3. Check Balance");
                        System.Console.WriteLine("4. Exit Customer Mode");
                        System.Console.Write("Select an option: ");
                        int option = int.Parse(System.Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                DepositMoney(customer);
                                break;
                            case 2:
                                WithdrawMoney(customer);
                                break;
                            case 3:
                                CheckBalance(customer);
                                break;
                            case 4:
                                exitCustomer = true;
                                break;
                            default:
                                System.Console.WriteLine("Invalid option. Try again.");
                                break;
                        }
                    }
                }
                else
                {
                    System.Console.WriteLine("Customer not found.");
                }
            }
            else if (mode == "exit")
            {
                exitProgram = true;
            }
            else
            {
                System.Console.WriteLine("Invalid mode selected.");
            }
        }
    }

    static void InitializeCustomers(Customer[] customers)
    {
        for (int i = 0; i < customers.Length; i++)
        {
            customers[i] = new Customer();
        }
    }

    static Customer FindCustomer(Customer[] customers, int accountNumber)
    {
        for (int i = 0; i < customers.Length; i++)
        {
            if (customers[i].AccountNumber == accountNumber)
            {
                return customers[i];
            }
        }
        return null;
    }

    static void AddNewCustomer(Customer[] customers)
    {
        for (int i = 0; i < customers.Length; i++)
        {
            if (customers[i].AccountNumber == 0)
            {
                System.Console.Write("Enter Account Number: ");
                customers[i].AccountNumber = int.Parse(System.Console.ReadLine());
                System.Console.Write("Enter Customer Name: ");
                customers[i].Name = System.Console.ReadLine();
                System.Console.Write("Enter Account Type (saving/current): ");
                customers[i].AccountType = System.Console.ReadLine().ToLower();
                System.Console.Write("Enter Initial Balance (minimum 1500): ");
                customers[i].Balance = double.Parse(System.Console.ReadLine());

                if (customers[i].Balance < 1500)
                {
                    System.Console.WriteLine("Initial balance must be at least 1500.");
                    customers[i] = new Customer(); // Reset the customer data.
                }
                else
                {
                    System.Console.WriteLine("Customer account added successfully.");
                }
                break;
            }
        }
    }

    static void DeleteCustomer(Customer[] customers)
    {
        System.Console.Write("Enter Account Number to Delete: ");
        int accountNumber = int.Parse(System.Console.ReadLine());

        for (int i = 0; i < customers.Length; i++)
        {
            if (customers[i].AccountNumber == accountNumber)
            {
                customers[i] = new Customer(); // Reset the customer data.
                System.Console.WriteLine("Customer account deleted successfully.");
                return;
            }
        }
        System.Console.WriteLine("Customer not found.");
    }

    static void CheckCustomerDetails(Customer[] customers)
    {
        System.Console.Write("Enter Account Number: ");
        int accountNumber = int.Parse(System.Console.ReadLine());
        Customer customer = FindCustomer(customers, accountNumber);

        if (customer != null)
        {
            System.Console.WriteLine("Account Number: {0}", customer.AccountNumber);
            System.Console.WriteLine("Name: {0}", customer.Name);
            System.Console.WriteLine("Account Type: {0}", customer.AccountType);
            System.Console.WriteLine("Balance: {0}", customer.Balance);
        }
        else
        {
            System.Console.WriteLine("Customer not found.");
        }
    }

    static void DisplayAllCustomers(Customer[] customers)
{
    System.Console.WriteLine("All Customer Information:");
    for (int i = 0; i < customers.Length; i++)
    {
        if (customers[i].AccountNumber != 0)
        {
            System.Console.WriteLine("Account Number: {0}", customers[i].AccountNumber);
            System.Console.WriteLine("Name: {0}", customers[i].Name);
            System.Console.WriteLine("Account Type: {0}", customers[i].AccountType);
            System.Console.WriteLine("Balance: {0}", customers[i].Balance);
            System.Console.WriteLine();
        }
    }
}


    static void DepositMoney(Customer customer)
    {
        System.Console.Write("Enter Amount to Deposit: ");
        double amount = double.Parse(System.Console.ReadLine());
        customer.Balance += amount;
        System.Console.WriteLine("Amount deposited successfully.");
    }

    static void WithdrawMoney(Customer customer)
    {
        System.Console.Write("Enter Amount to Withdraw: ");
        double amount = double.Parse(System.Console.ReadLine());

        if (amount <= customer.Balance)
        {
            customer.Balance -= amount;
            System.Console.WriteLine("Amount withdrawn successfully.");
        }
        else
        {
            System.Console.WriteLine("Insufficient balance.");
        }
    }

    static void CheckBalance(Customer customer)
    {
        System.Console.WriteLine("Current Balance: {0}",customer.Balance);
    }
}

class Customer
{
    public int AccountNumber { get; set; }
    public string Name { get; set; }
    public string AccountType { get; set; }
    public double Balance { get; set; }
}
