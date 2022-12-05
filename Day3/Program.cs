Console.WriteLine("Advent of Code 2022");
Console.WriteLine("Day 3");

//Solution logic goes here

//Load input array
string[] lines = System.IO.File.ReadAllLines("input.txt");

var counts = new Dictionary<int, int>();
var score = 0;
for (int i = 0; i < lines.Length; i++)
{
    var line = lines[i];
    var compartment1 = line.Substring(0,line.Length / 2);
    var compartment2 = line.Substring(line.Length / 2, line.Length / 2);

    //Console.WriteLine(compartment1);
    //Console.WriteLine(compartment2);

    var intersect = compartment1.Intersect(compartment2);

    var common = intersect.First();
    var charVal = Convert.ToInt32(common);
    if(charVal>=65 && charVal <= 90)
    {
        score += (charVal - 38);
        //Console.WriteLine($"{common} -- {charVal - 38}");
    } else
    {
        score += (charVal - 96);
        //Console.WriteLine($"{common} -- {charVal - 96}");
    }

    //Console.WriteLine();
    //Console.WriteLine();
}

Console.WriteLine($"Total score: {score}");

var p2Score = 0;
for(int j = 0; j < lines.Length; j+=3)
{
    var line1 = lines[j];
    var line2 = lines[j + 1];
    var line3 = lines[j + 2];

    //Console.WriteLine(line1);
    //Console.WriteLine(line2);
    //Console.WriteLine(line3);

    var intersect = line1.Intersect(line2).Intersect(line3);
    //foreach (var item in intersect)
    //{
    //    Console.Write(item);
    //}
    //Console.WriteLine();
    //Console.WriteLine(intersect.Count());
    //Console.WriteLine();
    //Console.WriteLine();


    var common = intersect.First();
    var charVal = Convert.ToInt32(common);
    if (charVal >= 65 && charVal <= 90)
    {
        p2Score += (charVal - 38);
        //Console.WriteLine($"{common} -- {charVal - 38}");
    }
    else
    {
        p2Score += (charVal - 96);
        //Console.WriteLine($"{common} -- {charVal - 96}");
    }

}
Console.WriteLine($"Part 2 total score: {p2Score}");


//Stop and wait for enter before exiting
Console.ReadLine();