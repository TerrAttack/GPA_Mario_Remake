using GPA_Mario_Remake.Source;
using Microsoft.Xna.Framework;
using GPA_Mario_Remake.Gameplay.GameStates;


namespace GPA_Mario_Remake
{
	class GPA_Mario : GameEnvironment
	{
		protected override void LoadContent()
		{
			base.LoadContent();
			screen = new Point(800, 600);
			ApplyResolutionSettings();

			gameStateManager.AddGameState("Playing State", new PlayingState());

			gameStateManager.SwitchTo("Playing State");
		}
	}
}
