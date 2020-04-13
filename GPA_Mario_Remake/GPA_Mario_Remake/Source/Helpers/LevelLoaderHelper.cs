using GPA_Mario_Remake.Gameplay.Objects.Tiles;
using GPA_Mario_Remake.Source.Objects.Basic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GPA_Mario_Remake.Source.Helpers
{
	class LevelLoaderHelper
	{
		public GameObjectList LoadLevel(string _assetName)
		{
			Texture2D level;
			Color[,] colorGrid;
			GameObjectList tiles = new GameObjectList();

			level = GameEnvironment.AssetManager.GetSprite(_assetName);
			colorGrid = GetColorGrid(level);

			for(int x = 0; x < level.Width; x++)
			{
				for(int y = 0; y < level.Height; y++)
				{
					chooseTile(tiles, colorGrid[x, y], new Vector2(x,y));
				}
			}
			return tiles;
		}
		
		private Color[,] GetColorGrid(Texture2D level)
		{
			Color[] colors1D = new Color[level.Width * level.Height];
			level.GetData<Color>(colors1D);
			Color[,] colors2D = new Color[level.Width, level.Height];
			for (int x = 0; x < level.Width; x++)
			{
				for (int y = 0; y < level.Height; y++)
				{
					colors2D[x, y] = colors1D[x + y * level.Width];
				}
			}
			return colors2D;
		}

		private void chooseTile(GameObjectList _tiles, Color _color, Vector2 _index)
		{
			if (_color == Color.Orange)
				_tiles.Add(new BasicTile(new Vector2(_index.X * 64, _index.Y * 64)));
		}
	}
}
