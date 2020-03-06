using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Fancy_Klepto
{
    class Player : GameObject
    {
        const int PLAYERSPD = 40;
        public Player() : base("spr_circle")
        {
        }

        public override void Reset()
        {
            base.Reset();
        }

        public override void Update()
        {
            base.Update();
            velocity.X = 0;
            velocity.Y = 0;
            if (Fancy_Klepto.previousState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.W) &&
                Fancy_Klepto.KeyboardState.IsKeyUp(Microsoft.Xna.Framework.Input.Keys.W))
            {
                velocity.Y = -PLAYERSPD;
            }
            if (Fancy_Klepto.previousState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.A) &&
                Fancy_Klepto.KeyboardState.IsKeyUp(Microsoft.Xna.Framework.Input.Keys.A))
            {
                velocity.X = -PLAYERSPD;
            }
            if (Fancy_Klepto.previousState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.S) &&
                Fancy_Klepto.KeyboardState.IsKeyUp(Microsoft.Xna.Framework.Input.Keys.S))
            {
                velocity.Y = PLAYERSPD;
            }
            if (Fancy_Klepto.previousState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.D) &&
                Fancy_Klepto.KeyboardState.IsKeyUp(Microsoft.Xna.Framework.Input.Keys.D))
            {
                velocity.X = PLAYERSPD;
            }

            position.X = MathHelper.Clamp(position.X, 0, GameEnvironment.Screen.X - texture.Width);
            position.Y = MathHelper.Clamp(position.Y, 0, GameEnvironment.Screen.Y - texture.Height);
        }
    }
}