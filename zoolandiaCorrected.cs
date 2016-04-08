using System;

namespace Zoolandia
{

  class Animal
  {
    /*
      Private scoped variable that are only accessible within
      the Animal class.
     */
    private string _name = "";
    private string _food = "";
    private string _consumption = "";
    private Species _species;

    public Species species
    {
      get
      {
        return _species;
      }
      set
      {
        _species = value;
      }
    }


    /*
      Public property that is accessible by other classes but
      can only be read, not manipulated.
     */
    public string name {
      get
      {
        return _name;
      }
      set
      {
        _name = value;
      }
    }

    public string consumption {
      get
      {
        return _consumption;
      }
      set
      {
        if (value == "Omnivore" || value == "Herbivore" || value == "Carnivore") {  
          _consumption = value
        }
      }
    }

    /*
      Public property that is accessible by other classes that
      can be read and set, but with some conditional logic that
      checks the value before the private variable is set.

      Animal adam = new Animal();
      adam.food = "Banana";   <-- will compile
      adam.food = "";         <-- will not compile
     */
    public string food {
      get
      {
        return _food;
      }
      set
      {
        if (value != "")
        {
          _food = value;
        }
      }
    }
    
    public Animal (string name)
    {
      _name = name;
    }

    /*
      Your first method on a class.
     */
    public virtual void eat(string food) {
      _food = food;
      Console.WriteLine("Currently eating {0}", food);
    }
  }

  class Taxonomy
  {
    public string url { get; set; }
    public string trait { get; set; }
    public string scientificName { get; set; }
    public string commonName { get; set; }
  }

  class Genus : Taxonomy
  {

  }

  class Species : Taxonomy
  {
    private Genus _genus;

    public Genus genus
    {
      get
      {
        return _genus;
      }
      set
      {
        _genus = value;
      }
    }
  }


  /*
    Genus class
   */
  class Canis : Genus
  {
    public bool domesticated { get; set; }
    public int legs = 4;
    private string _continent;


    public string continent
    {
      get
      {
        return _continent;
      }
      set
      {
        if (value != "")
        {
          _continent = value;
        }
      }
    }

    private void init ()
    {
      this.url = "https://en.wikipedia.org/wiki/Canis";
      this.traits = "moderate to large size, their massive, well developed skulls and dentition, long legs, and comparatively short ears and tails";
      this.commonName = null;
      this.scientificName = "Canis";
    }

    public Canis () {
      this.init();
    }

    public Canis (string continent) {
      this.init();
      this.continent = continent;
    }
  }

  /*
    Species of Canis
   */
  class Dog : Species
  {
    public Dog ()
    {
      this.url = "https://en.wikipedia.org/wiki/dog";
      this.genus = new Canis("Asia");
      this.scientificName = "C. Lupus";
      this.commonName = "Dog";
    }
  }

  /*
    Species of Canis
   */
  class Wolf : Species
  {
    public Wolf ()
    {
      this.url = "https://en.wikipedia.org/wiki/wolf";
      this.genus = new Canis("Asia");
      this.scientificName = "Canus lupus lupus";
      this.commonName = "Grey Wolf";
    }
  }


  class Coyote : Species
  {
    public Coyote ()
    {
      this.url = "https://en.wikipedia.org/wiki/coyote";
      this.genus = new Canis("N. America");
      this.scientificName = "Canus latrans";
      this.commonName = "Coyote";
    }

  }



  class Zoolandia
  {
    static void Main(string[] args)
    {
      Animal firstAnimal = new Animal(args[0]);
      firstAnimal.species = new Coyote();

      Console.WriteLine("{0} the {1}", firstAnimal.name, firstAnimal.species.commonName);
    }
  }

}

