// See https://aka.ms/new-console-template for more information

/***************************************************************************
*
*   Practice creating, adding to, getting the length, and parsing a list
*
****************************************************************************/

using System;
using System.Collections.Generic;

// Create and save the list to an object 
List<int> nums = new List<int>();
List<string> strings = new List<string>();

// Adding to a list
nums.Add(1);
nums.Add(10);
nums.Add(999);

strings.Add("Toyota");
strings.Add("Nissan");
strings.Add("Honda");
strings.Add("Mazda");

// Getting the list size
Console.WriteLine($"This is the length of the nums list: {nums.Count}");
Console.WriteLine($"This is the length of the strings list: {strings.Count}");

// Iterating thru a list (best and safest way)
foreach (int num in nums){
    Console.WriteLine(num);
}
foreach (string str in strings){
    Console.WriteLine(str);
}

// Iterating by accessing the items by their index 
for (int i = 0; i < nums.Count; i++){
    Console.WriteLine(nums[i]);
}
for (int i = 0; i < strings.Count; i++){
    Console.WriteLine(strings[i]);
}