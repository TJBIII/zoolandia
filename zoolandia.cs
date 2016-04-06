public class Animal {
  public string AnimalName { get; set; }
  public double speed { get; set; }
    
}
public class Species : Animal {
  public string SpeciesName { get; set; }
    
}

public class Horse : Species {
  public string Noise { get; set; }
  public bool Exotic { get; set; }
  public bool Hooves { get; set; }
  public int RaceWins { get; set; }
}

public class Cow : Species {
  public string Noise { get; set; }
  public string Color { get; set; }
  public float Weight { get; set; }
  public int Spots { get; set; }
}

public class Dog : Species {
  public string Noise { get; set; }
  public string Breed { get; set; }
  public bool Nice { get; set; }
  public float Weight { get; set; }
}

public class Squirrel: Species {
    public string Noise {get; set;}
    public string FavoriteFood {get; set;}
    public bool FluffyTail {get; set;}
    public int CutenessLevel {get; set;}
}


Dog karl = new Dog();
karl.AnimalName = "Karl";
karl.SpeciesName = "C. lupus";
karl.Noise = "Bark";
karl.Breed = "Boston Terrier";
karl.Nice = true;

Console.Write("I have a dog named {0} who is a {1}", karl.AnimalName, karl.Breed);

