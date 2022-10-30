using TestStack.BDDfy.Reporters.Html;

namespace Atm.Domain.Tests.Acceptance
{
    public class CustomAtmHtmlReport : DefaultHtmlReportConfiguration
    {
        public override string ReportHeader => "ATM Feature Specifications";
        public override string ReportDescription => "This Report Contains All Scenario Test Results For ATM Feature";
        public override string OutputFileName => "ATM.html";
    }
}
