using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleAppMoshCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Loops Exercise #5
            //Console.WriteLine("Enter a series of numbers with commas in between (Ex : 1,2,3,4,5");
            //var input = Console.ReadLine();
            //string[] array = new string[input.Length - 1];
            //int num = 0;
            //foreach (var item in input)
            //{
            //    if(item != ',')
            //    {
            //        //array[num] = item.ToString();
            //        //num++;
            //        if(item > num)
            //        {
            //            num = item;
            //            Console.WriteLine(num);
            //            Console.WriteLine(item);
            //            Console.WriteLine("---");
            //        }
            //    }
            //}
            //Console.WriteLine("the highest number is " + num);

            //Solution
            //Console.Write("Enter commoa separated numbers: ");
            //var input = Console.ReadLine();

            //var numbers = input.Split(',');

            //// Assume the first number is the max 
            //var max = Convert.ToInt32(numbers[0]);

            //foreach (var str in numbers)
            //{
            //    var number = Convert.ToInt32(str);
            //    if (number > max)
            //        max = number;
            //}

            //Console.WriteLine("Max is " + max);






            //Arrays and Lists
            //=============================================================================================================
            // Exercise 1 = FAILED
            /* When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
              - If no one likes your post, it doesn't display anything.
              - If only one person likes your post, it displays: [Friend's Name] likes your post.
              - If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
              - If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
    `         Write a program and continuously ask the user to enter different names, until the user presses Enter 
              (without supplying a name). Depending on the number of names provided, display a message based on 
              the above pattern. */
            //-----------
            //var list = new List<string>();
            //var input = "";

            //while (input != "exit")
            //{
            //    Console.WriteLine("Enter a name. Enter 'exit' to stop");
            //    input = Console.ReadLine();
            //    if(input != "exit") 
            //    {
            //        list.Add(input);
            //    }
            //}

            //int count = list.Count;
            //int othersCount = count - 2;
            ////Console.WriteLine("count = " + count + ". othersCount = " + othersCount + ". list = " + list);
            //Console.WriteLine($"count = {count}. othersCount = {othersCount}. list = {string.Join(", ", list)}");
            //Console.WriteLine();
            //switch (count) 
            //{
            //    case 1:
            //        Console.WriteLine(list[0] + " likes your post");
            //        break;
            //    case 2:
            //        Console.WriteLine(list[0] + ", " + list[1] + " likes your post");
            //        break;
            //    case 3:
            //        Console.WriteLine(list[0] + ", " + list[1] + ", and " + othersCount + " others likes your post");
            //        break;
            //    default:
            //        Console.WriteLine("No likes");
            //        break;
            //}



            // Exercise 2 = FAILED
            /* Write a program and ask the user to enter their name. Use an array to reverse 
               the name and then store the result in a new string. Display the reversed name 
               on the console. */
            //-----------
            //Console.WriteLine("Enter a name.");
            //string input = Console.ReadLine();
            //var inputArray = input.Split("");
            //var array = new string[input.Length];
            //for (var i = 0; i < inputArray.Length; i++)
            //{
            //    array[i] = inputArray[i];
            //}
            //array.Reverse();
            //Console.WriteLine("reversed = " + string.Join(", ", array));
            ////ChatGPT
            ////Console.WriteLine("Enter a name.");
            ////string input = Console.ReadLine();
            ////var charArray = input.ToCharArray();
            ////Array.Reverse(charArray);
            ////string reversed = new string(charArray);
            ////Console.WriteLine("Reversed = " + reversed);



            //Exercise 3 = SUCCESS (ChatGPT)
            /* Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
               an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort 
               them and display the result on the console. */
            //----------
            //string input;
            //var list = new List<string>();
            //Console.WriteLine("Enter 5 numbers, all must be different from each other");

            //while(list.Count() < 5) 
            //{
            //    Console.WriteLine("Enter a number");
            //    input = Console.ReadLine();
            //    foreach (var item in list) 
            //    {
            //        if(item == input) 
            //        {
            //            Console.WriteLine("You've already added that number. Try again.");
            //        }
            //        else 
            //        {
            //            list.Add(input);
            //        }
            //    }
            //}

            //list.Sort();
            //Console.WriteLine("Here's the sorted list : " + string.Join(", ", list));

            //ChatGPT
            //string input;
            //var list = new List<string>();
            //Console.WriteLine("Enter 5 numbers, all must be different from each other");

            //while (list.Count < 5)
            //{
            //    Console.WriteLine("Enter a number:");
            //    input = Console.ReadLine();

            //    if (list.Contains(input))
            //    {
            //        Console.WriteLine("You've already added that number. Try again.");
            //    }
            //    else
            //    {
            //        list.Add(input);
            //    }
            //}

            //list.Sort();
            //Console.WriteLine("Here's the sorted list: " + string.Join(", ", list));



            // Exercise 4 = SUCCESS
            /* Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of 
               numbers may include duplicates. Display the unique numbers that the user has entered. */
            //------------
            ////SUDO
            ////instantiate a input and list variables
            ////write a while input != quit to add the input in the list
            ////after while loop, display the list
            //string input = "";
            //var list = new List<string>();
            //while (input != "quit") 
            //{
            //    Console.WriteLine("Enter a number. Type 'quit' to exit.");
            //    input = Console.ReadLine();
            //    if (input != "quit")
            //    {
            //        list.Add(input);
            //    }
            //}
            //Console.WriteLine("Here are the numbers you entered : " + string.Join(", ", list));



            // Exercise 5 = SUCCESS (may want to convert it to numbers since youre sorting string numbers)
            /* Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the 
               list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, 
               display the 3 smallest numbers in the list.
             */
            /*SUDO
             * instantiate input and list variable
             * split the list by ", "
             * instantiate an array with the split method
             * do an if check for array length less than 5
             * sort the array and dispay the first three elements
             */
            //string input = "";
            //Console.WriteLine("Give me a comma separated list of numbers. Ex) '1, 2, 3, 4, 5");
            //bool accept = false;
            //while (!accept) 
            //{
            //    input= Console.ReadLine();
            //    string[] array = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            //    if(array.Length > 5 )
            //    {
            //        accept = true;
            //        Array.Sort(array);
            //        var threeArray = new string[3];
            //        Array.Copy(array, threeArray, 3);
            //        Console.WriteLine("Here's the smallest three numbers you entered " + string.Join(", ", threeArray));
            //    } else
            //    {
            //        Console.WriteLine("Too few numbers. Try again");
            //    }
            //}









            //Strings and StringBuilder
            //=============================================================================================================
            // Exercise 1 = SUCCESS
            /* Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are 
               consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; 
               otherwise, display "Not Consecutive". */
            //-----------
            //Console.WriteLine("enter numbers with a hyphen in ascending or descending order. Ex) 1-2-3-4-5 or 5-4-3-2-1");
            //var input = Console.ReadLine();
            //var stringArray = input.Split("-");
            //var length = stringArray.Length;
            //if (Convert.ToInt32(stringArray[0]) > Convert.ToInt32(stringArray[length - 1]))
            //{
            //    Console.WriteLine("Not Consecutive");
            //}
            //else
            //{
            //    Console.WriteLine("Consecutive");
            //}



            // Exercise 2 = Try again
            /* Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses 
               Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, 
               display "Duplicate" on the console. */
            //-----------
            //Console.WriteLine("Enter a few numbers separated by a hyphen. Then keep entering. When you're done, just hit enter without any input");
            //var isDone = false;

            //while(isDone == false)
            //{
            //    var list = new List<string>();
            //    var input = Console.ReadLine();
            //    if (input != null)
            //    {
            //        list.Add(input);
            //        Console.WriteLine("Enter another few numbers.");
            //    } else
            //    {
            //        isDone = true;
            //        // check duplicates
            //        //foreach loop for every index of that list. if check to skip checking itself
            //        int currentNum = 0;
            //        foreach(var item in list)
            //        {
            //            for(var i = 0;i< item.Length;i++)
            //            {
            //                if(i != currentNum && item == list[i])
            //                {
            //                    Console.WriteLine("Duplicate found: " + item + " <> " + list[i]);
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //}





            // Exercise 3 =  SUCCESS
            /* Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time 
               should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If 
               the user doesn't provide any values, consider it as invalid time. */
            //-----------
            //Console.WriteLine("Enter a time in the 24-hour time from 00:00 to 23:59");
            //var input = Console.ReadLine();
            //try
            //{
            //    var date = DateTime.Parse(input);

            //    Console.WriteLine("Ok");
            //} catch {
            //    Console.WriteLine("Invalid Time");
            //}





            // Exercise 4 = Try again
            /* Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable 
               name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make 
               sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program 
               should still display "NumberOfStudents". */
            //-----------
            //Console.WriteLine("Enter a few words separated by a space");
            //var input = Console.ReadLine().ToLower();
            //var array = input.Split(' ');
            //var finalString = new StringBuilder();
            //var wordString = new StringBuilder();
            //foreach(var word in array)
            //{
            //    var wordArray = word.Split("");
            //    wordArray[0].ToUpper();
            //    for(var i = 0;i< word.Length;i++)
            //    {
            //        wordString.Append(wordArray[i]);
            //    }
            //    finalString.Append(wordString);
            //    wordString.Clear();
            //}
            //Console.WriteLine("Here is PascalCase for your input : " + finalString);



            // Exercise 5 = SUCCESS
            /* Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the 
               word. So, if the user enters "inadequate", the program should display 6 on the console. */
            //-----------
            //Console.WriteLine("Enter an english word");
            //var input = Console.ReadLine();
            //var count = input.Count();
            //Console.WriteLine("count = " + count);







            //File and Directories
            //=============================================================================================================
            // Exercise 1 = SUCCESS
            /* Write a program that reads a text file and displays the number of words. */
            //-----------
            //Console.WriteLine("This program will reads a text file and displays the number of words.");
            //var path = @"C:\Users\CyberPower_MarkR\Desktop\CodeProjects\Exercises-Simple\C_Sharp\CodeWithMosh_C_Sharp\TestFile_01.txt";
            //var text = File.ReadAllText(path);
            //Console.WriteLine("path Text = " + text);



            // Exercise 2 = SUCCESS
            /* Write a program that reads a text file and displays the longest word in the file. */
            //-----------
            //Console.WriteLine("This program will read a text file and displays the longest word in the file.");
            //var path = @"C:\Users\CyberPower_MarkR\Desktop\CodeProjects\Exercises-Simple\C_Sharp\CodeWithMosh_C_Sharp\TestFile_01.txt";
            //var text = File.ReadAllText(path);
            //var array = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //var longest = "";
            //foreach ( var item in array )
            //{
            //    if(item.Length > longest.Length)
            //    {
            //        longest = item;
            //    }
            //}
            //Console.WriteLine("This is the longest word : " + longest);
        }
    }
}
