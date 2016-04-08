

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




//version 2 /////////////////////
public class Rabbit {
  public string Noise {get; set;}
  public virtual string Transportation() {
    return "hops";
  }
}

public class SnowBunny : Rabbit {
  public bool FearOfCars {get; set;}
  public override string Transportation() {
    return "hippity hops";
  }
}

Rabbit roger = new Rabbit();
SnowBunny peter = new SnowBunny();

Console.WriteLine(roger.Transportation());
Console.WriteLine(peter.Transportation());


//version 3 ////////////////////
public class Rabbit {
  public string Noise {get; set;}
  public virtual string Transportation() {
    return "hops";
  }
}

public class SnowBunny : Rabbit {
  public bool FearOfCars {get; set;}
  public string EarHeight {get; set;}
  public override string Transportation() {
    return "hippity hops";
  }

  public SnowBunny (string height) {
    EarHeight = height; 
  }

  public SnowBunny (bool fear) {
    FearOfCars = fear;
  }
}

Rabbit roger = new Rabbit();
SnowBunny peter = new SnowBunny();

Console.WriteLine(roger.Transportation());
Console.WriteLine(peter.Transportation());




///////////////// Practice ////////////////////
// 1 Animal > 3 Genus > 5 Species

public class Animal {
  public string animalName { get; set; }
  public double speed { get; set; }  
  public string color { get; set; }

  private string _consumption = "";

  public string consumption
  {
    get
    {
      return _consumption;
    }

    set
    {
      if (value == "Omnivore" || value == "Carnivore" || value == "Herbivore")
      {
        _consumption = value;
      }
    }
  }
    
}

public class Genus : Animal {
  public string noise { get; set; }
  public string genusName { get; set; }

}

public class Canis : Genus {
  public bool domesticated { get; set; }
  public int legs = 4;

  public virtual void walk () {
        Console.WriteLine("Canis class walk method speed", speed);
        speed = speed + (0.1 * legs);
    }
}

public class Felis : Genus {
  public bool bigCat { get; set; }
  public bool striped { get; set; }

  // bad practice to have a constructor at this level?
  public Felis {
    bigCat = true;
  }
}


public class Shrimp : Genus {
  private bool deepSea;
  private string _defense = "";
  public float depthFound = 0f;

  public string defense {
    get 
    {
      return _defense;
    }
    set
    {
      if (value != "Firearms")
      {
        _defense = value;
      }
    }
  }
}



// canis species
public class Dog : Canis {
  public Dog (string sound) {
    noise = sound;
    domesticated = true;
  }

  public override void walk () {
    speed = 2 * speed;
    base.walk();
    Console.WriteLine("New speed {0}", speed);
  }
}


public class Wolf : Canis {
  public Wolf () {
    domesticated = false;
    noise = "howl";
  }
}

public class Coyote : Canis {
  public Coyote () {
    domesticated = false;
  }
}

public class Jackal : Canis {
  public Jackal () {
    domesticated = false;
  }
}

public class Dhole : Canis {
  public Dhole () {
    domesticated = false;
  }
}


//felis species
public class ChineseMountainCat : Felis {
  public ChineseMountainCat () {
    bigCat = false;
  }
}

public class JungleCat : Felis {
  public string size = "medium";
}

public class WildCat : Felis {
  public WildCat () {
    bigCat = true;
  }
}

public class SandCat : Felis {
  public SandCat () {
    bigCat = false;
  }
}

public class Cat : Felis {
  public bool domesticated = false;

  public Cat () {
    bigCat = false;
  }
}



//shrimp species
public class DeepSeaShrimp : Shrimp {
  public DeepSeaShrimp (float depth)
  {
    depthFound = depth;
    defense = "bioluminescent vomit";
  }
}

public class PistolShrimp : Shrimp
{
  public string alias = "Snapping Shrimp";

  public PistolShrimp (float depth)
  {
    depthFound = depth;
    defense = "sonic Booms";
  }
}

public class EmperorShrimp : Shrimp
{

  public EmperorShrimp (float depth)
  {
    depthFound = depth;
    defense = "none";
  }

}

public class CherryShrimp : Shrimp
{

  public CherryShrimp (float depth)
  {
    consumption = "Omnivore";
    depthFound = depth;
    defense = "hiding";
    color = "red";
  }

  public CherryShrimp (string colorStr)
  {
    consumption = "Omnivore";
    depthFound = 100;
    defense = "hiding";
    color = colorStr;

  }
}

public class WindowWashingShrimp : Shrimp
{
  public int cleaningPower = 9001;

  public WindowWashingShrimp (float depth)
  {
    depthFound = depth;
    defense = "none";
  }

}

CherryShrimp karl = new CherryShrimp(100);