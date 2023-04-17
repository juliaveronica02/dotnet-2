namespace WebApplication2.Services.SuperHeroesService
{
	public interface ISuperHeroService
	{
		List<superhero> GetAllHeroes();
		superhero? GetSingleHero(int id);
		List<superhero> AddHeroes(superhero hero);
		List<superhero>? UpdateHeroes(int id, superhero request);
		List<superhero>? DeleteHeroes(int id);
	}
}
