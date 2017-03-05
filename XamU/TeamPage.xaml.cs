using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamU
{
	public partial class TeamPage : ContentPage
	{
		public TeamPage()
		{
			InitializeComponent();
			this.BindingContext = new TeamViewModel();

		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			var vm = this.BindingContext as TeamViewModel;
			
			var teamMember = (TeamMember)e.SelectedItem;
			Navigation.PushAsync(new TeamDetailPage(vm, teamMember));
		}

		void Handle_Activated(object sender, System.EventArgs e)
		{
			var vm = this.BindingContext as TeamViewModel;
			Navigation.PushAsync(new AddTeamPage(vm));
		}
	}
}
