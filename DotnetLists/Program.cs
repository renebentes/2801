Console.Clear();

var arr = new int[3]{ 1, 2, 3};

for (int i = 0; i < 10; i++)
{
    // IndexOutOfRangeException
    Console.WriteLine(arr[i]);
}