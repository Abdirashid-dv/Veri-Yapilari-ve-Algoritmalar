using DataStructures.Array;
using DataStructures.LinkedList.Singly;

var linkedList = new SinglyLinkedList<string>();
linkedList.AddLast("Omer");
linkedList.AddLast("Osman");
linkedList.AddLast("Harun");
linkedList.AddLast("Kayra");
linkedList.AddLast("Caner");

// System.Console.WriteLine(linkedList.Head);
// System.Console.WriteLine(linkedList.Head.Next);
// System.Console.WriteLine(linkedList.Head.Next.Next);
// System.Console.WriteLine(linkedList.Head.Next.Next.Next);
// System.Console.WriteLine(linkedList.Head.Next.Next.Next.Next);

// var c = linkedList.Head;

// while (c != null)
// {
//     System.Console.WriteLine(c);
//     c = c.Next;
// }

// foreach (var item in linkedList)
// {
//     if (item.Contains("a"))
//     {
//         System.Console.WriteLine(item);
//     }
// }
// var node = new SinglyLinkedListNode<string>("Omer");

// var node1 = new SinglyLinkedListNode<string>();
// node1.Value = "Enes";
// node.Next = node1;

// var node2 = new SinglyLinkedListNode<string>();
// node2.Value = "Emre";
// node1.Next = node2;

// var node3 = new SinglyLinkedListNode<string>();
// node3.Value = "Gülsüm";
// node2.Next = node3;

// var node4 = new SinglyLinkedListNode<string>();
// node4.Value = "Peri";
// node3.Next = node4;


// var current = node.Next;

// while (current != null)
// {
//     System.Console.WriteLine(current.Value);
//     current = current.Next;
// }



// public class Program
// {
//     public static void Main()
//     {
//         var array = new DataStructures.Array.Array<int>();
//         array.Add(1);
//         array.Add(2);
//         array.Add(3);
//         array.Add(4);
//         array.Add(5);
//         array.Add(6);

//         array.RemoveAt(2);

//         foreach (var item in array)
//         {
//             System.Console.WriteLine($"Item: {item,5} {array.Count,5}  {array.Capacity}");
//         }

//         StaticArray<string>();
//     }

//     static void StaticArray<T>()
//     {
//         var names = new DataStructures.Array.StaticArray<string>();

//         names.SetItem(0, "Enes");
//         names.SetItem(1, "Emre");
//         names.SetItem(2, "Gülsüm");
//         names.SetItem(3, "Peri");
//         // names.SetItem(4,"Emircan");

//         for (int i = 0; i < names.Length; i++)
//         {
//             System.Console.WriteLine(names.GetItem(i));
//         }

//         Console.ReadLine();
//     }
// }
