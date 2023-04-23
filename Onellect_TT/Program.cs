using Onellect_TT;
using Onellect_TT.Sorters;
using System.Configuration;
using System.Xml.Serialization;


ConfigManager configManager = new ConfigManager();
SortManager sortManager = new SortManager();
RandomNumbersGenerator randomNumbersGenerator = new RandomNumbersGenerator() 
{ 
    MinCount = 20,
    MaxCount = 100,
    MinValue = -100,
    MaxValue = 100,
};
ApiController apiController = new ApiController();

ConfigData configdata;
if (configManager.TryGetConfigData(out configdata) == false)
    throw new FileNotFoundException("Config file doesn't exists");

var numbers = randomNumbersGenerator.GetRandomNumbersList();

Console.WriteLine("Not sorted numbers:");
Console.WriteLine(string.Join(' ', numbers));
Console.WriteLine(Environment.NewLine);

var sorter = sortManager.GetRandomSorter();
var sortMethodName = sorter.SortMethodName;
var sortedNumbers = sorter.Sort(numbers);

Console.WriteLine($"Sorted numbers({sortMethodName}):");
Console.WriteLine(string.Join(' ', sortedNumbers));

var response = await apiController.SendNumbers(sortedNumbers, configdata.ApiUrl);
Console.WriteLine($"Responce status: {response.IsSuccessStatusCode} - {response.StatusCode}");

Console.ReadLine();