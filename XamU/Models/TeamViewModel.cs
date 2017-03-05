using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace XamU
{
	public class TeamRepository
	{
		public List<TeamMember> LoadTeam()
		{
			var team = new List<TeamMember>();

			team.Add(new TeamMember { 
				Name = "Rob Gibbens", 
				Icon = "robgibbens.jpg", 
				Title = "Trainer Manager", 
				Description="Rob started coding journey in 1993 on the day the first Mosaic web browser was released. He spent 20+ years as a web developer, primarily on the Microsoft stack. In 2009, he started dabbling with MonoTouch, and was hooked once again, this time on mobile development. When not teaching, Rob will be coding at all hours of the day."});

			team.Add(new TeamMember { 
				Name = "Adrian Stevens", 
				Icon = "adrianstevens.jpg", 
				Title = "Curriculum Manager", 
				Description = "Adrian Stevens has over 15 years of experience developing on mobile platforms with C#, C++ and .NET. Prior to join Xamarin as an instructor, Adrian had released several successful mobile applications developed using Xamarin.iOS &amp; Xamarin.Android. More recently, Adrian leads the Xamarin University curriculum team who are responsible for designing and authoring the live and self-guided training courses." });

			team.Add(new TeamMember { 
				Name = "Chris van Wyk", 
				Icon = "chrisvanwyk.jpg", 
				Title = "Instructor", 
				Description="Chris fell in love with mobile development when Xamarin was still MonoTouch. According to him it’s the perfect developer toolset too create applications that delights users across mobile platforms." });

			team.Add(new TeamMember { 
				Name = "Glenn Stephens", 
				Icon = "glennstephens.jpg", 
				Title = "Instructor", 
				Description="A developer, author and trainer; Glenn started coding 30 years ago and enjoys writing iOS and Android apps. Glenn has worked as a developer, team leader, architect, CEO and is obsessed by mobile technology in all forms." });

			team.Add(new TeamMember { 
				Name = "Kym Phillpotts", 
				Icon = "kymphillpotts.jpg", 
				Title = "Instructor",
				Description = "Kym has a passion for new technologies, hand crafted apps, and coaching developers. He has been slinging code professionally for over 20 years. When Kym isn't beavering away in front of his computer, or participating in hack-fests you might find him travelling and cycling through foreign lands." });

			team.Add(new TeamMember { 
				Name = "Jesse Dietrichson", 
				Icon = "JesseDietrichson.jpg", 
				Title = "Instructor",
				Description = "Jesse began as a self-taught software developer and has been passionate about programming since a very young age. He started his programming career in video game back-end development, and eventually moved to desktop and mobile development. His areas of expertise are .NET development and the C# language." });

			team.Add(new TeamMember { 
				Name = "Jason Deboever", 
				Icon = "jasondeboever.png", 
				Title = "Instructor",
				Description = "Jason has had a varied career as software developer and architect, entrepreneur, nutrition guru, and US Marine. He has been creating software professionally for the last eighteen years, and has presented on a variety of development topics, most often focusing on .NET technologies." });

			team.Add(new TeamMember { 
				Name = "Judy McNeil", 
				Icon = "judymcneil.png",
				Title = "Instructor",
				Description = "A veteran software developer and weekend aviator, Judy McNeil brings her passion for technology and teaching to Xamarin University, illustrated in her upbeat, dynamic class sessions." });

			team.Add(new TeamMember { 
				Name = "Rene Ruppert", 
				Icon = "reneruppert.jpg", 
				Title = "Instructor",
				Description = "A long-term .NET developer with a passion for mobile apps, specifically with iOS, René Ruppert started programming games in Turbo Pascal back in the 1990s. Later, he studied and achieved his MSc in Computer Science. Over the years, he learns that C# is the language he loves. Combined with his passion for smartphones, the logical consequence was to use Xamarin. Today, he helps others successfully create true cross-platform apps." });

			team.Add(new TeamMember { 
				Name = "Mark Smith", 
				Icon = "marksmith.jpg",
				Title = "Director of Training and Curriculum",
				Description = "Mark has been developing software for over 30 years and has spent the last 10 focused on creating and presenting training curriculum for Windows, .NET, iOS, and most recently, Xamarin. At Xamarin University, Mark leads the training and curriculum teams, helping to craft the overall experience of Xamarin University." });

			team.Add(new TeamMember { 
				Name = "Mark Taparaskus", 
				Icon = "marktaparauskas.jpg", 
				Title = "Curriculum Creator",
				Description = "Mark has been authoring courseware, presenting training, and writing code since 1991. He is a reformed language-lawyer who is happier building apps than debating when the C# spec changed to allow bool in a switch statement. At Xamarin University, he writes curriculum for both the live and the self-guided courses." });

			team.Add(new TeamMember { 
				Name = "Adam Patridge", 
				Icon = "adampatridge.jpg",
				Title = "Curriculum Creator",
				Description = "Adam began developing software in 2000, with a current focus on Xamarin technologies growing from experiments writing programs for Windows Mobile 2003 devices. Prior to Xamarin, Adam was a developer for Seirra Trading Post, working on their online e-commerce platform and developing their initial mobile e-commerce web site and apps created using Xamarin.iOS and Xamarin.Android. Adam has also worked on a growing video-based social media app developed entirely with Xamarin.Forms. Recreationally, Adam works on a number of small open-source development utility and productivity projects and has published a silly distraction game for toddlers called Smudges." });

			team.Add(new TeamMember { 
				Name = "Helen Miller", 
				Icon = "helenmiller.jpg", 
				Title = "Instructional Designer",
				Description = "Helen has worked in the field of higher education, faculty development, and distance learning for the past 11 years. Her efforts include adding interactivity into the distance classroom and creating active learning environments. At Xamarin University, she authors courses for instructor-led and self-guided learning, and geeks out on different ways to make technical content fun and engaging." });

			team.Add(new TeamMember { 
				Name = "Brian Kim", 
				Icon = "briankim.png", 
				Title = "Sr. Software Engineer",
				Description = "Brian is a seasoned technical veteran who has spent over 15 years architecting, leading, and developing solutions across various technology platforms for data, server, web, and mobile. More recently, Brian has been focusing on DevOps, building high availability systems, and growing teams. Outside of work, you’ll find Brian hacking up the golf course, bluffing at the poker table, or sculpting Play-Doh with his son." });

			team.Add(new TeamMember { 
				Name = "Adam Dunn", 
				Icon = "adamdunn.jpg", 
				Title = "Sr. Software Engineer",
				Description = "Adam Dunn has over 15 years of software development and architecture experience. Passionate about empowering children, Adam won an award for a game concept aimed at teaching children to code. He has also built and led teams that shipped several popular casual games on both mobile and web. He treasures being a father of three." });
			
			team.Add(new TeamMember { 
				Name = "Diane Lee", 
				Icon = "dianelee.png", 
				Title = "Training Coordinator",
				Description = "Diane went to UC Davis and studied Economics and International Relations. She’s a Bay Area local and has always been surrounded by the tech industry, and is consequently interested about innovation in the tech space. She works primarily with the Xamarin University team to ensure that both the trainers and students have the tools and resources to be successful. Outside of work, you’ll definitely find her outside camping, climbing, hiking, or hanging out with dogs." });
			
			team.Add(new TeamMember { 
				Name = "Karina Ung", 
				Icon = "karinaung.png", 
				Title = "Training Program Manager",
				Description = "As a Training Program Manager, Karina works with a variety of groups at Xamarin, but directly supports the training team to ensure students have the right resources to becoming successful Xamarin mobile developers." });

			team.Add(new TeamMember { 
				Name = "Samir Adadow", 
				Icon = "samiradadow.jpeg", 
				Title = "Training Coordinator",
				Description = "Samir is involved with many of the day to day business operations surrounding Xamarin University, supporting trainers and students to create the best possible learning environment for Xamarin developers." });

			return team.OrderBy(x => x.Name).ToList();

		}
	}

	public class TeamViewModel
	{
		public ObservableCollection<TeamMember> TeamMembers { get; set; } = new ObservableCollection<TeamMember>();
		private List<TeamMember> _team = new List<TeamMember>();
		public TeamViewModel()
		{
			var repository = new TeamRepository();
			_team = repository.LoadTeam();

			TeamMembers = new ObservableCollection<TeamMember>(_team);
		}

		public void Add(TeamMember teamMember)
		{
			if (!_team.Any(t => t.Name == teamMember.Name))
			{
				_team.Add(teamMember);
			}
			TeamMembers.Insert(0, teamMember);
		}

		public void Delete(TeamMember teamMember)
		{
			var index = TeamMembers.ToList().FindIndex(x => x.Name == teamMember.Name);
			TeamMembers.RemoveAt(index);

		}
	}

}
