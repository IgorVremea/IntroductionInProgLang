void Method1(int count, string str){
    for(int i = 0; i < count; i++){
        Console.WriteLine(str);
    }
}

Method1(2, "String");
Console.WriteLine();
Method1(str: "Stroka", count: 5);

