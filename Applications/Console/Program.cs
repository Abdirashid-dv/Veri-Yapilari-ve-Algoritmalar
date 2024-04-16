using DataStructures.Array;
using DataStructures.LinkedList.Doubly;
using DataStructures.LinkedList.Singly;

// var numbers = new DataStructures.Array.Array<int>();

// var result = numbers.ContainsDuplicate(new int[] { 1, 1, 3, 4, 5, 6, 7, 8, 9, 10 });
// Console.WriteLine(result);

NewMethod();

static void NewMethod()
{
    var array = new DataStructures.Array.Array<int>();
    array.Add(1);
    array.Add(2);
    array.Add(3);
    array.Add(4);
    array.Add(5);

    var expectedList = new SinglyLinkedList<int>();
    expectedList.AddLast(1);
    expectedList.AddLast(2);
    expectedList.AddLast(3);
    expectedList.AddLast(4);
    expectedList.AddLast(5);


    var actualList = array.ToSingleLinkedList();

    var expected = expectedList.GetEnumerator();
    var actual = actualList.GetEnumerator();

    while (expected.MoveNext() && actual.MoveNext())
    {
        Console.WriteLine($"Expected: {expected.Current} Actual: {actual.Current}");
    }
}

NewMethod1();

static void NewMethod1()
{
    var linkedList = new SinglyLinkedList<int>(); // 1,2,3,4
    linkedList.AddLast(1);
    linkedList.AddLast(2);
    linkedList.AddLast(3);
    linkedList.AddLast(4);
    linkedList.AddLast(4);

    var test2 = new SinglyLinkedList<int>();
    test2.AddLast(1); // 1,2,3,4,5
    test2.AddLast(2);
    test2.AddLast(3);
    test2.AddLast(4);
    test2.AddLast(5);



    var reversedList = linkedList.ReverseList(linkedList.Head); // 4,3,2,1
    var reversedList2 = test2.ReverseList(test2.Head); // 5,4,3,2,1

    var expected = reversedList2.GetEnumerator();
    var actual = reversedList.GetEnumerator();

    while (expected.MoveNext() && actual.MoveNext())
    {
        Console.WriteLine($"Expected: {expected.Current} Actual: {actual.Current}");
    }
}

// var linkedlist = new DoublyLinkedList<char>("Samsun".ToArray());
// foreach (var item in linkedlist)
// {
//     System.Console.WriteLine(item);
// }

// Console.ReadKey();

// static void LinkedListTraverseSample()
// {
//     var linkedList = new SinglyLinkedList<int>(new int[] { 1, 2, 3, 4, 5, 6 });
//     var curr = linkedList.GetEnumerator();

//     while (curr.MoveNext())
//     {
//         System.Console.WriteLine(curr.Current);
//     }
// }

// static void DdNodeSample()
// {
//     var hafsa = new DbNode<string>("hafsa");
//     var samet = new DbNode<string>("samet");
//     var emircan = new DbNode<string>("emircan");
//     var bahar = new DbNode<string>("bahar");
//     var zehra = new DbNode<string>("zehra");
//     var ismail = new DbNode<string>("ismail");


//     hafsa.Next = zehra;
//     zehra.Next = samet;
//     zehra.Prev = hafsa;
//     samet.Next = ismail;
//     samet.Prev = zehra;
//     ismail.Next = new DbNode<string>("muhammed");
//     ismail.Prev = samet;
//     ismail.Next.Next = emircan;
//     ismail.Next.Prev = ismail;
//     emircan.Next = bahar;
//     emircan.Prev = ismail.Next;
//     bahar.Prev = emircan;

//     var head = hafsa;
//     var tail = bahar;

//     System.Console.WriteLine(head.Next == zehra); //hafsa,samet,true
//     System.Console.WriteLine(head.Next.Next); //samet
//     System.Console.WriteLine(head.Next.Next.Value); //samet
//     System.Console.WriteLine(tail); //bahar
//     System.Console.WriteLine(tail.Value); //bahar
//     System.Console.WriteLine(tail.Prev.Prev.Prev); //emircan,ismail
// }

// // DdNodeSample();
// // LinkedListTraverseSample();