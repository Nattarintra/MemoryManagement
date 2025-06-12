using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne.StackAndHeap
{
    internal class QAndA
    {
       

        public static void Stack()
        {
            int x = 10; // Stack memory allocation for a primitive type

            // Value type copied by value
            int y = x;     // y = 10 (a copy)
            y = 20;
            Console.WriteLine(x); // Output: 10 (x is unchanged)
        }
        public static void Heap()
        {
            // Heap: Object created with 'new'
            Person person1 = new Person(); // The object is stored in the heap
            person1.Name = "Alice";

            Person person2 = person1; // person2 gets the same reference

            person2.Name = "Bob";

            Console.WriteLine(person1.Name); // Output: "Bob" because both variables point to the same object

        }

        internal class Person
        {
            public string Name { get; internal set; }
        }
        /** 
        * Q:  Hur fungerar stacken och heapen? Förklara gärna med exempel eller skiss på dess grundläggande funktion
        * A:  Stack memory is used for static memory allocation, where variables are stored in a last-in-first-out manner.
        *     Heap memory is used for dynamic memory allocation, where objects are allocated and deallocated at runtime.
        *     Stack is a type of memory that works in a Last In, First Out (LIFO) way. It's used to store temporary data like function parameters and local variables. When a function is called, its data is pushed onto the stack. When the function finishes, the memory is automatically cleared. You don’t need to worry about cleaning it up — it happens on its own.

              Heap is used for storing data that needs to live longer or has a bigger size, like objects, classes, and arrays.
              These are created using the new keyword, and they are accessed through references stored on the stack. 
              Heap memory doesn't get cleared immediately, but in C# you don’t have to delete it yourself — 
              the Garbage Collector will automatically clean up objects that are no longer being used.
        
        */

        /**
         * Q: Vad är Value Types respektive Reference Types och vad skiljer dem åt?
         *
         * A: In the Stack() method above, we see an example of Value Types.
              When we write int y = x;, we are copying the actual value of x into y.
              Later, when we change y to 20, it does not affect x, because x and y are stored in separate memory locations in the stack.

              But with Reference Types,the situation is different The data (object) — like a Person — is stored in the heap.
              In the Heap() method, we are dealing with Reference Types.We create a new object using new Person(), 
              which is stored in the heap.Then, we set person2 = person1; — this does not create a new object, 
              it just means that person2 points to the same object as person1.

              So when we write person2.Name = "Bob";, it changes the same object that person1 is pointing to.
              As a result, person1.Name also becomes "Bob", because both variables refer to the same object in memory.
         */

        /**
         *  Question number 3 also similar answer to question number 2, it points to the same object.
         */
    }
}
