using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.StepDefinitions
{
    public class TestLoginwithParameter
    {
        [When(@"User enters the ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersTheAnd(string username, string password)
        {
            Console.WriteLine("The user name is " + username + "..........." + "The password is" + password);
        }

        public void ThenUserSlectsCityAndCountryInformation(Table table)
        {
            foreach (var row in table.Rows)
            {
                string city = row["city"];
                string country = row["country"];
                Console.WriteLine(city + "," + country);
            }
        }
    }
}
