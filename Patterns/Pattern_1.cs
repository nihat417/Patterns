using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns;

interface IChair
{
    public void haslegs();
    public void sitOn();
}

class VictorianChair: IChair
{
    public void haslegs() => Console.WriteLine("victorian chair has legs");
    public void sitOn() => Console.WriteLine("victorian chair sitOn");
}

class ModernChair: IChair
{
    public void haslegs() => Console.WriteLine("Moddernchair leghs");
    public void sitOn() => Console.WriteLine("Modern sitOn");
}



///
public interface ICoffeeTable
{
    void isRound();
    void placeOn();
}

public class VictorianCoffeeTable : ICoffeeTable
{
    public void isRound() => Console.WriteLine("Is Round");
    public void placeOn() => Console.WriteLine($"Placed on victorian cofeetable");
}

public class ModernCoffeeTable : ICoffeeTable
{
    public void isRound() => Console.WriteLine("Is Round");
    public void placeOn() => Console.WriteLine($"Placed on victorian cofeetable");
}


///

public interface ISofa
{
    void haslegs();
    void sitOn();
}

class VictorianSofa : ISofa
{
    public void haslegs() => Console.WriteLine("sofa has legs");
    public void sitOn() => Console.WriteLine("sofa sitOn");
}

class Modernsofa : IChair
{
    public void haslegs() => Console.WriteLine("Moddern sofa leghs");
    public void sitOn() => Console.WriteLine("Modern sofa sitOn");
}

interface FurnitureFactory
{
    public IChair createChair();
    public  ISofa createSofa();
    public  ICoffeeTable createCoffeeTable();
}

class VictorianFurnitureFactory : FurnitureFactory
{
    public  IChair createChair() => new VictorianChair();

    public  ICoffeeTable createCoffeeTable() => new VictorianCoffeeTable();

    public  ISofa createCoffeeTable() => new VictorianSofa();
}

class ModernFurnitureFactory : FurnitureFactory
{
    public  IChair createChair() => new ModernChair();

    public  ICoffeeTable createCoffeeTable() => new ModernCoffeeTable();

    public  ISofa createSofa() => new Modernsofa();
}

