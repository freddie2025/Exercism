using System;
using System.Linq;

[Flags]
public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
	private int _mask;
    private static Allergen _allergen;
	
    public Allergies(int mask)
    {
		_mask = mask;        
        _allergen = new Allergen();
        _allergen |= (Allergen)_mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return _allergen.HasFlag(allergen);
    }

    public Allergen[] List()
    {
        return Enum.GetValues(typeof(Allergen)).Cast<Allergen>().Where(x => _allergen.HasFlag(x)).ToArray();
    }
}