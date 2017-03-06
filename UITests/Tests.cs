using NUnit.Framework;
using Xamarin.UITest;

namespace XamU.UITests
{
    [TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

        [Test]
        public void Should_scroll_team_list()
        {
            app.Tap(x => x.Text("Adrian Stevens"));
            app.Tap(x => x.Class("ImageButton"));
            app.ScrollDown(withinMarked:"teamList");
            app.Tap(x => x.Text("Mark Smith"));
            app.Tap(x => x.Class("ImageButton"));
            app.Tap(x => x.Text("Rob Gibbens"));
            app.Tap(x => x.Class("ImageButton"));
        }

	}
}