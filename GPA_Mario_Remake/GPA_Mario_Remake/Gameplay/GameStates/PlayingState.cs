using GPA_Mario_Remake.Gameplay.Objects;
using GPA_Mario_Remake.Gameplay.Objects.Tiles;
using GPA_Mario_Remake.Source.Helpers;
using GPA_Mario_Remake.Source.Objects.Basic;
using Microsoft.Xna.Framework;


namespace GPA_Mario_Remake.Gameplay.GameStates
{
	class PlayingState : GameObjectList
	{
		LevelLoaderHelper mapMaker = new LevelLoaderHelper();
		GameObjectList tiles = new GameObjectList();

		Player mario;

		public PlayingState()
		{
			mario = new Player();
			Add(mario);

			tiles = mapMaker.LoadLevel("LevelTest");
			Add(tiles);
		}
	}
}
