using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    public class Pokedex
    {

		public Pokedex()
		{
			this.InicializaLista();
		}


		private List<Pokemon> pokemons;

		public List<Pokemon> Pokemons
		{
			get { return pokemons; }
			
		}

		private void InicializaLista()
		{
			this.pokemons = new List<Pokemon>();

			Pokemon p = new Pokemon("Bulba","Sua desc");
			this.pokemons.Add(p);

			p = new Pokemon("Dudao", "esse mesmo");
			this.pokemons.Add(p);

            p = new Pokemon("Dudao1", "esse mesmo1");
            this.pokemons.Add(p);

            p = new Pokemon("Dudao2", "esse mesmo2");
            this.pokemons.Add(p);

            p = new Pokemon("Dudao3", "esse mesmo3");
            this.pokemons.Add(p);
        }
	}
}
