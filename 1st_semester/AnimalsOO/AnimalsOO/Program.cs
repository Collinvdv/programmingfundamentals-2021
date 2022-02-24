using System;

namespace AnimalsOO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Animal animal1 = new Animal("coco", "male");
            Animal animal2 = new Animal("lili", "female");
            Bird animal3 = new Bird("coco the bird", "male", false);
            Bird animal4 = new Bird("lili the bird", "female", true);
            Fish nemo = new Fish("Nemo", "male");

            Fish dory = new Fish("Dory", "femaly", nemo);

            Console.WriteLine(dory.GetLoversName());
  
        }
    }
}


//**Exercise 3**

//Animal(prop name string, prop sex (female,male), method PokeIt(), method GiveFood())


// animal1 "coco" "male"
// animal2 "lili" "female"

// animal1.PokeIt() -> "aaaaaaaaauwtch that hurts"
// animal2.PokeIt() -> "aaaaaaaaauwtch that hurts"

// animal2.GiveFood() -> "lili likes foods"