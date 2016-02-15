using System;
using System.ComponentModel;
using Xamarin.Forms;
using X.FPluginDemo.Helpers;

namespace X.FPluginDemo
{
	public class SettingsViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged = delegate { };

		public SettingsViewModel ()
		{
			SomeStringSetting = Settings.StringSetting;
			SomeBoolSetting = Settings.BoolSetting;
		}

		string _SomeStringSetting;
		public string SomeStringSetting {
			get { return _SomeStringSetting; }
			set {
				if (_SomeStringSetting != value) {
					_SomeStringSetting = value;
					Settings.StringSetting = SomeStringSetting;
					PropertyChanged (this, new PropertyChangedEventArgs (nameof (SomeStringSetting)));
				}
			}
		}

		bool _SomeBoolSetting;
		public bool SomeBoolSetting {
			get { return _SomeBoolSetting; }
			set {
				if (_SomeBoolSetting != value) {
					_SomeBoolSetting = value;
					Settings.BoolSetting = SomeBoolSetting;
					PropertyChanged (this, new PropertyChangedEventArgs (nameof (SomeBoolSetting)));
				}
			}
		}
	}

	public class App : Application
	{
		public App ()
		{
			var stringSettingEntry = new Entry ();
			stringSettingEntry.SetBinding (Entry.TextProperty, nameof (SettingsViewModel.SomeStringSetting));

			var boolSettingSwitch = new Switch ();
			boolSettingSwitch.SetBinding (Switch.IsToggledProperty, nameof (SettingsViewModel.SomeBoolSetting));

			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							Text = "Some String"
						},
						stringSettingEntry,
						new Label {
							Text = "Some Bool"
						},
						boolSettingSwitch,
					}
				}
			};

			MainPage.BindingContext = new SettingsViewModel ();
		}
	}
}
