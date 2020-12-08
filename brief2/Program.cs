using System;



namespace brief2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            var product = new Article();
            while (true)
            {
                try
                {
                    Console.WriteLine("Welcome to store manager");
                    Console.WriteLine("Enter the type of operations");
                    Console.WriteLine("press z to show all product");
                    Console.WriteLine("press a to add a product");
                    Console.WriteLine("press d to delete a product");
                    Console.WriteLine("enter s to search for a product");
                    Console.WriteLine("enter m to modify a product");

                    string action = Console.ReadLine();
                   
                    switch (action)
                    {
                        case "a":
                            {
                                Console.WriteLine("enter product name");
                                string name = Console.ReadLine();
                                Console.WriteLine("enter product ref number");
                                int refNum = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("enter product price");
                                int price = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("enter product selling price");
                                int sellPrice = Convert.ToInt32(Console.ReadLine());
           
                                stock.add(refNum, name, price, sellPrice);
                                
                                Console.WriteLine(stock.article.Count); 

                                break;
                            }
                        case "z":
                            {
                                foreach (var item in stock.article)
                                {
                                    item.introduce();
                                } 
                                }
                                break;
                            
                        case "d":
                            {
                                for (var i = 0; i < stock.article.Count; i++)
                                {
                                    Console.WriteLine("product name :" +stock.article[i].name);
                                    Console.WriteLine("product index : "+i);
                                   
                                }
                                Console.WriteLine("enter the product index that you want to delete");
                                int index = Convert.ToInt32(Console.ReadLine());
                                stock.delete(index);

                                
                            }
                            break;
                        case "s":
                            {
                                Console.WriteLine("enter the product name that you are searching for");
                                string name = Console.ReadLine();
                                Console.WriteLine(stock.isExist(name));
                                break;
                            }
                        case "m":
                            {
                                for (var i = 0; i < stock.article.Count; i++)
                                {
                                    Console.WriteLine("product name :" + stock.article[i].name);
                                    Console.WriteLine("product index : " + i);

                                }
                                Console.WriteLine("enter the product index that you want to modify");
                                int index = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("enter name");
                                string name = Console.ReadLine();
                                Console.WriteLine("enter ref number");
                                int refName = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("enter price");
                                int price= Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("enter sell price");
                                int sellPrice = Convert.ToInt32(Console.ReadLine());
                                stock.modify(refName, name, price, sellPrice, index);

                                break;
                            }

                        default:
                            Console.WriteLine("Wrong action!! try again");
                            break;
                    }


                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.StackTrace);
                } 
            }
            
            
        }
    }
}
