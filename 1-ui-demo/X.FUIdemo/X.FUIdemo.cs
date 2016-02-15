using System.Linq;
using Xamarin.Forms;

namespace X.FUIdemo
{
	public class App : Application
	{
		public App ()
		{
			var mainPage = new CodedPage ();
			var navigationPage = new NavigationPage (mainPage);
			mainPage.ItemSelected += async (sender, e) => {
				var detailPage = new DetailPage {
					BindingContext = e,
				};
				await navigationPage.PushAsync (detailPage);
			};

			// The root page of your application
			MainPage = navigationPage;
			MainPage.BindingContext = ViewModel;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

		static SomeViewModel ViewModel = new SomeViewModel {
			SomeLabel = "Test label value",
			SomeItems = new[] {
				"http://24.media.tumblr.com/tumblr_lznhyketRf1qgjltdo1_1280.jpg",
				"http://24.media.tumblr.com/tumblr_m0tyofAs9Z1qctwmwo1_500.jpg",
				"http://24.media.tumblr.com/tumblr_lwp6zsdbz51qzv52ko1_1280.jpg",
				"http://24.media.tumblr.com/tumblr_m80b8f4fQH1qhwlspo1_1280.jpg",
				"http://25.media.tumblr.com/tumblr_m3aqpbyCRi1qhwmnpo1_1280.jpg",
				"http://27.media.tumblr.com/tumblr_lykrsxTZF41qh66wqo1_1280.jpg",
				"http://24.media.tumblr.com/tumblr_m2vjertI1I1qbe5pxo1_500.jpg",
				"http://24.media.tumblr.com/tumblr_m9dnyhLaaL1rvmd21o1_1280.jpg",
				"http://24.media.tumblr.com/tumblr_ln04z2cFB41qbt33io1_1280.jpg",
				"http://25.media.tumblr.com/tumblr_m24l7aeure1qafc06o1_500.jpg",
				"http://24.media.tumblr.com/tumblr_m4hacnwtls1qd477zo1_400.jpg",
				"http://30.media.tumblr.com/tumblr_lhdofbRmdW1qfyzelo1_500.jpg",
				"http://25.media.tumblr.com/tumblr_m4qd6gDbvr1qd477zo1_1280.jpg",
				"http://29.media.tumblr.com/tumblr_m1uj9ude4c1r6b7kmo1_1280.jpg",
				"http://25.media.tumblr.com/tumblr_m3qhebdPvD1qhwmnpo1_1280.jpg",
				"http://25.media.tumblr.com/tumblr_kop8gyEzai1qzv5pwo1_400.jpg",
				"http://25.media.tumblr.com/tumblr_m0xhzlszFR1r6b7kmo1_1280.jpg",
				"http://25.media.tumblr.com/tumblr_lnvzjlME4W1qcutcto1_1280.jpg",
				"http://25.media.tumblr.com/tumblr_lw40r2U2mY1qjkm6go1_500.jpg",
				"http://30.media.tumblr.com/tumblr_m1287q5zCN1qjahcpo1_400.jpg",
				"http://24.media.tumblr.com/tumblr_ly2lzj9yzP1qk4s2co1_1280.jpg",
				"http://24.media.tumblr.com/tumblr_m0e8hbPGp11qdvbl3o1_1280.jpg",
				"http://25.media.tumblr.com/tumblr_m48i6k2Fea1qbiu5fo1_500.jpg",
				"http://25.media.tumblr.com/tumblr_m23gbtouuw1qzx83ho1_1280.jpg",
				"http://24.media.tumblr.com/tumblr_m2xlsnGhJt1qejbiro1_1280.jpg",
				"http://30.media.tumblr.com/tumblr_lymw8a6qVs1qzbbeho1_1280.jpg",
				"http://26.media.tumblr.com/tumblr_lpnkm2ZslO1qzv52ko1_1280.jpg",
				"http://27.media.tumblr.com/Jjkybd3nSf6si3xaWMpO4dFmo1_400.jpg",
				"http://24.media.tumblr.com/tumblr_m1j3p3YcPo1qa9omho1_1280.jpg",
				"http://24.media.tumblr.com/tumblr_m3d8d2DBwl1qddbvio1_500.jpg",
				"http://25.media.tumblr.com/tumblr_m2fsevSl2G1r6b7kmo1_500.jpg",
				"http://25.media.tumblr.com/tumblr_lt9mr7rBO01qcla69o1_1280.jpg",
				"http://24.media.tumblr.com/tumblr_m1hn70ZQQx1qze0hyo1_1280.jpg",
				"http://29.media.tumblr.com/tumblr_kp2mfq3XOg1qzv5pwo1_400.jpg",
				"http://25.media.tumblr.com/tumblr_llop9gAl0T1qhwmnpo1_1280.jpg",
				"http://24.media.tumblr.com/tumblr_m1fqg4EXmB1qze0hyo1_1280.jpg",
				"http://25.media.tumblr.com/tumblr_m2y3a1wMh71qbe5pxo1_1280.jpg",
				"http://24.media.tumblr.com/tumblr_mbvrx92vHL1qze0hyo1_500.jpg",
				"http://25.media.tumblr.com/tumblr_lx8on3Z51C1qbcporo1_500.jpg",
				"http://25.media.tumblr.com/tumblr_m437ucdS8X1qhwmnpo1_1280.jpg",
				"http://25.media.tumblr.com/tumblr_m2uywjIVrL1qdwizao1_1280.jpg",
				"http://25.media.tumblr.com/tumblr_m4rwf0q6Bl1r6jd7fo1_500.jpg",
				"http://25.media.tumblr.com/tumblr_lzt8u0wx0F1qi23vmo1_500.jpg",
				"http://24.media.tumblr.com/tumblr_ly1m64ofjV1qzv52ko1_1280.jpg",
				"http://25.media.tumblr.com/tumblr_ljj97iLKIs1qgnva2o1_500.jpg",
				"http://28.media.tumblr.com/tumblr_ly7rtpsCSc1qgop81o1_1280.jpg",
				"http://25.media.tumblr.com/tumblr_lhiz434MbD1qgnva2o1_500.jpg",
				"http://24.media.tumblr.com/tumblr_mahybrVJUP1qf6rpvo1_1280.jpg",
				"http://24.media.tumblr.com/tumblr_m1uk0x7pb91r6b7kmo1_500.jpg",
				"http://25.media.tumblr.com/tumblr_lstb78xavA1r4xjo2o1_1280.jpg",
			}.Select ((imgUrl, i) => new SomeItem {
				ItemName = $"item {i}",
				ImageUrl = imgUrl,
				Details = Enumerable.Range (0, 100).Select (j => $"item:{i}, detail:{j}").ToList (),
			}).ToList (),
		};
	}
}

