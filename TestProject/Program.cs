string ?readResult = "";
bool reDo= false;

do
{
    Console.WriteLine("Welcome to Aleem's Exchange System!");
    Console.WriteLine("Please select the currencies you want to exchange");
    Console.WriteLine("1. USD to NGN");
    Console.WriteLine("2. NGN to USD");
    Console.WriteLine("3. USD to GBP");
    Console.WriteLine("4. GBP to USD");
    Console.WriteLine("5. GBP to NGN");
    Console.WriteLine("6. NGN to GBP");
    Console.WriteLine();

    int selection = 0;
    bool errorBoolean = true;
    do
    {
        Console.Write("Select your option: ");

        readResult = Console.ReadLine();
    
        if (readResult != null)
        {
            errorBoolean = int.TryParse(readResult, out selection);
            if (errorBoolean == false)
            {
                Console.WriteLine("Enter a valid option!");
            }
        }
        else
        {
            Console.WriteLine("select a valid option!");
        }
    } while (!errorBoolean);
    
        switch (selection)
        {
            case 1:
                double USD = 0;
                do
                {
                    Console.Write("Enter your USD amount 💵: ");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        errorBoolean = double.TryParse(readResult, out USD);
                    } else
                    {
                        errorBoolean = false;
                        Console.WriteLine("Invalid Input");
                        continue;
                    }

                    if (errorBoolean)
                        {
                            Console.WriteLine($"${USD} = {USDToNGN(USD)} NGN");
                            
                        } else
                        {
                            Console.WriteLine("Invalid Input");
                        }
                } while(!errorBoolean);

                break;


            case 2:
                double NGN = 0;
                do
                {   
                    Console.Write("Enter your NGN amount 💵: ");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        errorBoolean = double.TryParse(readResult, out NGN);
                    } else
                    {
                        continue;
                    }
                    if (errorBoolean)
                    {
                        Console.WriteLine($"{NGN} NGN = {NGNToUSD(NGN):C}");
                    } else
                    {
                        Console.WriteLine("Invalid amount");
                        continue;
                    }
                } while(!errorBoolean);
                break;

            case 3:
                Console.WriteLine("Work in Progress 👷‍♂️, check back later!");
                break;

            case 4:
                Console.WriteLine("Work in Progress 👷‍♂️, check back later!");
                break;

            case 5:
                Console.WriteLine("Work in Progress 👷‍♂️, check back later!");
                break;

            case 6:
                Console.WriteLine("Work in Progress 👷‍♂️, check back later!");
                break;

            default:
                Console.WriteLine("Select between options 1 - 6!");
                break;
        }

    Console.WriteLine("Do you want to exchange again? (y/n)");
    string choice = "";

    do
    {
        
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        choice = readResult.ToLower().Trim();
    }
    else
    {
        continue;
    }
    if (choice == "y")
    {
        reDo = true;
        errorBoolean = false;
    } else if (choice == "n")
    {
        reDo = false;
        errorBoolean = false;
    } else
    {
        Console.WriteLine("Enter a valid output!");
    }
    } while(errorBoolean);

    

} while(reDo);


double USDToNGN(double USD)
{
    double rate = 1460.23;
    return (rate * USD);
}
double NGNToUSD(double NGN)
{
    double rate = 1460.23;
    return (NGN / rate);
}
