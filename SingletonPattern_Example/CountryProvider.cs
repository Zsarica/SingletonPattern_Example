using SingletonPattern_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern_Example
{
    public class CountryProvider
    {
        
        private static CountryProvider instance = null;

        /* not simplify
        public static CountryProvider Instance 
        {
            get
            {
                if (instance is  null)
                {
                    instance = new CountryProvider();
                    
                }  
                return instance; 
            } 
            set => instance = value;
        }
        */

        //Simplify
        public static CountryProvider Instance => instance ?? (instance = new CountryProvider());

        private new List<Country> Countries { get;  set; }

        private CountryProvider()  //constructor should be private
        {
            Task.Delay(2000).Wait();
            Countries = new List<Country>()
            {
                new Country()
                {
                    Name="Türkiye"
                },
                new Country()
                {
                    Name="Birleşik Krallık"
                }
            };
        }

        public async Task<List<Country>> GetCountries() => Countries;
       
    }
}
