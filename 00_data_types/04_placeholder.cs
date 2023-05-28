//format the following code snippet using composite format placeholder

var name = "Precious";
var lastName = "Oranye";
var age = 30;


string templateText = "My name is {0} {1}, and I am {2} yars old.";
string result = string.Format(templateText, name, lastName, age);

Console.WriteLine(result);
