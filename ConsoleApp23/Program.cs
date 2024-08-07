using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ussdcode = "*123#";


            //string userInput = "";
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Type USSD code");
                Console.ForegroundColor= ConsoleColor.DarkMagenta;
                string userInput = Console.ReadLine();
                if (userInput == ussdcode)
                {
                    MainMenu();
                }
                else
                {
                    Console.WriteLine("Invalid USSDcode");
                }
            }

            }
            private static bool MainMenu()
            {
                bool isValid = false;

                while (!isValid)
                {
                    Console.ForegroundColor=ConsoleColor.Magenta;
                    Console.WriteLine("Just for you");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("1. Voice");
                Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("2. Data");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("3. Exit");
                Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Select an option");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    int option = int.Parse(Console.ReadLine());

                    if (option >= 1 && option <= 5)
                    {
                        isValid = true;

                        switch (option)
                        {
                            case 1:
                                voice();
                                break;
                            case 2:
                                dataBundle();
                                break;
                            case 3:
                                exit();
                                break;

                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid selection");
                    }

                }
                return true;
            }
            private static void voice()
            {
                while (true)
                {
                    Console.WriteLine("Voice");
                    Console.WriteLine("");
                    Console.WriteLine("1. Today");
                    Console.WriteLine("2. 3 days");
                    Console.WriteLine("3. Any network");
                    Console.WriteLine("4. Back");
                    Console.WriteLine("Select an option");
                    int voice = int.Parse(Console.ReadLine());

                    if (voice >= 1 && voice <= 4)
                    {
                        switch (voice)
                        {
                            case 1:
                                Today();
                                break;
                            case 2:
                                Days();
                                break;
                            case 3:
                                AnyNetwork();
                                break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection");
                    }
                }
            }
            private static void Today()
            {
                while (true)
                {
                    Console.ForegroundColor= ConsoleColor.DarkMagenta;
                    Console.WriteLine("1. 55 VC min - R5.5");
                    Console.WriteLine("2. Unlimited VC minutes - R15");
                    Console.WriteLine("3. 100 VC min + 1GB WA - R12");
                    Console.WriteLine("4. Back");
                    Console.WriteLine("Select an option");
                    int today = int.Parse(Console.ReadLine());

                    if (today == 1)
                    {
                        Console.WriteLine("You have selected 55 VC min for R5.5");
                        Console.WriteLine("Proceed to payment");
                        Console.WriteLine("Select payment method");
                        Console.WriteLine("1. Pay with airtime");
                        Console.WriteLine("2. Pay with card");
                        int pay = int.Parse(Console.ReadLine());

                        if (pay == 1)
                        {
                            Console.WriteLine("You have successfully purchased VC minutes. An sms of confirmation will be sent to you.");
                        Environment.Exit(0);
                        }
                        else if (pay == 2)
                        {
                            Console.WriteLine("Enter card details");
                            Console.WriteLine("Enter card number:");
                            string cardNum = Console.ReadLine();
                        if (long.TryParse(cardNum,out long number))
                        {
                            int digitCount = cardNum.Length;
                            if (cardNum.Length == 16)
                            {
                                Console.WriteLine(cardNum);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Enter  valid cardNumber");
                        }
                            Console.WriteLine("Enter cvv:");
                            int cvv = int.Parse(Console.ReadLine());
                            Console.WriteLine("You have successfully purchased VC minutes. An sms of confirmation will be sent to you.");
                        Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection");
                        }
                    }
                    else if (today == 2)
                    {

                        Console.WriteLine("You have selected unlimited VC min for R15");
                        Console.WriteLine("Proceed to payment");
                        Console.WriteLine("Select payment method");
                        Console.WriteLine("1. Pay with airtime");
                        Console.WriteLine("2. Pay with card");
                        int pay = int.Parse(Console.ReadLine());

                        if (pay == 1)
                        {
                            Console.WriteLine("You have successfully purchased VC minutes. An sms of confirmation will be sent to you.");
                        Environment.Exit(0);
                        }
                        else if (pay == 2)
                        {
                            Console.WriteLine("Enter card details");
                            Console.WriteLine("Enter card number:");
                            long cardNum = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter cvv:");
                            int cvv = int.Parse(Console.ReadLine());
                            Console.WriteLine("You have successfully purchased VC minutes. An sms of confirmation will be sent to you.");
                        Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection");
                        }
                    }
                    else if (today == 3)
                    {

                        Console.WriteLine("You have selected 100 VC min + 1GB WA for R12");
                        Console.WriteLine("Proceed to payment");
                        Console.WriteLine("Select payment method");
                        Console.WriteLine("1. Pay with airtime");
                        Console.WriteLine("2. Pay with card");
                        int pay = int.Parse(Console.ReadLine());

                        if (pay == 1)
                        {
                            Console.WriteLine("You have successfully purchased VC minutes. An sms of confirmation will be sent to you.");
                        Environment.Exit(0);
                        }
                        else if (pay == 2)
                        {
                            Console.WriteLine("Enter card details");
                            Console.WriteLine("Enter card number:");
                            long cardNum = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter cvv:");
                            int cvv = int.Parse(Console.ReadLine());
                            Console.WriteLine("You have successfully purchased VC minutes. An sms of confirmation will be sent to you.");
                        Environment.Exit(0);
                        }
                    }
                    else if (today == 4)
                    {
                        voice();
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection");
                    }
                }
            }
            private static void Days()
            {
                while (true)
                {
                    Console.WriteLine("1. 180 VC min(60 min daily) - R19");
                    Console.WriteLine("2. Unlimited VC minutes - R39");
                    Console.WriteLine("3. 210 min(70 min daily) - R13");
                    Console.WriteLine("4. Back");
                    Console.WriteLine("Select an option");
                    int days = int.Parse(Console.ReadLine());

                    if (days == 1)
                    {
                        Console.WriteLine("You have successfully purchased 180 VC minutes for R19");
                        Console.WriteLine("Proceed to payment");
                        Console.WriteLine("Select payment method");
                        Console.WriteLine("1. Pay with airtime");
                        Console.WriteLine("2. Pay with card");
                        int pay = int.Parse(Console.ReadLine());

                        if (pay == 1)
                        {
                            Console.WriteLine("You have successfully purchased VC minutes. An sms of confirmation will be sent to you.");
                        Environment.Exit(0);
                        }
                        else if (pay == 2)
                        {
                            Console.WriteLine("Enter card details");
                            Console.WriteLine("Enter card number:");
                            long cardNum = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter cvv:");
                            int cvv = int.Parse(Console.ReadLine());
                            Console.WriteLine("You have successfully purchased VC minutes. An sms of confirmation will be sent to you.");
                        Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection");
                        }
                    }
                    else if (days == 2)
                    {
                        Console.WriteLine("You have successfully purchased Unlimited VC minutes for R39");
                        Console.WriteLine("Proceed to payment");
                        Console.WriteLine("Select payment method");
                        Console.WriteLine("1. Pay with airtime");
                        Console.WriteLine("2. Pay with card");
                        int pay = int.Parse(Console.ReadLine());

                        if (pay == 1)
                        {
                            Console.WriteLine("You have successfully purchased VC minutes. An sms of confirmation will be sent to you.");
                        Environment.Exit(0);
                        }
                        else if (pay == 2)
                        {
                            Console.WriteLine("Enter card details");
                            Console.WriteLine("Enter card number:");
                            long cardNum = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter cvv:");
                            int cvv = int.Parse(Console.ReadLine());
                            Console.WriteLine("You have successfully purchased VC minutes. An sms of confirmation will be sent to you.");
                        Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection");
                        }
                    }
                    else if (days == 3)
                    {
                        Console.WriteLine("You have successfully purchased 210 VC minutes for R13");
                        Console.WriteLine("Proceed to payment");
                        Console.WriteLine("Select payment method");
                        Console.WriteLine("1. Pay with airtime");
                        Console.WriteLine("2. Pay with card");
                        int pa = int.Parse(Console.ReadLine());

                        if (pa == 1)
                        {
                            Console.WriteLine("You have successfully purchased VC minutes. An sms of confirmation will be sent to you.");
                        Environment.Exit(0);
                        }
                        else if (pa == 2)
                        {
                            Console.WriteLine("Enter card details");
                            Console.WriteLine("Enter card number:");
                            long cardNum = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter cvv:");
                            int cvv = int.Parse(Console.ReadLine());
                            Console.WriteLine("You have successfully purchased VC minutes. An sms of confirmation will be sent to you.");
                        Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection");
                        }
                    }
                    else if (days == 4)
                    {
                        Today();
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection");
                    }
                }
            }
            private static void AnyNetwork()
            {
                while (true)
                {
                    Console.WriteLine("1. 10 min to use now - R3.20");
                    Console.WriteLine("2. 60 min to use now - R9.50");
                    Console.WriteLine("3. 60 min(Today) - R12");
                    Console.WriteLine("4. Back");
                    Console.WriteLine("Select an option");
                    int anytime = int.Parse(Console.ReadLine());
                    if (anytime == 1)
                    {
                        Console.WriteLine("You have selected 10 minutes to use now for R3.20");
                        Console.WriteLine("Proceed to payment");
                        Console.WriteLine("Select payment method");
                        Console.WriteLine("1. Pay with airtime");
                        Console.WriteLine("2. Pay with card");
                        int pa = int.Parse(Console.ReadLine());

                        if (pa == 1)
                        {
                            Console.WriteLine("You have successfully purchased 10 minutes. An sms of confirmation will be sent to you.");
                        Environment.Exit(0);
                        }
                        else if (pa == 2)
                        {
                            Console.WriteLine("Enter card details");
                            Console.WriteLine("Enter card number:");
                            long cardNum = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter cvv:");
                            int cvv = int.Parse(Console.ReadLine());
                            Console.WriteLine("You have successfully purchased 10 minutes. An sms of confirmation will be sent to you.");
                        Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection");
                        }
                    }
                    else if (anytime == 2)
                    {
                        Console.WriteLine("You have selected 60 minutes to use now for R9.50");
                        Console.WriteLine("Proceed to payment");
                        Console.WriteLine("Select payment method");
                        Console.WriteLine("1. Pay with airtime");
                        Console.WriteLine("2. Pay with card");
                        int pa = int.Parse(Console.ReadLine());

                        if (pa == 1)
                        {
                            Console.WriteLine("You have successfully purchased 60 minutes. An sms of confirmation will be sent to you.");
                        Environment.Exit(0);
                        }
                        else if (pa == 2)
                        {
                            Console.WriteLine("Enter card details");
                            Console.WriteLine("Enter card number:");
                            long cardNum = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter cvv:");
                            int cvv = int.Parse(Console.ReadLine());
                            Console.WriteLine("You have successfully purchased 60 minutes. An sms of confirmation will be sent to you.");
                        Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection");
                        }

                    }
                    else if (anytime == 3)
                    {
                        Console.WriteLine("You have selected 60 minutes to use today for R12");
                        Console.WriteLine("Proceed to payment");
                        Console.WriteLine("Select payment method");
                        Console.WriteLine("1. Pay with airtime");
                        Console.WriteLine("2. Pay with card");
                        int pa = int.Parse(Console.ReadLine());

                        if (pa == 1)
                        {
                            Console.WriteLine("You have successfully purchased 60 minutes. An sms of confirmation will be sent to you.");
                        Environment.Exit(0);
                        }
                        else if (pa == 2)
                        {
                            Console.WriteLine("Enter card details");
                            Console.WriteLine("Enter card number:");
                            long cardNum = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter cvv:");
                            int cvv = int.Parse(Console.ReadLine());
                            Console.WriteLine("You have successfully purchased 60 minutes. An sms of confirmation will be sent to you.");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection");
                        }
                    }
                    else if (anytime == 4)
                    {
                        voice();
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection");
                    }
                }
            }
            private static void dataBundle()
            {
                while (true)
                {
                    Console.WriteLine("Data");
                    Console.WriteLine("1. Hour");
                    Console.WriteLine("2. Today");
                    Console.WriteLine("3. 7 days");
                    Console.WriteLine("4. Back");
                    Console.WriteLine("Select an option");
                    int dataBundles = int.Parse(Console.ReadLine());
                    if (dataBundles >= 1 && dataBundles <= 4)
                    {
                        switch (dataBundles)
                        {
                            case 1:
                                DataHour();
                                break;
                            case 2:
                                TodayData();
                                break;
                            case 3:
                                DataDays();
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection");
                    }
                }
            }
            private static void DataHour()
            {
                while (true)
                {
                    Console.WriteLine("1. 100 MB for an hour - R5");
                    Console.WriteLine("2. 1GB for an hour - R29");
                    Console.WriteLine("3. 250MB for an hour - R13");
                    Console.WriteLine("4. Back");
                    Console.WriteLine("Select an option");
                    int hour = int.Parse(Console.ReadLine());

                    if (hour == 1 || hour == 2 || hour == 3)
                    {
                        Console.WriteLine("Proceed to payment");
                        Console.WriteLine("Select payment method");
                        Console.WriteLine("1. Pay with airtime");
                        Console.WriteLine("2. Pay with card");
                        int pay = int.Parse(Console.ReadLine());

                        if (pay == 1)
                        {
                            Console.WriteLine("You have successfully purchased data bundles for an hour.An sms of confirmation will be sent");
                        Environment.Exit(0);
                        }
                        else if (pay == 2)
                        {
                            Console.WriteLine("Enter card details");
                            long card = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter card number: ");
                            int cvv = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter cvv");
                            Console.WriteLine("You have successfully purchased data bundles for an hour. An sms of confirmation will be sent to you.");
                        Environment.Exit(0);
                        }
                    }
                    else if (hour == 4)
                    {
                        dataBundle();
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection");
                    }
                }
            } private static void TodayData()
            {
                while (true)
                {

                    Console.WriteLine("1. 2GB data for today - R32");
                    Console.WriteLine("2. 300MB data for today - R13");
                    Console.WriteLine("3. 1.2GB dat for today - R25");
                    Console.WriteLine("4. Back");
                    Console.WriteLine("Please select an option");
                    int option = int.Parse(Console.ReadLine());

                    if (option == 1 || option == 2 || option == 3)
                    {
                        Console.WriteLine("You have selected data bundles to use today");
                        Console.WriteLine("Proceed to payment");
                        Console.WriteLine("Select payment method");
                        Console.WriteLine("1. Pay with airtime");
                        Console.WriteLine("2. Pay with card");
                        int pay = int.Parse(Console.ReadLine());
                        if (pay == 1)
                        {
                            Console.WriteLine("You have successfully purchased data bundles for today.An sms of confirmation will be sent.");
                        Environment.Exit(0);
                        } else if (pay == 2)
                        {

                            Console.WriteLine("Enter card details");
                            long card = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter card number: ");
                            int cvv = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter cvv");
                            Console.WriteLine("You have successfully purchased data bundles for a day. An sms of confirmation will be sent to you.");
                        Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection");
                        }
                    }
                    else if (option == 4)
                    {
                        dataBundle();
                    }
                }
            } private static void DataDays()
            {
                while (true)
                {
                    Console.WriteLine("1. 1.5 GB for 3 Days - R32");
                    Console.WriteLine("2. 5GB + 5GB NO 7 Days - R49");
                    Console.WriteLine("3. 2GB + 2GB NO + 2GB Tik tok + 2GB YouTube - R99");
                    Console.WriteLine("4. Back");

                    int option = int.Parse(Console.ReadLine());
                    if (option == 1 || option == 2 || option == 3)
                    {
                        Console.WriteLine("You have selected data bundles for days.");
                        Console.WriteLine("Proceed to payment. Select payment method.");
                        Console.WriteLine("1. Pay with airtime");
                        Console.WriteLine("2. Pay with card");
                        int payment = int.Parse(Console.ReadLine());

                        if (payment == 1)
                        {
                            Console.WriteLine("You have successfully purchased data bundles. An sms of confirmation will be sent.");
                        Environment.Exit(0);
                        }
                        else if (payment == 2)
                        {

                            Console.WriteLine("Enter card details");
                            long card = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter card number: ");
                            int cvv = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter cvv");
                            Console.WriteLine("You have successfully purchased data bundles . An sms of confirmation will be sent to you.");
                        Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection");
                        }
                    }
                    else if (option == 4)
                    {
                        dataBundle();
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection");
                    }
                }
            } private static void exit()
            {
                while (true)
                {
                    Console.WriteLine("Thank you for using my Vodacom");
                Environment.Exit(0);
                }
            }
        } }
