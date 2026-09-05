using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdvancedC_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1

            ////Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            //List<int> grades= new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            ////Print the collection, Count, first and last grade
            //foreach(int i in grades)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine($"Count: {grades.Count}");
            //Console.WriteLine($"first & last : {grades[0]} & {grades[grades.Count - 1]}");

            ////Sort the grades ascending, then print
            //grades.Sort();
            //Console.WriteLine("Sorted grades:");
            //foreach(int i in grades)
            //{
            //    Console.WriteLine(i);
            //}

            ////Get the first grade above 90
            //Console.WriteLine($"First grade above 90: {grades.Find(i => i > 90)}");

            ////Get all grades below 75(failing grades)
            //List<int> flag=grades.FindAll(i=>i < 75);
            //foreach (int i in flag)
            //{
            //    Console.WriteLine($"Failing grades: {i}");
            //}

            ////Remove all failing grades(below 75)
            //foreach (int i in flag)
            //{
            //    grades.Remove(i);
            //}

            ////Check if any grade equals 100
            //Console.WriteLine($"Any grade equals 100? {grades.Contains(100)}");

            ////Create a List<string> where each grade becomes "Grade: X"
            //List<string>gradesToString =grades.ConvertAll(i => $"Grade: {i}");
            //foreach (string s in gradesToString)
            //{
            //    Console.WriteLine(s);
            //}

            #endregion

            #region Exercise 2

            /* Create a leaderboard that automatically sorts players by score.*/

            ////Add: 500 = "Ahmed", 200 = "Sara", 800 = "Ali", 350 = "Mona"
            //SortedDictionary<int, string> board = new SortedDictionary<int, string>(); // عملت سيرش و طلعلي حلين يا اما بال LINQ او السورتيد ديكشنري 
            //board[500] = "Ahmed";
            //board[200] = "Sara";
            //board[800] = "Ali";
            //board[350] = "Mona";

            ////Print all entries (they should be sorted by score automatically)
            //foreach(KeyValuePair<int,string> i in board)
            //{
            //    Console.WriteLine($"Score: {i.Key}, Player: {i.Value}");
            //}

            ////Access the first key and first value 
            //Console.WriteLine($"first key = {board.First().Key}, first value = {board.First().Value}");

            ////Check if score 500 exists
            //Console.WriteLine($"Score 500 exists? {board.ContainsKey(500)}");

            ////Safely get the player with score 999
            //Console.WriteLine(board.TryGetValue(999,out string rs)? $"Player with score 999: {rs}" : "Player with score 999 not found");

            ////Remove the player with score 200 and print the updated list
            //board.Remove(200);
            //foreach (KeyValuePair<int, string> i in board)
            //{
            //    Console.WriteLine($"Score: {i.Key}, Player: {i.Value}");
            //}

            #endregion

            #region Exercise 3

            /* Build a phone book application.*/

            ////Create a Collection  with 4 contacts (name → phone number)
            //Dictionary<string, string> phoneBook = new Dictionary<string, string>
            //{
            //    { "Alice", "123-456-7890" },
            //    { "Bob", "987-654-3210" },
            //    { "Charlie", "555-555-5555" },
            //    { "David", "111-222-3333" }
            //};

            ////Add a new contact using [] syntax (add or update)
            //phoneBook["Jane"] = "444-555-6666";

            ////Try adding a duplicate using .Add() — catch the exception and print the error
            //try
            //{
            //    phoneBook.Add("Alice", "000-000-0000");

            //}
            //catch(Exception ex) 
            //{
            //        Console.WriteLine($"Error: {ex.Message}");
            //}

            //    //Try adding a duplicate using .TryAdd() — print whether it succeeded
            //    if (phoneBook.TryAdd("Alice", "000-000-0000"))
            //{
            //    Console.WriteLine("Contact added successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("Failed to add contact.");
            //}

            ////Search for a contact that doesn’t exist
            //if (phoneBook.TryGetValue("Ahmed",out string name))
            //{
            //    Console.WriteLine($"Contact found: {name}");
            //}
            //else
            //{
            //    Console.WriteLine("Contact not found.");
            //}

            ////Get a contact with a fallback of "Not Found"
            //// مش فاهمة السؤال عايز ايه

            ////Print all Keys on one line, then all Values on another line
            //foreach(KeyValuePair<string, string> k in phoneBook)
            //{
            //    Console.Write($"{k.Key} - ");
            //}
            //Console.WriteLine();

            //foreach(KeyValuePair<string, string> k in phoneBook)
            //{
            //    Console.Write($"{k.Value} , ");
            //}
            //Console.WriteLine();

            #endregion

            #region Exercise 4

            /*    Exercise 4: Unique Email Validator Use Collection to manage unique email addresses.*/

            //Create a HashSet<string> with a case-insensitive comparer: new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            //Add these emails: "ahmed@test.com", "AHMED@test.com", "sara@test.com", "Sara@Test.Com"
            HashSet<string> set = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "ahmed@test.com",
                "AHMED@test.com",
                "sara@test.com",
                "Sara@Test.Com"
            };

            //Print Count — how many are actually stored? Explain why.
            Console.WriteLine($"Count: {set.Count}");
            // ans => the hashset is case-insensitive so it will store the first two values as one unique value etc... , so the count will be 2

            //Create two sets: Set A = {1,2,3,4,5} and Set B = {4,5,6,7,8}
            HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            //Print the result of: UnionWith, IntersectWith, ExceptWith
            HashSet<int> unionSet = new HashSet<int>(setA);
            unionSet.UnionWith(setB);
            foreach (int i in unionSet)
            {
                Console.WriteLine($"Union: {i}");
            }

            HashSet<int> intersectSet = new HashSet<int>(setA);
            intersectSet.IntersectWith(setB);
            foreach (int i in intersectSet)
            {
                Console.WriteLine($"Intersection: {i}");
            }

            HashSet<int> exceptSet = new HashSet<int>(setA);
            exceptSet.ExceptWith(setB);
            foreach (int i in exceptSet)
            {
                Console.WriteLine($"Except: {i}");
            }

            //Use IsSubsetOf to check if {1,2} is a subset of Set A
            HashSet<int> st=new HashSet<int> { 1, 2 };
            Console.WriteLine($"Is {{1,2}} a subset of Set A? {st.IsSubsetOf(setA)}");

            #endregion

            #region Search

            // span<T> => نوع خفيف بيتعامل مع الميموري على طول من غير ما يضطر يدخل ال heap بيخلي الاداء احسن و بيقلل وجود ال garbage collector

            // sortedlist => بيخزن ال data على شكل two arrays واحد لل keys و واحد لل values و بيخلي ال keys sorted بياخد مساحة اقل في الميموري و اسرع في السيرش بس ابد انك تعرف ال index بتاع ال key اللي انت عايزه

            // SortedDictionary => بيخزن الداتا على شكل binary tree و سريع في الاضافة و الحذف بس بياخد مساحة اكتر في الميموري و مش بعرف ال index بتاع ال key اللي انت عايزه

            #endregion
        }
    }
}
