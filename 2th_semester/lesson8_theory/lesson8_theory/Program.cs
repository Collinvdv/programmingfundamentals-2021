using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson8_theory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //int[] grades = new int[5];
            //grades[0] = 15;
            //grades[1] = 10;
            //grades[2] = 12;
            //grades[3] = 18;
            //grades[4] = 20;

            //foreach(int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}

            //for (int index = 0; index < grades.Length; index++)
            //{
            //    Console.WriteLine(grades[index]);
            //}

            // .Add(value) -> if you want to add a new item
            // .Insert(index, value) -> add specific item on specific location
            // .Remove(value) -> delete the first occurence
            // .RemoveAt(index) -> delete an item at a specific index
            // .Contains(item) -> gives back a Boolean if it is in the list
            // .IndexOf(item) -> will give you back the index of the item in the list, -1 when not in there

            //List<int> grades = new List<int>();

            //grades.Add(15);
            //grades.Add(10);
            //grades.Add(12);
            //grades.Add(18);
            //grades.Add(20);

            //grades.Insert(1, 20);

            //grades.Remove(20);
            ////grades.RemoveAll(20); // how does the .RemoveAll() method work????

            //Console.WriteLine(grades.IndexOf(20));
            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}

            //for(int index = 0; index < grades.Count; index++)
            //{
            //    Console.WriteLine(grades[index]);
            //}

            //Dictionary<string, int> classroom = new Dictionary<string, int>();

            //classroom.Add("collin", 30);
            //classroom.Add("lisa", 50);
            //classroom.Add("abdul", 20);

            //Console.WriteLine(classroom.ElementAt(3));
            //foreach(string name in classroom.Keys)
            //{
            //    Console.WriteLine(name + " is " + classroom[name] + " years old");
            //}


            //foreach (KeyValuePair<string, int> pair in classroom) { 
            //    Console.WriteLine(pair.Key);
            //    Console.WriteLine(pair.Value);
            //}


            ////
            //// todolist
            //// Commands: ADD, UNCHECK, SHOW UNCHECKED, SHOW CHECKED, STOP
            //// I: ADD
            //// I: Do my c# assignments
            //// O: Do my c# assignments added to list
            //// I: ADD
            //// O: Clean my room
            //// O: Clean my room added to list
            ////
            //// I: UNCHECK
            //// O: Which assignment?
            //// I: Clean my room
            //// O: Clean my room unchecked
            ////
            //// I: SHOW TODOS
            //// O: 1. Do my c# assignments
            ////
            //// I: SHOW DONE ITEMS
            //// O: 1. Clean my room
            ////
            //// I: STOP
            //// O: bye!
            ////

            //// create my 2 list
            //List<string> todos = new List<string>(); // what do I need to do?
            //List<string> doneItems = new List<string>(); // store item that are done

            //// ask for command
            //string command = Console.ReadLine().ToUpper();

            //while (command != "STOP")
            //{
            //    switch(command)
            //    {
            //        case "ADD":
            //            // add to do item
            //            string todo = Console.ReadLine();

            //            todos.Add(todo);

            //            Console.WriteLine($"{todo} has been added");
            //            break;

            //        case "UNCHECK":
            //            Console.WriteLine("Which todo do you want to delete?");
            //            string uncheckTodo = Console.ReadLine();
            //            int uncheckTodoIndex = todos.IndexOf(uncheckTodo);
            //            Console.WriteLine(uncheckTodoIndex);
            //            if (uncheckTodoIndex >= 0)
            //            {
            //                // remove it from my todo list
            //                todos.RemoveAt(uncheckTodoIndex);

            //                // add it to done items
            //                doneItems.Add(uncheckTodo);
            //            } else
            //            {
            //                Console.WriteLine("No todo item in here");
            //            }

            //            // uncheck an item
            //            break;

            //        case "SHOW TODOS":
            //            for(int index = 0; index < todos.Count; index++)
            //            {
            //                Console.WriteLine($"{index + 1}. {todos[index]}");
            //            }
            //            break;

            //        case "SHOW DONE ITEMS":
            //            for (int index = 0; index < doneItems.Count; index++)
            //            {
            //                Console.WriteLine($"{index + 1}. {doneItems[index]}");
            //            }
            //            break;

            //        default:
            //            Console.WriteLine("What are you typing brah?");
            //            break;
            //    }

            //    // Ask new command
            //    command = Console.ReadLine().ToUpper();
            //}

            //Console.WriteLine("Bye!");

            //// create my 2 list
            //Dictionary<string, Boolean> todos = new Dictionary<string, Boolean>();

            //// ask for command
            //string command = Console.ReadLine().ToUpper().Trim();

            //while (command != "STOP")
            //{
            //    switch (command)
            //    {
            //        case "ADD":
            //            // add to do item
            //            string todo = Console.ReadLine();

            //            todos[todo] = true;

            //            Console.WriteLine($"{todo} has been added");
            //            break;

            //        case "UNCHECK":
            //            Console.WriteLine("Which todo do you want to delete?");
            //            string uncheckTodo = Console.ReadLine();

            //            if (todos.ContainsKey(uncheckTodo))
            //            {
            //                todos[uncheckTodo] = false;
            //            } else
            //            {
            //                Console.WriteLine("What are you typing bro?");
            //            }

            //            break;

            //        case "SHOW TODOS":
            //            int indexShowTodo = 0;
            //            foreach(var showTodo in todos)
            //            {
            //                if (showTodo.Value == true)
            //                {
            //                    indexShowTodo++;
            //                    Console.WriteLine($"{indexShowTodo}. {showTodo.Key}");
            //                }
            //            }
            //            break;

            //        case "SHOW DONE ITEMS":
            //            int showDoneIndex = 0;
            //            foreach (var showTodo in todos)
            //            {
            //                if (showTodo.Value == false)
            //                {
            //                    showDoneIndex++;
            //                    Console.WriteLine($"{showDoneIndex}. {showTodo.Key}");
            //                }
            //            }
            //            break;

            //        default:
            //            Console.WriteLine("What are you typing brah?");
            //            break;
            //    }

            //    // Ask new command
            //    command = Console.ReadLine().ToUpper().Trim();
            //}

            //Console.WriteLine("Bye!");

            Dictionary<string, List<int>> gradebook = new Dictionary<string, List<int>>();

            gradebook["collin"] = new List<int>();
            gradebook["collin"].Add(5);
            gradebook["collin"].Add(20);
            gradebook["collin"].Add(15);

            gradebook["abdul"] = new List<int>();
            gradebook["abdul"].Add(20);

            // student = { key: collin, Value : list() }
            foreach(var student in gradebook)
            {
                Console.WriteLine(student.Key);

                List<int> studentGrades = student.Value;

                foreach (int grade in studentGrades)
                    Console.WriteLine(grade);
            }
        }
    }
}


// EXPLAIN LIST AND DICTIONARIES















//
// Spotify
// COMMANDS
//     ADD A SONG
//     LIST ALL ARTISTS
//     LIST ALL SONGS OF ARTIST
//     STOP

// I: ADD A SONG
// O: Name of artist:
// I: Justin Bwieber
// O: Name of song:
// I: Baby
// O: Justin Bwieber - Baby has been added
//
// I: ADD A SONG
// O: Name of artist:
// I: Justin Bwieber
// O: Name of song:
// I: Adult
// O: Justin Bwieber - Adult has been added
//
// I: LIST ALL ARTISTS
// O: 1. Justin Bwieber
//
// I: LIST ALL SONGS OF ARTIST
// I: Justin Bwieber
// O: 1. Baby
// O: 2. Adult
//
// I: STOP
// O: ThxBye
//
//
// I: ADD A SONG
// O: Name of artist:
// I: Justin Bwieber
// O: Name of song:
// I: Adult
// O: Song adult for Justin Bwieber is already added!
//








//
// Part 2 Spotify to file
//
