//declaring a string array 

string[]  memberNames;
memberNames = new string[] { "Chika", "Edu", "Tola", "Ade", "Blessing" };

//get Tola using her index
Console.WriteLine(memberNames[2]);

//get all the names in the array
for(int i = 0; i < memberNames.Length; i++)
{
	    Console.WriteLine(memberNames[i]);
}
