
using AbstractFactoryPattern;

Animal animal = null;
AnimalFactory animalFactory = null;
string speakSound = null;

animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
Console.WriteLine();


animal = animalFactory.GetAnimal("Shark");
Console.WriteLine("Animal Type : " + animal.GetType().Name);

speakSound = animal.speak();
Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);



Console.WriteLine();
Console.WriteLine("--------------------------");



animalFactory = AnimalFactory.CreateAnimalFactory("Land");
Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
Console.WriteLine();

animal = animalFactory.GetAnimal("Dog");
Console.WriteLine("Animal Type : " + animal.GetType().Name);

speakSound = animal.speak();
Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
Console.WriteLine();


animal = animalFactory.GetAnimal("Cat");
Console.WriteLine("Animal Type : " + animal.GetType().Name);

speakSound = animal.speak();
Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
Console.Read();
        
