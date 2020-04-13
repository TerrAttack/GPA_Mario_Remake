﻿using System.Collections.Generic;
using GPA_Mario_Remake.Source.Helpers;
using GPA_Mario_Remake.Source.Objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GPA_Mario_Remake.Source.Managers
{
	class GameStateManager
	{
        Dictionary<string, IGameLoopObject> gameStates;
        IGameLoopObject currentGameState;

        public GameStateManager()
        {
            gameStates = new Dictionary<string, IGameLoopObject>();
            currentGameState = null;
        }

        public void AddGameState(string name, IGameLoopObject state)
        {
            gameStates[name] = state;
        }

        public IGameLoopObject GetGameState(string name)
        {
            return gameStates[name];
        }

        public void SwitchTo(string name)
        {
            if (gameStates.ContainsKey(name))
            {
                currentGameState = gameStates[name];
            }
            else
            {
                throw new KeyNotFoundException("Could not find game state: " + name);
            }
        }

        public IGameLoopObject CurrentGameState
        {
            get
            {
                return currentGameState;
            }
        }

        public void HandleInput(InputHelper inputHelper)
        {
            if (currentGameState != null)
            {
                currentGameState.HandleInput(inputHelper);
            }
        }

        public void Update(GameTime gameTime)
        {
            if (currentGameState != null)
            {
                currentGameState.Update(gameTime);
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            if (currentGameState != null)
            {
                currentGameState.Draw(gameTime, spriteBatch);
            }
        }

        public void Reset()
        {
            if (currentGameState != null)
            {
                currentGameState.Reset();
            }
        }
    }
}
