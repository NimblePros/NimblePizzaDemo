using NimblePizza.FrontEndTests.NUnit.PageObjects;

namespace NimblePizza.FrontEndTests.NUnit
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class Tests : PageTest
    {

        [Test]
        public async Task HomePageHasNimblePizzaTitle()
        {
            HomePage homePage = new HomePage(Page);
            await homePage.NavigateToHomePage();
            // Expect a title "to contain" a substring.
            await Expect(Page).ToHaveTitleAsync(new Regex("Nimble Pizza"));
        }

        [Test]
        public async Task HomePageUpdatesComingSoonTextWhenOrderNowClicked()
        {
            HomePage homePage = new HomePage(Page);

            await homePage.NavigateToHomePage();
            // Expect a title "to contain" a substring.
            var comingSoonText = await homePage.GetComingSoonText();
            await homePage.ClickOrderNowButton();
            Thread.Sleep(5000);
            var updatedComingSoonText = await homePage.GetComingSoonText();
            Assert.That(updatedComingSoonText, Is.Not.EqualTo(comingSoonText));
        }
    }
}
