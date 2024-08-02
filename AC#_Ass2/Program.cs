using System.Collections;
using System.Dynamic;

namespace AC__Ass2
{
    internal class Program
    {

        public static void Reverse(ArrayList arraylist)
        {
            if (arraylist is not null) 
                for (int i = arraylist.Count-1; i>=0 ;i--)
                    Console.Write($"{arraylist[i]}  ");
        }
        static void Main(string[] args)
        {
            #region Question1:Write a Report about all Collections Given in the Session and Compare [Structure, Time Complexity, and Business Case With Implemented Examples]

            #region ArrayList
            /*ArrayList:
               Structure: ArrayList is a dynamic array that can resize itself automatically when required.

               Time Complexity:
               Access: O(1)
               Search: O(n)
               Insertion/Deletion (at the end): O(1)
               Insertion/Deletion (in the middle): O(n)

               Business Case: ArrayList is suitable when fast random access and fast insertions/deletions
               at the end are required.*/

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add("Hello");
            //arrayList.Remove("Hello"); 
            #endregion

            #region List

            /*List (Generic List in C#):
            Structure: List is a generic dynamic array.

            Time Complexity:
            Access: O(1)
            Search: O(n)
            Insertion/Deletion (at the end): O(1)
            Insertion/Deletion (in the middle): O(n)

            Business Case: List is versatile and widely used when a resizable array with strong typing is needed.*/

            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Remove(1);


            #endregion

            #region LinkedList

            /*LinkedList:
            Structure: LinkedList is a doubly linked list where each element is stored in a separate node.

            Time Complexity:
            Access: O(n)
            Search: O(n)
            Insertion/Deletion: O(1)

            Business Case: LinkedList is useful when frequent insertions and deletions are required,
            especially in scenarios where elements need to be frequently added or removed
            from the middle of the list.*/

            //LinkedList<int> linkedList = new LinkedList<int>();
            //linkedList.AddLast(1);
            //linkedList.AddLast(2);
            //linkedList.RemoveFirst();

            #endregion

            #region Queue

            /* Queue:
             Structure: Queue is a FIFO (First In, First Out) data structure.

             Time Complexity:
              Enqueue: O(1)
              Dequeue: O(1)
              Peek: O(1)

              Business Case: Queue is commonly used in scenarios where elements are 
              processed in the order they were added, like in task scheduling 
              or breadth-first search algorithms.*/

            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Dequeue();



            #endregion

            #endregion


            #region Part 2

            #region Question1

            //ArrayList arrayList = new ArrayList();
            //arrayList.AddRange(new int[] {1,2,3,4,5});


            //foreach (int i in arrayList) Console.Write($"{i}  ");
            //Console.WriteLine();
            //Console.WriteLine("======================================");
            //Console.WriteLine("After Reverse Function");

            //Reverse(arrayList);






            #endregion

            #region Question 2
            //List<int> Numbers = new List<int>();
            //Numbers.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } );
            //foreach (int i in Numbers) Console.Write($"{i}  ");
            //Console.WriteLine();

            //for (int i = 0; i < Numbers.Count; i++)
            //{

            //    if (Numbers[i]%2== 0) Console.Write($"{Numbers[i]}  ");

            //}



            #endregion

            #region Question 3

            //FixedSizeList<int> list = new FixedSizeList<int>(5);
            //list.ADD(1);
            //list.ADD(2);
            //list.ADD(3);
            //list.ADD(4);
            //list.ADD(5);


            //Console.WriteLine(list.Get(0));
            //Console.WriteLine(list.Get(1));
            //Console.WriteLine(list.Get(2));
            //Console.WriteLine(list.Get(3));


            #endregion




            #endregion




        }

       
    }
}
