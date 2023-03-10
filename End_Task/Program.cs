

Console.Clear();

string s1 = Input("Введите первое слово массива");
string s2 = Input("Введите второе слово массива");
string s3 = Input("Введите третье слово массива");
string s4 = Input("Введите четвертое слово массива");
string s5 = Input("Введите пятое слово массива");

Console.WriteLine();

string[] stArray = {s1, s2, s3, s4, s5};

for (int i = 0; i < stArray.Length; i++)
{
    Console.Write($"{stArray[i]} ");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Исключаем все строки, в которых колличество символов привышают 3");
Console.WriteLine();


for (int i = 0; i < stArray.Length; i++)
{
    if(stArray[i].Length <= 3)
    {
    Console.Write($"{stArray[i]} ");
    }
}


string Input(string message)
{
    Console.Write($"{message}: ");
    string res = Console.ReadLine();
    return res;
}





// Console.Clear();
// string[] stArray = {"Tea", "Coffe", "ice", "Apple", "Joker"};

// for (int i = 0; i < stArray.Length; i++)
// {
//     Console.Write($"{stArray[i]} ");
// }
// Console.WriteLine();
// Console.WriteLine("Исключаем все строки, в которых колличество символов привышают 3");
// Console.WriteLine();

// for (int i = 0; i < stArray.Length; i++)
// {
//     if(stArray[i].Length <= 3)
//     {
//     Console.Write($"{stArray[i]} ");
//     }
// }