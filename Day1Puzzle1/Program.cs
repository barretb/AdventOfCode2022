Console.WriteLine("Advent of Code 2022");
Console.WriteLine("Day 1");

//Solution logic goes here

//Load input array
string[] lines = System.IO.File.ReadAllLines("input.txt");

var elves = new Dictionary<int, int>();
var elfId = 1;
for (int i = 0; i < lines.Length; i++)
{
    var calories = 0;
    int.TryParse(lines[i], out calories);
    if(calories > 0)
    {
        if (elves.ContainsKey(elfId))
        {
            elves[elfId] = elves[elfId] + calories;
        } else
        {
            elves[elfId] = calories;
        }
    } else
    {
        elfId++;
    }    
}

//foreach (var item in elves)
//{
//    Console.WriteLine($"{item.Key}  {item.Value}");
//}

var top = elves.OrderByDescending(x => x.Value).First();

Console.WriteLine($"Part 1:  {top.Key} has {top.Value} calories");

var top3 = (elves.OrderByDescending(x => x.Value).Take(3)).Sum(x => x.Value);

Console.WriteLine($"Part 2: Top 3 elves are carrying: {top3} calories");



//Stop and wait for enter before exiting
Console.ReadLine();