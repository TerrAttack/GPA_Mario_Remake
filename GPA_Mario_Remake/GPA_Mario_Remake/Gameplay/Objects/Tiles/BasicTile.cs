using Microsoft.Xna.Framework;
using GPA_Mario_Remake.Source.Objects.Sprite;

namespace GPA_Mario_Remake.Gameplay.Objects.Tiles
{
	class BasicTile : SpriteGameObject
	{
		public BasicTile(Vector2 _position)
			: base("GroundTile")
		{
			position = _position;
		}
	}
}
