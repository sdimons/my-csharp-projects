﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Arrays *****\n");
            SimpleArrays();
            ArrayInitialization();
            DeclareImplicitArrays();
            ArrayOfObjects();
            RectMultidimensionalArray();

            JaggedMultidimensionalArray();
            PassAndReceiveArrays();
            SystemArrayFunctionality();

            Console.ReadLine();
        }

        #region Simple Array
        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation.");
            // Создать и заполнить массив из трех элементов типа int
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            // Вывести все значения.
            foreach (int i in myInts)
                Console.WriteLine(i);
            Console.WriteLine();
        }
        #endregion

        #region Array Init Syntax
        static void ArrayInitialization()
        {
            Console.WriteLine("=> Array Initialization.");

            // Инициализации массива 
            // с использованием ключевого слова new.
            string[] stringArray = 
                new string[] { "one", "two", "three" };
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);

            // Инициализации массива 
            // без использования ключевого слова new.
            bool[] boolArray = 
                { false, false, true };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);

            // Иницаилизация массива с применением
            // ключевого слова new и
            // указазанием размера.
            int[] intArray = 
                new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArray has {0} elements", intArray.Length);
            Console.WriteLine();
        }
        #endregion

        #region Var keyword with arrays
        static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization.");

            // a is really int[].
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());

            // b is really double[].
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is a: {0}", b.ToString());

            // c is really string[].
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is a: {0}", c.ToString());
            Console.WriteLine();
        }
        #endregion

        #region Array of objects
        static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of Objects.");

            // An array of objects can be anything at all.
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";

            foreach (object obj in myObjects)
            {
                // Print the type and value for each item in array.
                Console.WriteLine("Type: {0}, Value: {1}", 
                    obj.GetType(), obj);
            }
            Console.WriteLine();
        }
        #endregion

        #region MD arrays
        static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array:\n");
            // Объявить прямоугольный массив 3х4.
            int[,] myMatrix = new int[3, 4];

            // Заполнить массив 3х4.
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    myMatrix[i, j] = i * j;

            // Print (3 * 4) array.
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(myMatrix[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array:\n");
            // A jagged MD array (i.e., an array of arrays).
            // Here we have an array of 5 different arrays.
            // Объявить 5 разных массивов
            int[][] myJagArray = new int[5][];

            // Создать зубчатый массив.
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];

            // Вывести все строки
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        #endregion

        #region Arrays as params and return values
        static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
                Console.WriteLine("Item {0} is {1}",
                    i, myInts[i]);
        }

        static string[] GetStringArray()
        {
            string[] theStrings 
                = { "Hello", "from", "GetStringArray" };
            return theStrings;
        }

        static void PassAndReceiveArrays()
        {
            // Передать массив в качестве параметра.
            int[] ages = { 20, 22, 23, 0 };
            PrintArray(ages);

            // Получить массив как возвращаемое значение.
            string[] strs = GetStringArray();
            foreach (string s in strs)
                Console.WriteLine(s);
        }
        #endregion

        #region System.Array functionality
        static void SystemArrayFunctionality()
        {
            Console.WriteLine("=> Working with System.Array.");
            // Initialize items at startup.
            string[] gothicBands 
                = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };
            // Очистить все элементы, кроме первого
            Array.Clear(gothicBands, 1, 2);

            // Print out names in declared order.
            Console.WriteLine(" -> Here is the array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                // Print a name
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");

            // Reverse them...
            Array.Reverse(gothicBands);
            Console.WriteLine(" -> The reversed array");
            // ... and print them.
            for (int i = 0; i < gothicBands.Length; i++)
            {
                // Print a name
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");

            // Clear out all but the final member.
            Console.WriteLine(" -> Cleared out all but one...");
            Array.Clear(gothicBands, 1, 2);
            for (int i = 0; i < gothicBands.Length; i++)
            {
                // Print a name
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine();
        }
        #endregion

    }
}
