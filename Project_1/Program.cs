// Написать программу, которая из имеющего строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

Console.WriteLine("Заполните массив:\t"); 
int n = Convert.ToInt32(Console.ReadLine()); //конвертация массива из int в string 
 
string[] array = new string[n];  
for(int i = 0; i < n; i++) //заполняем массив с клавиатуры 
{ 
    Console.Write($"Введите элемент {i}:\t"); 
    array[i] = Console.ReadLine(); 
} 
 
string[] result = GetShortWordsArray(array); 

 
PrintArray(result); 
 
 
void PrintArray(string[] array) 
{ 
 for (int i = 0; i < array.Length; i++) 
 { 
  Console.Write($"{array[i]},");
  Console.Write(" ");
 } 
} 
 
// проверка массива на элементы <= 3 
 
string[] GetShortWordsArray(string[] array) 
{ 
    int length = array.Length; 
    string[] result = new string[length]; 
    int count = 0; 
    int Max_Word = 3; 

    for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i].Length <= Max_Word)  
        { 
            result[count] = array[i]; 
            count++; 
        } 
         
    } 
    return result; 
}

