using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace GherkinTest
{
    [Binding]
    public class SpecFlowFeature1AddingNumbersSteps
    {
        int first_number;
        int second_number;
        int result;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            first_number = p0;
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            second_number = p0;
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            result = first_number + second_number;
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            result.Should().Be(p0);
        }
    }
}


//source: http://cucumber.io/docs/guides/10-minute-tutorial/