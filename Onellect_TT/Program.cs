using Onellect_TT;
using Onellect_TT.Sorters;
using System.Configuration;
using System.Xml.Serialization;

ConfigManager configManager = new ConfigManager();
Console.WriteLine(configManager.ConfigExists);
if(configManager.TryGetConfigData(out var configData))
{
    Console.WriteLine(configData.ApiUrl);
}

SortManager sortManager = new SortManager();
RandomNumbersGenerator randomNumbersGenerator = new RandomNumbersGenerator() 
{ 
    MinCount = 20,
    MaxCount = 100,
    MinValue = -100,
    MaxValue = 100,
};



var numbers = randomNumbersGenerator.GetRandomNumbersList();
Console.WriteLine("Not sorted numbers:");
Console.WriteLine(string.Join(' ', numbers));
Console.WriteLine(Environment.NewLine);

var sorter = sortManager.GetRandomSorter();
var sortedNumbers = sorter.SortMethodName;
Console.WriteLine($"Sorted numbers({sortedNumbers}):");
Console.WriteLine(string.Join(' ', sorter.Sort(numbers)));



Console.ReadLine();