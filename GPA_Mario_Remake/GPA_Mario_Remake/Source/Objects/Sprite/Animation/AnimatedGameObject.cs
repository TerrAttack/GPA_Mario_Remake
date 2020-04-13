﻿using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace GPA_Mario_Remake.Source.Objects.Sprite.Animation
{
	class AnimatedGameObject : SpriteGameObject
	{
        protected Dictionary<string, Animation> animations;

        public AnimatedGameObject(int layer = 0, string id = "")
            : base("", layer, id)
        {
            animations = new Dictionary<string, Animation>();
        }

        public void LoadAnimation(string assetName, string id, bool looping,
                                  float frameTime = 0.1f, int rows = 1, int cols = 1)
        {
            Animation anim = new Animation(assetName, looping, frameTime, rows, cols);
            animations[id] = anim;
        }

        public void PlayAnimation(string id)
        {
            if (sprite == animations[id])
            {
                return;
            }
            if (sprite != null)
            {
                animations[id].Mirror = sprite.Mirror;
            }
            animations[id].Play();
            sprite = animations[id];
            origin = new Vector2(sprite.Width / 2, sprite.Height);
        }

        public override void Update(GameTime gameTime)
        {
            if (sprite == null)
            {
                return;
            }
            Current.Update(gameTime);
            base.Update(gameTime);
        }

        public Animation Current
        {
            get { return sprite as Animation; }
        }
    }
}
