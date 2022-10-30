using TestStack.BDDfy;
using TestStack.BDDfy.Configuration;
using TestStack.BDDfy.Reporters.Html;
using Xunit;


namespace Atm.Domain.Tests.Acceptance
{
    [Story(AsA = "Account Holder",
        IWant = "to withdraw cash from an ATM",
        SoThat = "I can get money when the bank is closed")]
    public class WithdrawCashFromAnAtm
    {
        private readonly Steps __;

        public WithdrawCashFromAnAtm()
        {
            Configurator.BatchProcessors.HtmlReport.Disable();
            Configurator.BatchProcessors.Add(new HtmlReporter(new CustomAtmHtmlReport(), new MetroReportBuilder()));
            __ = new Steps();
        }

        [Fact]
        public void AccountHasInsufficientFund()
        {
            this.Given(_ => __.TheAccountBalanceIs(10), "Given the account balance is $10")
                .And(_ => __.TheCardIsValid())
                .And(_ => __.TheMachineContainsEnoughMoney())
                .When(_ => __.TheAccountHolderRequests(20), "When The Account Holder Requests $20")
                .Then(_ => __.TheAtmShouldDispense(0), "Then the atm should not Dispense any money")
                .And(_ => __.TheAtmShouldSay(DisplayMessage.InsufficientFunds),
                    "And The Atm Should Say There Are Insufficient Funds")
                .And(_ => __.TheCardShouldBeReturned())
                .BDDfy();
            //this.BDDfy();
        }

        [Fact]
        public void AtmRetainsTheCard()
        {
            this.Given(_ => __.TheAccountBalanceIs(10), "Given the account balance is $10")
                .And(_ => __.TheCardIsInvalid())
                .And(_ => __.TheMachineContainsEnoughMoney())
                .When(_ => __.TheAccountHolderRequests(20), "When the account holder requests $20")
                .Then(_ => __.TheAtmShouldDispense(0), "Then the atm should not Dispense any money")
                .And(_ => __.TheAtmShouldSay(DisplayMessage.CardIsRetained),
                    "And The Atm Should Say Card Is Retained")
                .And(_ => __.TheCardShouldBeRetained())
                .BDDfy();
        }

        [Fact]
        public void AccountHolderCanWithdrawCashFromAtm()
        {
            this.Given(_ => __.TheAccountBalanceIs(20), "Given the account balance is $20")
                .And(_ => __.TheCardIsValid())
                .And(_ => __.TheMachineContainsEnoughMoney())
                .When(_ => __.TheAccountHolderRequests(12), "When the account holder requests $12")
                .Then(_ => __.TheAtmShouldDispense(12), "Then the atm should not Dispense any money")
                .And(_ => __.TheAccountBalanceShouldBecome(8))
                .And(_ => __.TheCardShouldBeReturned())
                .BDDfy();
        }
    }
}