using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace GherkinTest
{
    class IsItAWorkday
    {
        public static String isItAWorkday(String today)
        {
            if (today.Equals("Saturday")||today.Equals("Sunday"))
            { return "No!"; } 
            else 
            { return "Yes!"; }
        }
    }

    [Binding]
    public class SpecFlowFeature2WorkTimeSteps
    {
        String today;
        String actualAnswer;

        [Given(@"today is ""(.*)""")]
        public void GivenTodayIs(string today)
        {
            this.today = today;
        }
        
        [When(@"I ask if I should work today")]
        public void WhenIAskIfIShouldWorkToday()
        {
            actualAnswer = IsItAWorkday.isItAWorkday(today);
        }
        
        [Then(@"I should be told ""(.*)""")]
        public void ThenIShouldBeTold(string expectedAnswer)
        {
            expectedAnswer.Should().Be(actualAnswer);
        }
    }
}
