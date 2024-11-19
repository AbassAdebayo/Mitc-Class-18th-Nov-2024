// See https://aka.ms/new-console-template for more information


//Console.Write("Enter figure: ");
//int figure = Convert.ToInt32(Console.ReadLine());


//switch(figure)
//{
//    case 0:
//        Console.WriteLine("Zero");
//        break;
//    case 1:
//        Console.WriteLine("One");
//        break;
//    case 2:
//        Console.WriteLine("Two");
//        break;
//    case 3:
//        Console.WriteLine("Three");
//        break;
//    case 4:
//        Console.WriteLine("Four");
//        break;
//    case 5:
//        Console.WriteLine("Five");
//        break;
//    case 6:
//        Console.WriteLine("Six");
//        break;
//    case 7:
//        Console.WriteLine("Seven");
//        break;
//    case 8:
//        Console.WriteLine("Eight");
//        break;
//    case 9:
//        Console.WriteLine("Nine");
//        break;
//    case 10:
//        Console.WriteLine("Ten");
//        break;
//    default:
//        Console.WriteLine("Invalid figure");
//        break;
//}

//Console.Write("Enter value for n: ");
//int n = Convert.ToInt32(Console.ReadLine());

//int smallest = int.MaxValue;
//int largest = int.MinValue;

//for (int i = 0; i < n; i++)
//{
//    Console.Write($"Enter integer {i + 1}: ");
//    int num = Convert.ToInt32(Console.ReadLine());

//    if (num < smallest)
//    {
//        smallest = num;
//    }
//    else if (num > largest)
//    {
//        largest = num;
//    }
    
//}

//Console.WriteLine($"Smallest number is {smallest}");
//Console.WriteLine($"Largest number is {largest}");

//Console.Write("Enter value for 'N': ");
//int n = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter value for 'K': ");
//int k = Convert.ToInt32(Console.ReadLine());

//long nFactorial = 1;
//long kFactorial = 1;

//while(n > 0)
//{
//    nFactorial *= n;
//    n--;
//}

//for(int i = k; i > 0; i--)
//{
//    kFactorial *= i;

//}

//Console.WriteLine($"N!/K! => {nFactorial}/ {kFactorial} = {nFactorial / kFactorial}");


//string[] suits = { "Heart", "Diamond", "Club", "Spades" };
//string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

//foreach(string suit in suits)
//{
//    foreach(string rank in ranks)
//    {
//        Console.WriteLine($"{rank} of {suit}");
//    }
//}

// for(int i = 0; i < 52; i++)
// {
//     string suit = "";
//     string rank = "";

//     switch(i / 13)
//     {
//         case 0:
//             suit = "Heart";
//             break;

//         case 1:
//             suit = "Diamond";
//             break;

//         case 2:
//             suit = "Club";
//             break;

//         case 3:
//             suit = "Spades";
//             break;
//     }

//     switch(i % 13)
//     {
//         case 0:
//             rank = "Ace";
//             break;

//         case 1:
//             rank = "2";
//             break;

//         case 2:
//             rank = "3";
//             break;

//         case 3:
//             rank = "4";
//             break;

//         case 4:
//             rank = "5";
//             break;

//         case 5:
//             rank = "6";
//             break;

//         case 6:
//             rank = "7";
//             break;

//         case 7:
//             rank = "8";
//             break;

//         case 8:
//             rank = "9";
//             break;

//         case 9:
//             rank = "10";
//             break;

//         case 10:
//             rank = "J";
//             break;

//         case 11:
//             rank = "Q";
//             break;

//         case 12:
//             rank = "K";
//             break;

           
//     }
//     Console.WriteLine($"{rank} of {suit}");
// }


        