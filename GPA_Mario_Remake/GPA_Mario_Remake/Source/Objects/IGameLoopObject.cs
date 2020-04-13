using GPA_Mario_Remake.Source.Helpers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GPA_Mario_Remake.Source.Objects
{
	interface IGameLoopObject
	{
		void HandleInput(InputHelper inputHelper);

		void Update(GameTime gameTime);

		void Draw(GameTime gameTime, SpriteBatch spriteBatch);

		void Reset();
	}
}
