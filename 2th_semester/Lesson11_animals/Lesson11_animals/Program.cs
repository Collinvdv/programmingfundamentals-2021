using System;

namespace Lesson11_animals
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Create collin animal
            Animal animal1 = new Animal("Collin", new DateTime(1991, 4, 16), SexEnumeration.Male);
            Animal animal2 = new Animal("Lisa", new DateTime(1961, 4, 16), SexEnumeration.Female);
            Fish nemo = new Fish("Nemo", new DateTime(2020, 5, 1), SexEnumeration.Male);
            Tiger joeExotic = new Tiger("Joe exotic", new DateTime(1990, 5, 5), SexEnumeration.Female);
            Bird bird1 = new Bird("Lars", new DateTime(2003, 7, 25), SexEnumeration.Female);
            Bird bird2 = new Bird("Collin", new DateTime(2003, 7, 25), SexEnumeration.Male);

            joeExotic.AddPartner(nemo);
            joeExotic.CheckRelationship();
            nemo.CheckRelationship();
        }
    }
}

//
// Welcome to the zoo
// An animal has a name, age, sex, isDead, can make noise, can say its name, you can poke it
// When animal is dead it can not make noise or can not say its name
// Every animal can have an animal as a Partner
//

//
// A fish is also an animal so it has a name, sex, dob, isAlive
// A fish can swim
// when you poke it 1 times, it is dead
// When fish is dead it can not swim anymore
//

//
// A tiger can eat every animal, and make it dead
//





//
// A bird can give an egg when it is female
// When you slap it 2 times it is dead
//



//
// An animal can have a partner
// Method to check if they got a partner
// fe: nemo has a relationship with joe exotic
// ge: collin has no relationship
//