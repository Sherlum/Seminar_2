// Дано 3-хзначное число, 
// пример: 123 => {1, 2. 3}
// a[0]= 1
// a[1]=2
// a[2]=3

Console.WriteLine("Введите трехзначное число.\nВыхода из программы команда Exit.");
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("exit"))
            Console.WriteLine("{0}->{1}",input, input[1]);
        else
            break;
    }