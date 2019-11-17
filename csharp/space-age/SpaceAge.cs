using System;

public class SpaceAge
{
    private const double EarthOrbitalPeriodSeconds = 31557600;
	private int Age;
	
    public SpaceAge(int seconds)
    {
        Age = seconds;
    }

    public double OnEarth()
    {
        return Age / EarthOrbitalPeriodSeconds;
    }

    public double OnMercury()
    {
    	double MercuryOrbitalPeriod = 0.2408467;
		return Age / (EarthOrbitalPeriodSeconds * MercuryOrbitalPeriod);
    }

    public double OnVenus()
    {
        double VenusOrbitalPeriod = 0.61519726;
		return Age / (EarthOrbitalPeriodSeconds * VenusOrbitalPeriod);
    }

    public double OnMars()
    {
        double MarsOrbitalPeriod = 1.8808158;
		return Age / (EarthOrbitalPeriodSeconds * MarsOrbitalPeriod);
    }

    public double OnJupiter()
    {
        double JupiterOrbitalPeriod = 11.862615;
		return Age / (EarthOrbitalPeriodSeconds * JupiterOrbitalPeriod);
    }

    public double OnSaturn()
    {
        double SaturnOrbitalPeriod = 29.447498;
		return Age / (EarthOrbitalPeriodSeconds * SaturnOrbitalPeriod);
    }

    public double OnUranus()
    {
        double UranusOrbitalPeriod = 84.016846;
		return Age / (EarthOrbitalPeriodSeconds * UranusOrbitalPeriod);
    }

    public double OnNeptune()
    {
        double NeptuneOrbitalPeriod = 164.79132;
		return Age / (EarthOrbitalPeriodSeconds * NeptuneOrbitalPeriod);
    }
}