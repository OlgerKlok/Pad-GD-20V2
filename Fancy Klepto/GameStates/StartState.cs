using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Fancy_Klepto
{
    class StartState : GameState
    {
        public StartState()
        {
            gameObjectList.Add(new GameObject("spr_text"));
        }
    }
}