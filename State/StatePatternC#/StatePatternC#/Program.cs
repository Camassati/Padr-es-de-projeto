using StatePatternC_;

var car = new Car();
Console.WriteLine($"State: {car.CurrntState}\n");

car.TakeAction(Car.Action.Start);
Console.WriteLine($"State: {car.CurrntState}\n");

car.TakeAction(Car.Action.Start);
Console.WriteLine($"State: {car.CurrntState} \n");

car.TakeAction(Car.Action.Accelerate);
Console.WriteLine($"State: {car.CurrntState} \n");

car.TakeAction(Car.Action.Stop);
Console.WriteLine($"State: {car.CurrntState} \n");