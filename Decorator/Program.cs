using Decorator;

PersonalCar personalCar = new() { Make = "BMW", Model = "3.20", HirePrice = 2500};

SpecialOffer specialOffer = new(personalCar) { DiscountPercentage = 10 };

Console.WriteLine($"Make: {personalCar.Make}, Model: {personalCar.Model}, HirePrice: {personalCar.HirePrice}");
Console.WriteLine($"Make: {specialOffer.Make}, Model: {specialOffer.Model}, HirePrice: {specialOffer.HirePrice}");