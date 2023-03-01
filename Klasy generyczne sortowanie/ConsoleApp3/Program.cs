

using ConsoleApp3;

var t1 = new Towar("D1", "Długopis", 3.14);
var t2 = new Towar("D2", "Długopis", 2.54);
var t3 = new Towar("D3", "Długopis", 5.24);
var t4 = new Towar("D4", "Długopis", 9.34);


DescriptionClass(t1, t2, t3, t4);


void DescriptionClass<T>(params T[] arr) where T : class
{
    foreach (var item in arr)
    {
        Type typeParameterType = typeof(T);

        var properties = typeParameterType.GetProperties();

        foreach (var property in properties)
        {
            Console.WriteLine($"{property.Name}: {property.GetValue(item)}");
        }

        Console.WriteLine("=================");
    }
}