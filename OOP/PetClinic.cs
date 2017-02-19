using System;
using System.Collections.Generic;
using System.Linq;

class Animal
{
    private string name;
    private string breed;
    private string state;

    public Animal(string name, string breed, string state)
    {
        this.Name = name;
        this.Breed = breed;
        this.State = state;
        AnimalClinic.PatientId++;
    }

    public string State
    {
        get { return this.state; }
        set
        {
            if (value == "heal")
            {
                //value = "healed";
                AnimalClinic.HealedAnimalsCount++;
            }
            else
            {
                //value = "rehabilitated";
                AnimalClinic.RehabilitedAnimalsCount++;
            }
            this.state = value;
        }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string Breed
    {
        get { return this.breed; }
        set { this.breed = value; }
    }
}

class AnimalClinic
{
    private static int patientId;
    private static int healedAnimalsCount;
    private static int rehabilitedAnimalsCount;
    public static List<Animal> animals = new List<Animal>();

    public static int PatientId { get; set; }

    public static int HealedAnimalsCount { get; set; }

    public static int RehabilitedAnimalsCount { get; set; }
    
    
}

class Program
{
    static void Main(string[] args)
    {
        const string endOfInputCommand = "End";

        string[] input = Console.ReadLine().Split(' ');

        while (input[0] != endOfInputCommand)
        {
            string name = input[0];
            string breed = input[1];
            string state = input[2];

            Animal currentAnimal = new Animal(name, breed, state);

            Console.Write($"Patient {AnimalClinic.PatientId}: [{currentAnimal.Name} ({currentAnimal.Breed})] has been ");
            Console.WriteLine(state == "heal" ? "healed!" : "rehabilitated!");

            AnimalClinic.animals.Add(currentAnimal);

            input = Console.ReadLine().Split(' ');
        }

        Console.WriteLine($"Total healed animals: {AnimalClinic.HealedAnimalsCount}");
        Console.WriteLine($"Total rehabilitated animals: {AnimalClinic.RehabilitedAnimalsCount}");

        string stateRequested = Console.ReadLine();

        foreach (var animal in AnimalClinic.animals.Where(an => an.State == stateRequested))
        {
            Console.WriteLine($"{animal.Name} {animal.Breed}"); 
        }
    }
}

