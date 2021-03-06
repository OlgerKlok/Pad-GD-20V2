﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace Fancy_Klepto
{
    class Fancy_Klepto : GameEnvironment
    {
        int state = 0;

        public static KeyboardState previousState;
        protected override void LoadContent()
        {
            base.LoadContent();
            gameStateList.Add(new StartState());
            gameStateList.Add(new PlayingState());
            gameStateList.Add(new EndStateWon());
            gameStateList.Add(new EndStateLost());

            screen = new Point(1920, 1080);

            GameEnvironment.SwitchTo(state);
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            previousState = KeyboardState;
            if (GameEnvironment.KeyboardState.IsKeyDown(Keys.Enter))
            {
                state++;
                GameEnvironment.SwitchTo(state);
                state = 0;
            }
        }

    }
}