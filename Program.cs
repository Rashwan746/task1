// See https://aka.ms/new-console-template for more information
int costSmaal = 25;
int costLarge = 35;
double taxRate = 0.06;
Console.Write("Enter number of small carpets: ");
int smallCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of large carpets: ");
int largeCount = Convert.ToInt32(Console.ReadLine());
double costPeforeTax=(smallCount*costSmaal)+(largeCount*costLarge);
double tax= costPeforeTax * taxRate;
double costAfterTax = costPeforeTax + tax;
Console.WriteLine($"number of smaal carpets={smallCount}");
Console.WriteLine($"number of large carpets= {largeCount}");
Console.WriteLine($"price for small carpets= {costSmaal}");
Console.WriteLine($"price for large carpets= {costLarge}");
Console.WriteLine($"cost={costPeforeTax}");
Console.WriteLine($"tax={tax}");
Console.WriteLine($"total coast after tax={costAfterTax}");
Console.WriteLine("This estimate is valid for 30 days");