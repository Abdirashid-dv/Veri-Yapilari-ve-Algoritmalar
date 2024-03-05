using DataStructures.Array;

var array = new DataStructures.Array.Array<int>();
array.Add(1);
array.Add(2);
array.Add(3);
array.Add(4);
array.Add(5);
array.Add(6);

array.RemoveAt(2);

foreach (var item in array)
{
    System.Console.WriteLine($"Item: {item,5} {array.Count,5}  {array.Capacity}");
}

static void StaticArray<T>()
{
    var names = new StaticArray<String>();

    names.SetItem(0, "Enes");
    names.SetItem(1, "Emre");
    names.SetItem(2, "Gülsüm");
    names.SetItem(3, "Peri");
    // names.SetItem(4,"Emircan");

    for (int i = 0; i < names.Length; i++)
    {
        System.Console.WriteLine(names.GetItem(i));
    }

    Console.ReadLine();
}
