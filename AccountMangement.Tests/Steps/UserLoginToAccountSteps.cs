using System.Linq;
using AccountManagement;
using FluentAssertions;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace AccountMangement.Tests.Steps
{
    [Binding]
    public class UserLoginToAccountSteps
    {
        private string _result;
        private Account _account;
        private DataStore _store;
        private readonly ScenarioContext _scenarioContext;

        public UserLoginToAccountSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        //[Before]
        //public void ScenarioSetup()
        //{
        //}

        //[After]
        //public void ScenarioTearDown()
        //{
        //}

        [Given(@"Something Happens")]
        public void GivenSomethingHappens()
        {
            ScenarioContext.Current.Pending();
        }



        [Given(@"i am (.*) with password (.*)")]
        public void GivenIAmWithPassword(string username, string password)
        {
            _account = new Account(username, password);
        }

        [Given(@"the following users are already available")]
        public void GivenTheFollowingUsersAreAlreadyAvailable(Table table)
        {
            //var account = table.CreateInstance<Account>();
            var accounts = table.CreateSet<Account>().ToList();
            _store = new DataStore(accounts);
        }

        [When(@"i try to login to my account")]
        public void WhenITryToLoginToMyAccount()
        {
            _result = _account.Authenticate(_store);
        }

        [Then(@"i should get message (.*)")]
        public void ThenIShouldGetMessage(string output)
        {
            _result.Should().Be(output);
        }


        [Given(@"the current total is ""(.*)""")]
        public void GivenTheCurrentTotalIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter ""(.*)""")]
        public void WhenIEnter(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter ""(.*)""")]
        public void WhenIEnter(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the current total should be ""(.*)""")]
        public void ThenTheCurrentTotalShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}