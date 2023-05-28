//Use string interpolation to combine the firstName and lastName variables into a single string

var firstName = "Precious";
var lastName  = "Oranye";
var interpol  = $"My name is {firstName} {lastName}";

var interpol2 = $"{interpol} and my age is {20 + 9}";

Console.WriteLine(interpol2);
