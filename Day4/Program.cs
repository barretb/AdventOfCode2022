Console.WriteLine("Advent of Code 2022");
Console.WriteLine("Day 4");

//Solution logic goes here

//Load input array
string[] lines = System.IO.File.ReadAllLines("input.txt");

var score = 0;
var p2Score = 0;
for (int i = 0; i < lines.Length; i++)
{
    var line = lines[i];

    var split = line.Split(',');
    var elf1 = split[0];
    var elf2 = split[1];

    var elf1Split = elf1.Split('-');
    var elf2Split = elf2.Split('-');

    var elf1Min = Convert.ToInt32(elf1Split[0]);
    var elf1Max = Convert.ToInt32(elf1Split[1]);
    var elf2Min = Convert.ToInt32(elf2Split[0]);
    var elf2Max = Convert.ToInt32(elf2Split[1]);

    if (elf2Min >= elf1Min && elf2Max <= elf1Max) score++;
    else if (elf1Min >= elf2Min && elf1Max <= elf2Max) score++;

    var overlap = Math.Max(0, Math.Min(elf1Max, elf2Max) - Math.Max(elf1Min, elf2Min) + 1);
    if (overlap > 0) p2Score++;
}

Console.WriteLine($"Total score: {score}");
Console.WriteLine($"Part 2 total score: {p2Score}");



//Stop and wait for enter before exiting
Console.ReadLine();