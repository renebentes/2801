Console.Clear();

var meuArray = new int[5] { 1, 2, 3, 4, 5};
meuArray[0] = 12;

for (int index = 0; index < meuArray.Length; index++)
{
    Console.WriteLine(meuArray[index]);
}