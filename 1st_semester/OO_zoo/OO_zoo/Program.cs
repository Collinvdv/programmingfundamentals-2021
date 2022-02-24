using System;

namespace OO_zoo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Animal animal1 = new Animal("Coco", new DateTime(1991, 3, 16));
            Fish animal2 = new Fish("Lili", new DateTime(1993, 5, 21));
            Animal animal3 = new Animal("Lonely pigoen", new DateTime(2000, 7, 21));

            // add partners
            animal1.AddPartner(animal2);
            animal2.AddPartner(animal1);

            // animal1
            animal1.SayHello();
            animal1.SayYears();
            animal1.CheckPartner();

            // animal2
            animal2.SayHello();
            animal2.SayYears();
            animal2.CheckPartner();
            animal2.Swim();

            // animal3
            animal3.SayHello();
            animal3.SayYears();
            animal3.CheckPartner();


            animal3.Friends.Add(animal1);
            animal3.Friends.Add(animal2);

            animal3.ListFriends();
        }
    }
}














