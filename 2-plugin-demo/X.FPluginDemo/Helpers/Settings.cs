using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace X.FPluginDemo.Helpers
{
	/// <summary>
	/// This is the Settings static class that can be used in your Core solution or in any
	/// of your client applications. All settings are laid out the same exact way with getters
	/// and setters. 
	/// </summary>
	public static class Settings
	{
		static ISettings AppSettings {
			get {
				return CrossSettings.Current;
			}
		}

		#region Setting Constants

		const string StringSettingKey = "somestring";
		static readonly string StringSettingDefault = string.Empty;
		const string BoolSettingKey = "somebool";
		static readonly bool BoolSettingDefault = false;

		#endregion


		public static string StringSetting {
			get {
				return AppSettings.GetValueOrDefault<string> (StringSettingKey, StringSettingDefault);
			}
			set {
				AppSettings.AddOrUpdateValue<string> (StringSettingKey, value);
			}
		}

		public static bool BoolSetting {
			get {
				return AppSettings.GetValueOrDefault<bool> (BoolSettingKey, BoolSettingDefault);
			}
			set {
				AppSettings.AddOrUpdateValue<bool> (BoolSettingKey, value);
			}
		}
	}
}
