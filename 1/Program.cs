// Дано 3-хзначное число, 
// пример: 123 => {1, 2. 3}
// a[0]= 1
// a[1]=2
// a[2]=3

void printArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
}

Console.WriteLine("Введите трехзначное число ->");
string number = Console.ReadLine();
int numberInt = int.Parse(number);

int [] array = new int[3];

array[0] = numberInt / 100;
array[1] = numberInt % 100 / 10;
array[2] = numberInt % 10;

printArray(array);