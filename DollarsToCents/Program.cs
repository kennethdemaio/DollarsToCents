bool RunProgram = true;
while (RunProgram){

    Console.WriteLine("Enter a sum to convert from dollars to pennies(whole numbers only)");
    string response = Console.ReadLine();
    if (float.TryParse(response, out var ResponseInt)){
        float ConvertedInt = (100 * ResponseInt);
        Console.WriteLine("If we convert " + ResponseInt + "$ to pennies we will have " + ConvertedInt + "¢ cents");
    }
    else{
        Console.WriteLine("invalid input");
    }

    bool QuestionAgain = true;
    while (QuestionAgain){
        Console.WriteLine("Do you want to run another conversion? Y/N");
        string response2 = Console.ReadLine().ToUpper();
        if(response2 == "Y" || response2 == "YES"){
            RunProgram = true;
            QuestionAgain = false;
        }
        else if(response2 == "N" || response2 == "NO"){
            Console.WriteLine("Have a nice day");
            RunProgram = false;
            QuestionAgain = false;
        }
        else{
            Console.WriteLine("Please enter Y or N");
        }
    }
}