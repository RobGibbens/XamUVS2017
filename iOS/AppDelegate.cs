using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

namespace XamU.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			// Code for starting up the Xamarin Test Cloud Agent


			Xamarin.Calabash.Start();

			LoadApplication(new App());
			return base.FinishedLaunching(app, options);
		}


		//private void AddContact()
		//{
		//	var contact = new CNMutableContact();

		//	// Set standard properties
		//	contact.GivenName = "John";
		//	contact.FamilyName = "Appleseed";

		//	// Add email addresses
		//	var homeEmail = new CNLabeledValue<NSString>(CNLabelKey.Home, new NSString("john.appleseed@mac.com"));
		//	var workEmail = new CNLabeledValue<NSString>(CNLabelKey.Work, new NSString("john.appleseed@apple.com"));
		//	contact.EmailAddresses = new CNLabeledValue<NSString>[] { homeEmail, workEmail };

		//	// Add phone numbers
		//	var cellPhone = new CNLabeledValue<CNPhoneNumber>(CNLabelPhoneNumberKey.iPhone, new CNPhoneNumber("713-555-1212"));
		//	var workPhone = new CNLabeledValue<CNPhoneNumber>("Work", new CNPhoneNumber("408-555-1212"));
		//	contact.PhoneNumbers = new CNLabeledValue<CNPhoneNumber>[] { cellPhone, workPhone };

		//	// Add work address
		//	var workAddress = new CNMutablePostalAddress()
		//	{
		//		Street = "1 Infinite Loop",
		//		City = "Cupertino",
		//		State = "CA",
		//		PostalCode = "95014"
		//	};
		//	contact.PostalAddresses = new CNLabeledValue<CNPostalAddress>[] { new CNLabeledValue<CNPostalAddress>(CNLabelKey.Work, workAddress) };

		//	// Add birthday
		//	var birthday = new NSDateComponents()
		//	{
		//		Day = 1,
		//		Month = 4,
		//		Year = 1984
		//	};
		//	contact.Birthday = birthday;

		//	// Save new contact
		//	var store = new CNContactStore();
		//	var saveRequest = new CNSaveRequest();
		//	saveRequest.AddContact(contact, store.DefaultContainerIdentifier);

		//	NSError error;
		//	if (store.ExecuteSaveRequest(saveRequest, out error))
		//	{
		//		Console.WriteLine("New contact saved");
		//	}
		//	else
		//	{
		//		Console.WriteLine("Save error: {0}", error);
		//	}
		//}
	}
}
