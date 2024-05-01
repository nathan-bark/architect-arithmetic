static void CalculateTotalCost()
{
    // Formulae for calculating the area of different shapes
    static double Square(double side)
    {
        return side * side;
    }

    static double Rectangle(double length, double width)
    {
        return length * width;
    }

    static double Circle(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    static double Triangle(double bottom, double height)
    {
        return 0.5 * bottom * height;
    }

    // Calculate total costs of different buildings

    double teotihuacan = Rectangle(2500, 1500) + Triangle(750, 500) + (Circle(375) / 2);

    double tajMahal = Square(90.5) - (Triangle(24, 24) * 4);

    double greatMosqueOfMecca = Rectangle(180, 106) + (Rectangle(284, 264) - Triangle(84, 264));

    //Get users input

    Console.WriteLine("Enter the name of the building you want to calculate the cost for: ");
    string building = Console.ReadLine().ToLower();
    double buildingCost;
    double cost;

    switch (building) {
        case "teotihuacan":
            buildingCost = teotihuacan * 180;
            cost = Math.Round(buildingCost, 2);
            Console.WriteLine($"The total cost of building {building} is {cost} pesos");
            break;
        case "taj mahal":
            buildingCost = tajMahal * 180;
            cost = Math.Round(buildingCost, 2);
            Console.WriteLine($"The total cost of building {building} is {cost} pesos");
            break;
        case "great mosque of mecca":
            buildingCost = greatMosqueOfMecca * 180;
            cost = Math.Round(buildingCost, 2);
            Console.WriteLine($"The total cost of building {building} is {cost} pesos");
            break;
        default:
            Console.WriteLine("Invalid building name");
            break;
    }
}

CalculateTotalCost();



