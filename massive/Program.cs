string name1 = "Bob";
string name2 = "Sara";
string name3 = "Mary";
string name4 = "John";
string name5 = "Ann";

string[] names = {name1, "Sara", name3, name4, name5};

Console.WriteLine(names[2]);
names[0] = "Andry";
Console.WriteLine(names[0]);

int[] nums = {1, 3, 5, 7};
// int[] nums = new int[4] {1, 3, 5, 7};
// int[] nums = new int[] {1, 3, 5, 7};
// int[] nums = new[] {1, 3, 5, 7};
// int[] nums = new int[4];

Console.WriteLine(names.Length);
// Console.WriteLine(names[names.Length]);

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}


foreach (int item  in nums)
{
     Console.WriteLine(item);
}