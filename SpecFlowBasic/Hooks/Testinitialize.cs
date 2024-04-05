using TechTalk.SpecFlow;

namespace SpecFlowBasic.Hooks
{
    [Binding]
    public sealed class Testinitialize
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeTestRun]
        public static void BeforeTest()
        {
            Console.WriteLine("This is executed from before test");
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            Console.WriteLine("This is executed from before feature");
        }

        [BeforeScenario("@mytag")]
        public void BeforeScenarioWithTag()
        {
            Console.WriteLine("This is executed from before scenario with tag");
        }

 
        [AfterScenario]
        public void AfterScenario()=> Console.WriteLine("This is executed from After scenario");
    }
}