using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamU
{
	public partial class TeamDetailPage : ContentPage
	{
		public TeamDetailPage()
		{
			InitializeComponent();
		}

		readonly TeamViewModel vm;
		readonly TeamMember teamMember;

		public TeamDetailPage(TeamViewModel vm, TeamMember teamMember)
		{
			this.teamMember = teamMember;
			this.vm = vm;
			InitializeComponent();
			this.BindingContext = teamMember;
		}

		void Handle_Activated(object sender, System.EventArgs e)
		{

			vm.Delete(teamMember);
			Navigation.PopAsync(true);
		}
	}
}
