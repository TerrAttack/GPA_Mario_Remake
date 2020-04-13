using GPA_Mario_Remake.Source.Objects.Sprite;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GPA_Mario_Remake.Source.Objects
{
	class Camera
	{
		public Matrix Transform { get; private set; }
		Viewport viewport;
		Vector2 center;

		public void follow(SpriteGameObject _object)
		{
			var position = Matrix.CreateTranslation(-_object.Position.X - (_object.Width / 2), -(GameEnvironment.Screen.Y/2), 0); 
			var offset =  Matrix.CreateTranslation(GameEnvironment.Screen.X / 2, GameEnvironment.Screen.Y / 2, 0);

			Transform = position * offset;
		}
	}
}
