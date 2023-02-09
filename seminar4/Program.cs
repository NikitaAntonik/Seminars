// string s1 = "Hello";
// string s2 = "World";
// string s3 = s1 + s2; 
// // Console.WriteLine(s3.Length);
// Console.WriteLine(s3);
// string s4 = s3.Replace('o', '');
// Console.WriteLine(s4);

// int[] num = {1, 2, 3, 4, 5};
// string s5 = string.Join("***", num);
//  Console.WriteLine(s5);

 string s = "1, 2, 3, 4, 5, 6, 7.";
 string[] nums = s.Split(new char[] {' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);

int[] n = nums.Select(Int32.Parse).ToArray();
 foreach (var item in nums)
 {
    Console.WriteLine(item);
 }

 int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);