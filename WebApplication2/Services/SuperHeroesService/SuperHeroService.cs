using WebApplication2.Models;

namespace WebApplication2.Services.SuperHeroesService
{
	public class SuperHeroService : ISuperHeroService
	{
		// below is heroes data.
		private static List<superhero> superheroes = new List<superhero>
		{
				new superhero {Id = 1, name ="Iron man", firstname = "iron", lastname="man", place="avengers"},
				new superhero {Id = 2, name ="Doctor Strange", firstname = "doctor", lastname="strange", place="avengers"},
		};
		public List<superhero> AddHeroes(superhero hero)
		{
			superheroes.Add(hero);
			return superheroes;
		}

		public List<superhero>? DeleteHeroes(int id)
		{

			// superheroes are the name from heroes table -> simply database name.
			var hero = superheroes.Find(x => x.Id == id);

			// in swagger json data or form, remember delete the id. because we already put id on swagger just need fill below data.
			superheroes.Remove(hero);
			if (hero is null)
			{
				// if hero not found will show below message.
				return null;
			}
			else
			{
				return superheroes;
			}
		}

		public List<superhero> GetAllHeroes()
		{
			return superheroes;
		}

		public superhero? GetSingleHero(int id)
		{
			// superheroes are the name from heroes table -> simply database name.
			var hero = superheroes.Find(x => x.Id == id);
			if (hero is null)
			{
				// if hero not found will show below message.
				return null;
			}
			else
			{
				return hero;
			}
		}

		public List<superhero>? UpdateHeroes(int id, superhero request)
		{
			// throw new NotImplementedException();

			// superheroes are the name from heroes table -> simply database name.
			var hero = superheroes.Find(x => x.Id == id);

			// in swagger json data or form, remember delete the id. because we already put id on swagger just need fill below data.
			hero.name = request.name;
			hero.firstname = request.firstname;
			hero.lastname = request.lastname;
			hero.place = request.place;
			if (hero is null)
			{
				// if hero not found will show below message.
				return null;
			}
			else
			{
				return superheroes;
			}
		}
	}
}
