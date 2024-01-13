string name;
do{
    Console.Write("Enter your name: ");
    name = Console.ReadLine();

    if(name.ToLower() == "masha"){
        Console.WriteLine("HURAY, this is Masha");
    } else {
        Console.Write("hi, ");
        Console.WriteLine(name);
    }
} while(name != "ExIt");

