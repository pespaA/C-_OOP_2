using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Session2.Inheritance;

namespace OOP_Session2
{
    internal class Demo
    {
        #region Overloading
        public static int Sum(int x , int y)
        {
            return x + y;
        }
        public static int Sum(int x, int y,int z)
        {
            return x + y;
        }
        public static double Sum(double x, int y)
        {
            return x + y;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Sum(int x, double y)
        {
            return x + y;
        }
        #endregion
        public static void Demo0()
        {
            #region Indexer
            //PhoneBook Note = new PhoneBook(3);
            //Note.AddPerson(0,"omar",123);
            //Note.AddPerson(1, "Ahmed", 456);
            //Note.AddPerson(2, "Mokhtar", 789);
            ////Note.SetNumber("omar", 2456245);
            ////Console.WriteLine(Note.GetNumber("omar"));
            ////Number[0]= 20;
            //Note["omar"] = 555; // Using Indexer AS Setter
            //Console.WriteLine(Note["omar"]); // Using Indexer AS Getter

            //string Name = "OMAR";
            //Console.WriteLine(Name[1]);
            #endregion

            #region Class
            //Car C1;
            //// Declre For Referance From Type "Car", Refereint To Null
            //// Can Refer To An Object From Type Car Or An Object From Another Class
            //// Inheriting From Car
            //// CLR Will Allocate 4 Bytes For The Referece At Stac
            //// CLR Will Allocate 0 Bytes At Heap
            ////-----------------------------
            //C1 = new Car(100 , "BMW", 150);
            //Car C2 = new Car(100 , "BMWasdasd", 150);
            //// new :
            //// 1- Allocate Required Bytes For The Object At Heap 16 Bytes
            //// 2- Intialize The Allocated Bytes Of The Object With The Default Values Of It Is DateType
            //// 3- Call User Defind Constructor [ IF Exists]
            //// 4- Assign The Addres Of The Allocated object At Heap To The Reference C1
            ////---------------------------------
            //Console.WriteLine(C1);
            //Console.WriteLine(C2);
            #endregion

            #region Inheritance
            //Chiled chiled = new Chiled(1,2,3);
            //Console.WriteLine(chiled);

            #endregion

            #region Relationships Between Classes

            #endregion

            #region Access Modifiers (Private Protacted - Protacted - Internal Protected)

            #endregion

            #region Class Vs Struct

            #endregion

            #region Polymorephism

            #region Overloading
            //int result  = Sum(2, 11);
            //Console.WriteLine(result);
            //Console.WriteLine("Oamr");
            //Console.WriteLine('a');
            //Console.WriteLine(4);
            //Console.WriteLine(4.5f);


            #endregion
            #region Overriding
             // code in common 3
            #endregion

            #endregion
        }
    }
}
