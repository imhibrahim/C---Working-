// See https://aka.ms/new-console-template for more information

//Console.WriteLine("D:ibrahimlacture\nhtml.pdf");

//float num = 123.12345678f;
//Console.WriteLine(num);
//decimal num2 = 12.1234567891011m;
//Console.WriteLine(num2);

//DateTime dt= DateTime.Now;
//Console.WriteLine(dt);
//Console.WriteLine("{0:d}",dt);
//Console.WriteLine("{0:D}", dt);
//Console.WriteLine("{0:f}", dt);
//Console.WriteLine("{0:F}", dt);

//int num1 = 23;
//int num2 = 25;
//Console.WriteLine(num1+num2);
//Console.WriteLine(num1 - num2);
//Console.WriteLine(num1 * num2);
//Console.WriteLine(num1 / num2);
//Console.WriteLine(num1 % num2);
//Console.WriteLine(num1==num2);

//int num3 = 1;
//Console.WriteLine(++num3);

//Console.WriteLine(++num3);

//String ans = (num1 > num2) ? "This is True" : "This is False";

//Console.WriteLine(ans);

//Console.WriteLine("Enter Name :-");
//String name=Console.ReadLine();
//Console.WriteLine("Enter mail:-");
//String mail = Console.ReadLine();
//if (name=="ibrahim" & mail=="admin")
//{
//    Console.WriteLine("Login.....");
//}
//else
//{
//    {
//        Console.WriteLine("Invalid mail....");
//    }
//}

//int num4=int.Parse(Console.ReadLine());
//int num5 = int.Parse(Console.ReadLine());

//Console.WriteLine(num4+num5);

//Console.WriteLine("Enter Percentage");
//int per = int.Parse(Console.ReadLine());

//if (per >= 90)
//{
//    Console.WriteLine("A+");
//}
//else if (per >= 80)
//{
//    Console.WriteLine("A");
//}
//else if (per >= 70)
//{
//    Console.WriteLine("B");
//}
//else if (per >= 60)
//{
//    Console.WriteLine("C");
//}
//else
//{
//    Console.WriteLine("E");
//}
//Console.WriteLine("Enter Your Week Day Number");
//int day= int.Parse(Console.ReadLine());

//switch (day)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//        case 2: Console.WriteLine("Tuesday");
//        break;
//        case 3: Console.WriteLine("Wednesday");
//        Console.WriteLine("Enter Your Name");
//        String name =Console.ReadLine();
//    switch(name)
//    {
//            case "ibrahim":
//        Console.WriteLine("Hello " + name + " Have nice Day");
//        break;
//    }

//        break;  
//        case 4: Console.WriteLine("Thursday");
//        break;
//        case 5: Console.WriteLine("Friday");
//        break;
//        case 6: Console.WriteLine("Saturday"); 
//        break;
//    default: Console.WriteLine("Invalid Number");
//        break;
//}

//Console.WriteLine("Enter Your Table numver :-");

//int num=int.Parse(Console.ReadLine());

//for (int i =1;i<=10;i++){
//    Console.WriteLine(num + " X "+ i + " = " + i*num);
//}
//int i = 1;
//while (i<1=0) {
//    Console.WriteLine(num + " X " + i + " = " + i * num);
//    i++;
//}
//int i = 1;
//do
//{
//    Console.WriteLine(num + " X " + i + " = " + i * num);
//       i++;
//}
//while (i <0);

//int amount = 5000;
//string pincode = "1234";

//Console.WriteLine("Welcome to Use Our ATM Machine");
//Console.WriteLine("Please Enter Your $ number Digit code");
//string code=Console.ReadLine();
//if (code==pincode)
//{
//    while (true) {

//        Console.WriteLine("" +
//            "1: Check The Amount:- \n" +
//            "2: Withdraw The Cash Amount:- \n" +
//            "3: Deposit Cash Amount:- \n"+
//            "4: Exit \n");

//        string choice= Console.ReadLine();
//        if (choice == "1")
//        {
//            Console.WriteLine("Your Remaining Balance is :- "+amount);
//        }
//        else if (choice=="2")
//        {
//            Console.WriteLine("Enter Your Cash Amount :- ");
//            int cash=int.Parse(Console.ReadLine());
//            amount-=cash;
//            Console.WriteLine("Transection Successfully ....... \n Your Remaining Balance is :-" + amount);
//        }
//        else if (choice == "3")
//        {
//            Console.WriteLine("Enter Your Withdraw Amount :- ");
//            int cash = int.Parse(Console.ReadLine());
//            amount += cash;
//            Console.WriteLine("Amount Inserted Successfully ....... \n Your Remaining Balance is :- " + amount);
//        }
//        else if (choice == "4")
//        {
//            Console.WriteLine("Thanks for Using To ATM");
//            break;

//        }
//        else {
//            Console.WriteLine("Invalid Number.....................");
//        }

//    }
//}
//else
//{
//    Console.WriteLine("Invalid Pin Code");
//}



//int[] data = new int[5];
//data[0] = 1;
//data[1] = 2;
//data[2] = 3;
//data[3] = 4;
//data[4] = 5;

//foreach(int i in data)
//{
//    Console.WriteLine(i);
//}

//int[] num = new int[] { 1,2,3,4};

//Console.WriteLine(num[1]);
//int[] n = {1,2,3,4,5};
//Console.WriteLine(n[1]);

int number = 10;

string result = (number > 5) ? "Greater than 5" : "Less than or equal to 5";

Console.WriteLine(result);































































