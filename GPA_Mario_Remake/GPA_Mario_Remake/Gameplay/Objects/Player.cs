using Microsoft.Xna.Framework;
using GPA_Mario_Remake.Source.Objects.Sprite.Animation;
using GPA_Mario_Remake.Source.Helpers;
using Microsoft.Xna.Framework.Input;

namespace GPA_Mario_Remake.Gameplay.Objects
{
	class Player : AnimatedGameObject
	{
		int playerSpeed = 256;
		bool airborne;

		public Player()
		{
			velocity = new Vector2(0, 0);
			position = new Vector2(400,200);
			LoadAnimation("MarioWalk", "Walk", true, 0.1f, 1, 3);
			LoadAnimation("MarioIdle", "Idle", true, 0.1f, 1, 1);
			PlayAnimation("Idle");
		}

		public override void HandleInput(InputHelper inputHelper)
		{
			bool left = false, right = false;
			if (inputHelper.IsKeyDown(Keys.A))
			{
				velocity.X = -playerSpeed;
				PlayAnimation("Walk");
				Mirror = true;
				left = true;
			}
			if (inputHelper.IsKeyDown(Keys.D))
			{
				velocity.X = playerSpeed;
				PlayAnimation("Walk");
				Mirror = false;
				right = true;
			}
			if((!right && !left) || (right && left))
			{
				velocity.X = 0;
				PlayAnimation("Idle");
			}

			base.HandleInput(inputHelper);
		}

		public override void Update(GameTime gameTime)
		{

			base.Update(gameTime);
		}
	}
}
