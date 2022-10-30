using FluentAssertions;

namespace Atm.Domain.Tests.Acceptance
{
    public class Steps
    {
        private Card _card;
        private Atm _atm;

        //[Given]
        public void TheAccountBalanceIs(int balance)
        {
            _card = new Card(balance);
        }

        //[AndGiven]
        public void TheCardIsValid()
        {
            _card.IsValid();
        }

        //[AndGiven]
        public void TheMachineContainsEnoughMoney()
        {
            _atm = new Atm(50);
        }

        //[When]
        public void TheAccountHolderRequests(int amount)
        {
            _atm.RequestMoney(_card, amount);
        }
        
        //[AndThen]
        public void TheAtmShouldSay(DisplayMessage message)
        {
            _atm.Message.Should().Be(message);
        }

        //[AndThen]
        public void TheCardShouldBeReturned()
        {
            _atm.CardIsRetained.Should().BeFalse();
        }

        public void TheCardIsInvalid()
        {
            _card.IsInvalid();
        }

        public void TheCardShouldBeRetained()
        {
            _atm.CardIsRetained.Should().BeTrue();
        }

        public void TheAtmShouldDispense(int amount)
        {
            _atm.DispenseValue.Should().Be(amount);
        }

        public void TheAccountBalanceShouldBecome(int balance)
        {
            _card.AccountBalance.Should().Be(balance);
        }
    }
}