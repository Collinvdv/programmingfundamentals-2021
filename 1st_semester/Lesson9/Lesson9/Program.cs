using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson9
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //// todolist
            //// Output: Here are your todos:
            //// Output: 1. learn c#
            //// Output: 2. learn javascript
            //// Output: 3. clean my room
            //Console.WriteLine("how many items do you want to have in your todo list?");
            //int amountItems = Convert.ToInt32(Console.ReadLine()); // Input: 3
            //string[] tasks = new string[amountItems]; // { null, null, null}

            //// Populate
            //for (int index = 0; index < tasks.Length; index++)
            //{
            //    Console.WriteLine($"What is to do number {index + 1}?");
            //    tasks[index] = Console.ReadLine(); // Input: learn c#
            //}

            //// show the todos
            //for (int index = 0; index < tasks.Length; index++)
            //{
            //    Console.WriteLine($"{index + 1} : {tasks[index]}");
            //}

            //// delete items
            //// ADDITION todolist
            //Console.WriteLine("Do you wish to remove an item? (say STOP to stop the program)");
            //string checkedItem = Console.ReadLine(); // STOP

            //while (checkedItem != "STOP" )
            //{
            //    // check if is existing
            //    Boolean itemIsExisting = false;
            //    int checkedItemIndex = 0;
            //    // loop through the task if if is in in there 
            //    for(int index = 0; index < tasks.Length; index++) 
            //    {

            //        if (tasks[index] == checkedItem)
            //        {
            //            itemIsExisting = true; // item is existing
            //            checkedItemIndex = index; // checked at which location 
            //        }
            //    }

            //    // 
            //    if (itemIsExisting)
            //    {
            //        // change it and give a list back
            //        tasks[checkedItemIndex] = "";

            //        // show the not empty tasks
            //        for (int index = 0; index < tasks.Length; index++)
            //        {
            //            if (tasks[index] != "")
            //            {
            //                Console.WriteLine(tasks[index]);
            //            }
            //        }
            //    }
            //    else
            //    {
            //        // not existing
            //        Console.WriteLine("can not find task in todolist");
            //    }

            //    // Ask again to delete an item
            //    Console.WriteLine("Do you wish to remove an item? (say STOP to stop the program)");
            //    checkedItem = Console.ReadLine(); // STOP

            //}

            // after inputting I want to remove an item

            // Output: Do you wish to remove an item? (say STOP to stop the program)
            // Input: learn c#
            // Output: haha I recognised it, I remove it!
            // Output: Here are your todos:
            // Output: 1. learn javascript
            // Output: 2. clean my room

            //
            // Ananya pro tip: .except(), Collin is not going to use it but Ananya is smarter.






            // EXPLAIN LIST
            // normal list
            // how to add items (Add(item) + Insert(index, item))
            // how to remove an item (Remove(item) + RemoveAt(index)
            // how to check if item is already in list (Contains)
            // give me back the index of a list (IndexOf(item))
            // looping over list (for + for in)
            // fill list with hardcoded data
            // array and list are friends (ToList() + ToArray())

            //// list of persons
            //string[] personsArray = { "Anna", "Jebus" };
            ////List<string> persons = new List<string>(personsArray);
            //List<string> persons = new List<string>();

            ////
            ////persons = personsArray.ToList(); // COLLIN CHECK THIS
            //persons.ToArray();
            //persons.AddRange(personsArray); // AddRange(); add an array to a list


            //// How to add an item to a list
            //persons.Add("Collin");
            //persons.Add("Tom");
            //persons.Add("Youssef");
            //persons.Insert(1, "A person between collin and tom");


            // remove items
            //persons.Remove("Collin"); // remove an item based on the value itself, first occurence
            //persons.RemoveAt(2); // remove an item based the item 

            // check if in item is in the list
            //Console.WriteLine(persons.Contains("Anna"));
            //Console.WriteLine(persons.IndexOf("Youssef"));

            //for (var index = 0; index < persons.Count; index ++ )
            //{
            //    Console.WriteLine(persons[index]);
            //}

            //foreach (string person in persons)
            //{
            //    Console.WriteLine(person);
            //}










            // Using a list for todolist
            // Output: Add to dos in your list, say STOP to enter the input of to dos
            // Input: learn c#
            // Input: learn javascript
            // Input: clean my room
            // Input: STOP
            // Output: Here are your todos:
            // Output: 1. learn c#
            // Output: 2. learn javascript
            // Output: 3. clean my room

            //List<string> tasks = new List<string>();

            //// populating the array
            //Console.WriteLine("Add to dos in your list, say STOP to enter the input of to dos");
            //string newItem = Console.ReadLine();
            //while (newItem != "STOP")
            //{
            //    // add it to tasks
            //    tasks.Add(newItem);

            //    // ask newITem
            //    newItem = Console.ReadLine();
            //}

            //// output the array
            //Console.WriteLine("Here are your todos:");
            //for (int index = 0; index < tasks.Count; index++ )
            //{
            //    Console.WriteLine($"{index + 1}. {tasks[index]}");
            //}

            //// Using a list for todolist
            //Console.WriteLine("Do you wish to remove an item? (say STOP to stop the program)");
            //string removeItem = Console.ReadLine(); // learn c#
            //List<string> removedTasks = new List<string>();

            //while (removeItem != "STOP")
            //{
            //    // check if it is existing
            //    if (tasks.Contains(removeItem))
            //    {
            //        // it is existing
            //        tasks.Remove(removeItem); // learn c#
            //        removedTasks.Add(removeItem); // learn c# to my removed items list
            //    } else
            //    {
            //        // not existing
            //        Console.WriteLine("Sorry my lovely potato, I don'know this task");
            //    }

            //    // output
            //    Console.WriteLine("Here are your todos:");
            //    for (int index = 0; index < tasks.Count; index++)
            //    {
            //        Console.WriteLine($"{index + 1}. {tasks[index]}");
            //    }

            //    if (removedTasks.Count > 0)
            //    {
            //        Console.WriteLine("Here are your todos that you already did:");
            //        for (int index = 0; index < removedTasks.Count; index++)
            //        {
            //            Console.WriteLine($"{index + 1}. {removedTasks[index]}");
            //        }
            //    }

            //    // ask it again
            //    Console.WriteLine("Do you wish to remove an item? (say STOP to stop the program)");
            //    removeItem = Console.ReadLine(); // learn c#
            //}

            // Output: Here are your todos:
            // Output: 1. learn javascript
            // Output: 2. clean my room
            // Output: Here the checked todos:
            // Output: 1. learn c#










            // EXPLAIN DICTIONARY
            // key value pairing
            // add an element (Add(key, value))
            // remove an element (Remove(item)
            // check if existing (ContainsKey(key) + ContainsValue(value)
            // 4 ways of looping


            //Dictionary<string, int> gradebook = new Dictionary<string, int>();
            //// collin: 10
            //// youssef: 9
            //// anna: 9
            //// tom: 6

            //gradebook.Add("collin", 10);
            //gradebook.Add("youssef", 9);
            //gradebook.Add("anna", 9);
            //gradebook.Add("tom", 6);

            //gradebook.Remove("tom");


            //gradebook["collin"] = 11;

            //Console.WriteLine(gradebook.ContainsKey("collin"));
            //Console.WriteLine(gradebook.ContainsValue(9));

            //Console.WriteLine(gradebook["collin"]);
            //Console.WriteLine(gradebook["youssef"]);
            //Console.WriteLine(gradebook["anna"]);

            //foreach (var student in gradebook)
            //{
            //    Console.WriteLine(student.Key); // Collin
            //    Console.WriteLine(student.Value); // 9
            //}

            //foreach (var studentName in gradebook.Keys)
            //{
            //    Console.WriteLine(studentName);
            //}

            //foreach (var grade in gradebook.Values)
            //{
            //    Console.WriteLine(grade);
            //}

            //for (int index = 0; index < gradebook.Count; index++)
            //{
            //    Console.WriteLine(gradebook.ElementAt(index).Key);
            //}









            // Using a dictionary list for todolist
            // Output: Add to dos in your dictionary, say STOP to enter the input of to dos
            // Input: learn c#
            // Input: learn javascript
            // Input: clean my room
            // Input: STOP
            // Output: Here are your todos:
            // Output: 1. learn c#
            // Output: 2. learn javascript
            // Output: 3. clean my room
            // Output: Do you wish to uncheck an item? (say STOP to stop the program)
            // Input: learn c#
            // Output: Here are your todos:
            // Output: 1. learn javascript
            // Output: 2. clean my room
            // Output: Here the checked todos:
            // Output: 1. learn c#




            //Dictionary<string, Boolean> tasks = new Dictionary<string, bool>();

            //// Output: Add to dos in your dictionary, say STOP to enter the input of to dos
            //Console.WriteLine("Add to dos in your dictionary, say STOP to enter the input of to dos");
            //string todo = Console.ReadLine();

            //// populate it
            //while (todo != "STOP")
            //{
            //    // add new task (FE: "program in C#") + second parameter is true because not yet done
            //    tasks.Add(todo, true);

            //    //Ask it again
            //    todo = Console.ReadLine(); 
            //}

            //// show the todos
            //Console.WriteLine("Here are your todo's:");
            //foreach (string task in tasks.Keys)
            //{
            //    Console.WriteLine(task);
            //}

            //// remove items and show them what items are done and still need to be done
            //Console.WriteLine("Do you wish to remove an item? (say STOP to stop the program)");
            //string uncheckItem = Console.ReadLine();

            //while (uncheckItem != "stop") {
            //    // check if the task is existing
            //        // if it is existing -> change true to false
            //        // if not existing -> just say it
            //    if (tasks.ContainsKey(uncheckItem))
            //    {
            //        tasks[uncheckItem] = false; //tasks["dance"] = false
            //        // change true to false
            //    } else
            //    {
            //        Console.WriteLine("Sorry pigeon, I can not find your task");
            //    }

            //    // YOU DID THESE TASK:
            //    Console.WriteLine("Did is what you already did:");
            //    foreach (var task in tasks)
            //    {
            //        if (task.Value == false)
            //        {
            //            Console.WriteLine(task.Key);
            //        }
            //    }

            //    // YOU STILL NEED TO DO THESE TASK:
            //    Console.WriteLine("Did is what you still need to do:");
            //    foreach (var task in tasks)
            //    {
            //        if (task.Value)
            //        {
            //            Console.WriteLine(task.Key);
            //        }
            //    }

            //    // Ask it an change the uncheck item
            //    Console.WriteLine("Do you wish to remove an item? (say STOP to stop the program)");
            //    uncheckItem = Console.ReadLine();
            //}










            // Spotify
            // 1 RESTRICTION 
            // COMMANDS
            //     ADD A SONG
            //     LIST ALL THE SONGS
            //     STOP
            //

            //Console.WriteLine("enter new command:");
            //string command = Console.ReadLine();
            //Dictionary<string, List<string> > listOfSongs = new Dictionary<string, List<string>>();

            //while (command != "stop")
            //{
            //    // check command
            //    switch (command.ToLower())
            //    {
            //        case "add":
            //            // get the artist and the song
            //            Console.WriteLine("Name of artist:");
            //            string inputArtist = Console.ReadLine(); //billey eilish
            //            Console.WriteLine("Name of song:");
            //            string inputSong = Console.ReadLine(); //happier then ever

            //            // add it to the songs
            //            if (listOfSongs.ContainsKey(inputArtist))
            //            {
            //                List<string> songs = listOfSongs[inputArtist]; // {"happier then ever"}
            //                songs.Add(inputSong);

            //                listOfSongs[inputArtist] = songs;
            //            } else
            //            {
            //                // create a new list of songs 
            //                List<string> songs = new List<string>();

            //                // add a new song to this list
            //                songs.Add(inputSong);

            //                listOfSongs.Add(inputArtist, songs);
            //            }

            //            break;

            //        case "list":
            //            // list all the song
            //foreach (var artist in listOfSongs)
            //{
            //    foreach (string song in listOfSongs[artist.Key])
            //    {
            //        Console.WriteLine($"{artist.Key} - {song}");
            //    }
            //}
            //            break;

            //        case "remove":
            //            // Remove an artist
            //            Console.WriteLine("give me the artist that you want to remove:");
            //            string inputRemoveArtist = Console.ReadLine();

            //            if ( listOfSongs.ContainsKey(inputRemoveArtist))
            //            {
            //                listOfSongs.Remove(inputRemoveArtist);
            //            } else
            //            {
            //                Console.WriteLine($"{inputRemoveArtist} are not in the list, brother ");
            //            }
            //            break;

            //        default:
            //            Console.WriteLine("Whuuut, broh? Command not recognised");
            //            break;
            //    }

            //    // ask new command
            //    Console.WriteLine("enter new command:");
            //    command = Console.ReadLine();
            //}

            //Console.WriteLine("Bye");

            Console.WriteLine(Environment.UserName);



        }
    }
}


// if an artist is not in the list
    // then to


// if i have to 






























