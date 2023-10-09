Console.WriteLine("Enter a sum to convert from dollars to pennies");
string response = Console.ReadLine();
int ResponseInt = Convert.ToInt32(response);
int ConvertedInt = (100 * ResponseInt);
Console.WriteLine("If we convert " +ResponseInt + "$ to pennies we will have " + ConvertedInt + "¢ cents");
Console.ReadKey();