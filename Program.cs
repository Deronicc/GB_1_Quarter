using System;
class GB_1_Quarter
{   
  public static string[] array_1 = {"hello", "2", "world", ":-)"};
  public static string[] array_2 = {"1234", "1567", "-2", "computer science"};
  public static string[] array_3 = {"Russia", "Denmark", "Kazan"};
   
  public static string[] SetArray(){
    Console.WriteLine("Введите количество строк в массиве");
    int n = int.Parse(Console.ReadLine()!);
    string[] string_array = new string[n];
    
    for (int i = 0; i < n; i++)
         {
             Console.WriteLine("Введите слово №{0}",i+1);
             string_array[i] = Console.ReadLine()!;
         }
        
    Console.WriteLine("Ваш массив: [{0}]", string.Join(", ", string_array));
    return string_array;
  }
    
  public static string[] CreateNewArray(string[] arr){
    int m = 0;
    for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
                {
                    m++;
                }
        }
    
    string[] result_array = new string[m];
    
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                result_array[j] = arr[i];
                j++;
            }
        }
        
    Console.WriteLine("Ответ: [{0}]", string.Join(", ", result_array));  
    return result_array;
  }
    
  static void Main() {
    Console.WriteLine("Выберите набор данных: \n1. ['hello', '2', 'world', ':-)'], \n2. ['1234', '1567', '-2', 'computer science'], \n3. ['Russia', 'Denmark', 'Kazan'], \n4. Ввод массива вручную");
    int x = int.Parse(Console.ReadLine()!);  
    switch (x) 
    {
        case 1: 
            CreateNewArray(array_1);
            break;
        case 2: 
            CreateNewArray(array_2);
            break;
        case 3: 
            CreateNewArray(array_3);
            break;
        case 4: 
            CreateNewArray(SetArray());
            break;
    }
  }
}