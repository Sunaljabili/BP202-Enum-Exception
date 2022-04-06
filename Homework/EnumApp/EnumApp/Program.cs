using Models;
using System;
using Utils.Enums;

namespace EnumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            do
            {
                Console.WriteLine("Product elave etmek isteyiriz? y/n");
                string asnwer = Console.ReadLine();
                if (asnwer== "y")
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Productin adin daxil edin :");
                    string name = Console.ReadLine();
                    Console.WriteLine("Productun Qiymetini daxil edin :");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Type-in daxil edin :1.Baker,2.Drink,3.Meat,4.Diary");
                    int type = Convert.ToInt32(Console.ReadLine());
                    Product product = new Product
                    {
                        Name = name,
                        Price = price,
                        Type = (ProductType)type
                    };
                    store.AddProduct(product);
                }
                else
                {

                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                } 
            } while (true);

          

            bool check = true;

            while (check)
            {
                Console.WriteLine("Ashagidaki menudan birin secin.");
                Console.WriteLine("1.RemoveProductByNo  edin");
                Console.WriteLine("2.FilterProductsByType type gore filter edin.");
                Console.WriteLine("3.FilterProductByName ada gore filter edin");
                Console.WriteLine("0. Proqrami Bitir");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Bir nomre daxil edin :");
                        Console.BackgroundColor = ConsoleColor.Red;
                        int number = Convert.ToInt32(Console.ReadLine());
                        store.RemoveProductByNo(number);
                        store.GetInfo();
                        break;
                    case "2":
                        Console.WriteLine("Bir Type daxil daxil edin :1.Baker,2.Drink,3.Meat,4.Diary");
                        int type = Convert.ToInt32(Console.ReadLine());
                        foreach (var item in store.FilterProductsByType((ProductType)type))
                        {
                            Console.WriteLine($"Nomresi {item.No}  Adi-{item.Name} -- Qiymeti -- {item.Price}   Type : {item.Type}");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Productun adini  daxil edin :");
                        string name = Console.ReadLine();
                        foreach (var item in store.FilterProductByName(name))
                        {
                            Console.WriteLine($"Nomresi {item.No} Adi-{item.Name} -- Qiymeti -- {item.Price}   Type : {item.Type}");
                        }
                        break;

                    case "0":
                        store.GetInfo();
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Duzgun secim edin ");
                        break;
                }
            }


        }
    }
}
