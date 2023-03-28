// See https://aka.ms/new-console-template for more information

PrintThousand();

Threes();

numbersEqual(2, 2);

isEven(800);

isNegative(-100);

isVoting();

static void PrintThousand()
{
    for (int i = 1000; i >= -1000; i--)
    {
        Console.WriteLine(i);

    }

    

}

static void Threes()
{
    for(int k = 3; k <= 999; k += 3)
    {
        Console.WriteLine(k);
    }
}

static bool numbersEqual(int num1, int num2)
{

    var check = (num1 == num2) ? true : false;

    return check;
}

static bool isEven(int i)
{
  if (i % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

static string isNegative(int num)
{

    var view = (num <= 0) ? "negative" : "positive";

    Console.WriteLine($"This number is {view} ");

    return view;
    
}

static void isVoting()
{
    Console.WriteLine("Hello, how old are you?");

    int userAge = 35;

    if(userAge < 18)
    {
        Console.WriteLine("Sorry, you are not old enough to vote.");
    }
    else
    {
        Console.WriteLine("Please select a candidate");

    }


}

