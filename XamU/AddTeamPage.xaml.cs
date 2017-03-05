using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamU
{
	public partial class AddTeamPage : ContentPage
	{
		public AddTeamPage()
		{
			InitializeComponent();
		}
		TeamViewModel _vm;
		public AddTeamPage(TeamViewModel vm)
		{
			InitializeComponent();
			_vm = vm;
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			var teamMember = new TeamMember 
			{
				Name = name.Text,
				Title = title.Text,
				Description = description.Text,
				Icon = icon.Text
			};

			_vm.Add(teamMember);
			Navigation.PopAsync(true);
		}
	}
}
