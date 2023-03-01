// See https://aka.ms/new-console-template for more information
using ConsoleApp2;

class Program
{

    //Delegat jest typem, który reprezentuje odwołania do metod z określoną listą parametrów i zwracany typ. Podczas tworzenia wystąpienia delegata można skojarzyć jego wystąpienie z dowolną metodą mającą zgodny podpis i zwracany typ. Za pośrednictwem wystąpienia delegata można wywołać metodę.
    public delegate int Com<in T>(T x, T y);

    static void Main()
    {
        var t1 = new Towar(1);
        var t2 = new Towar(10);
        var t3 = new Towar(9);
        var t4 = new Towar(3);

        var arr = new [] { t1, t2, t3, t4 };

        Com<Towar> del = PorownajTowar;

        Sort<Towar>(del, arr);

        foreach (var item in arr)
        {
            Console.WriteLine(item.Value);
        }
    }

    static void Sort<T>(Com<T> comparison, T[] arr) where T : class
    {
        T temp;
        for (int j = 0; j <= arr.Length - 2; j++)
        {
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                if(comparison(arr[i], arr[i + 1]) > 0)
                {
                    temp = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = temp;
                } 
            }
        }
    }


    static int PorownajTowar(Towar t1, Towar t2)
    {
        if(t1.Value > t2.Value) 
            return 1;

        return 0;
    }
}


