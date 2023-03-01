



var doubleArr = new double[] { 10.3, 4, 17.3, 3.3 }; 
var intArr = new int[] { 10, 4, 17, 3 };


Sort(doubleArr);

Sort(intArr);

foreach (var item in doubleArr)
{
    Console.Write($"{item} ");
}

Console.WriteLine();


foreach (var item in intArr)
{
    Console.Write($"{item} ");
}


//Metoda generyczna może przyjmować parametry oraz zwracać wartość różnego typu w zależności od wywołania. Poniższa metoda zwraca typ generyczny i pobiera parametr generyczny. A więc jeśli podamy jako parametr typ string zostanie również zwrócony typ string, natomiast jeśli podamy jako parametr typ int to metoda zwróci wartość typu int.


static void Sort<T>(T[] arr) where T : IComparable
{
    T temp;
    for (int j = 0; j <= arr.Length - 2; j++)
    {
        for (int i = 0; i <= arr.Length - 2; i++)
        {
            if (arr[i].CompareTo(arr[i + 1]) > 0)
            {
                temp = arr[i + 1];
                arr[i + 1] = arr[i];
                arr[i] = temp;
            }
        }
    }
}
