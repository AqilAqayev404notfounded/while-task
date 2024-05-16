namespace CoreSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal resultTotal = 0;

            while (true)
            {
                Console.WriteLine("=============================================================================================");
                Console.WriteLine("=============================================================================================");
                string operatorName;
                int size;
                string color;

                #region Operator name validaiton

                while (true)
                {
                    Console.Write("Operator's name : ");
                    operatorName = Console.ReadLine();

                    if (operatorName.Length >= 3 && operatorName.Length <= 15)
                        break;
                    else
                        Console.WriteLine("Size dugun daxil edilmeyib");
                }

                #endregion

                #region Size validation

                while (true)
                {
                    Console.Write("Size : ");
                    size = int.Parse(Console.ReadLine());

                    if (size >= 30 && size <= 50)
                        break;
                    else
                        Console.WriteLine("Size dugun daxil edilmeyib");
                }

                #endregion

                #region Color validation

                while (true)
                {
                    Console.Write("Color : ");
                    color = Console.ReadLine();

                    if (color == "Red" || color == "Black" || color == "Blue")
                        break;
                    else
                        Console.WriteLine("Color dugun daxil edilmeyib");
                }

                #endregion

                #region Brand validation

                string brandName;
                while (true)
                {
                    Console.Write("Brand name : ");
                    brandName = Console.ReadLine();
                    if (brandName == "Puma" || brandName == "Adidas" || brandName == "Nike")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Adi duzgun daxil et");
                    }
                }

                #endregion
                //Short cut to replace all : Ctrl + RR

                #region category validation
                string category;
                while (true)
                {
                    Console.Write("Category : ");
                    category = Console.ReadLine();
                    if (category == "Clasic" || category == "Sport" || category == "Daily")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("duzgun kataqorya elave et");

                    }
                }

                #endregion
                #region price validation
                Console.Write("Price : ");
                decimal price;//Short cut to replace all : Ctrl + RR
                while (true)
                {
                    price = decimal.Parse(Console.ReadLine()); //Short cut to replace all : Ctrl + RR

                    if (price > 0)
                        break;
                    else
                        Console.WriteLine("Duzgun deyer daxil edin");
                }

                #endregion
                #region count validation
                Console.Write("Count : ");
                int count = 0;
                while (true)
                {
                    count = int.Parse(Console.ReadLine()); //Short cut to replace all : Ctrl + RR
                    if (count > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("sayi duzgun daxil edin");
                    }
                }
                #endregion
                decimal individualTotal = count * price;
                resultTotal = resultTotal + individualTotal;

                Console.WriteLine($"Size : {size},  Color : {color}, Brand name : {brandName}, Category : {category}, Price : {price}, Count : {count}, Total : {individualTotal}");
                Console.WriteLine("=============================================================================================");
                Console.WriteLine("=============================================================================================");

                Console.WriteLine("Yeni ayaqqabi elave olunsumu? (Yes, No) (Y, N) ");
                string loopTerminationResult = Console.ReadLine();

                if (loopTerminationResult == "No" || loopTerminationResult == "N")
                {
                    //break based loop control
                    break;

                }
            }


            Console.WriteLine("Result Total : " + resultTotal);

        }
    }
}