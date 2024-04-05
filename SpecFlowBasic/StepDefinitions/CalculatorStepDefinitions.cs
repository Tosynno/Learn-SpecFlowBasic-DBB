using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowBasic.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            Console.WriteLine($"{nameof(GivenTheFirstNumberIs)}: {number}");
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            Console.WriteLine($"{nameof(GivenTheSecondNumberIs)}: {number}");
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Console.WriteLine($"{nameof(WhenTheTwoNumbersAreAdded)}");
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            throw new PendingStepException();
        }

        //[Given(@"I  input following numbers to the claculator")]
        //public void GivenIInputFollowingNumbersToTheClaculator(Table table)
        //{
        //    var datas = table.CreateSet<Calculation>();
        //    foreach (var item in datas)
        //    {
        //        Console.WriteLine($"The number is {item.Numbers}");
        //    }

        //}

        [Given(@"I  input following numbers to the claculator")]
        public void GivenIInputFollowingNumbersToTheClaculator(Table table)
        {
            dynamic datas = table.CreateDynamicSet();

            foreach (var item in datas)
            {
                Console.WriteLine($"The numbers are {item.Numbers}");
            }

        }


        [Then(@"the result should ""([^""]*)""")]
        public void ThenTheResultShould(string pASSED)
        {
            throw new PendingStepException();
        }

        [Then(@"I see the result and few more details")]
        public void ThenISeeTheResultAndFewMoreDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            Console.WriteLine($"The result is going to hold the value {data.Results} with log {data.Logo}");
        }


    }
}
