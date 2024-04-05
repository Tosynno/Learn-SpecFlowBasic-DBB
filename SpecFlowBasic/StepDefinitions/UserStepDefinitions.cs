using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBasic.StepDefinitions
{
    [Binding]
    internal class UserStepDefinitions
    {
        [Given(@"I enter random user data")]
        public void GivenIEnterRandomUserData()
        {
            //var person = new Fixture().Create<User>();
            var person = new Fixture().Build<User>().With(c => c.Email, "test@exple.com")
                .Create();
            Console.WriteLine($"The User {person.Name} has email {person.Email} and his address {person.Address} with Phone Number {person.Phone}.");
        }

        [Given(@"I input dynamic domain for (.* email)")]
        public void GivenIInputDynamicDomainForTestExple_ComEmail(string email)
        {
            Console.WriteLine($"The random email address is: {email}");
        }


    }
    public record User
    {
        public string Name { get; init; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
    }
}
