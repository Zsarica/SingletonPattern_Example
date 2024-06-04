
using SingletonPattern_Example;


Console.WriteLine(DateTime.Now.ToLongTimeString());
var cauntries = await CountryProvider.Instance.GetCountries();


foreach (var country in cauntries)
{
    Console.WriteLine(country.Name);
}

//Another service



var cauntries1 = await CountryProvider.Instance.GetCountries();

Console.WriteLine(DateTime.Now.ToLongTimeString());
