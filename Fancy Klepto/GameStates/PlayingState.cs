﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy_Klepto
{
    class PlayingState : GameState
    {
        public PlayingState()
        {
            gameObjectList.Add(new GameObject("spr_background"));
            gameObjectList.Add(new Player());
            //StartPositie, SpriteName,LengteEnBreedte,Angle
            gameObjectList.Add(new Laser(new Vector2(100, 100), "spr_laser_pixel_green",    new Vector2(100, 5), (float)Math.PI / 2));
            gameObjectList.Add(new Laser(new Vector2(100, 100), "spr_laser_pixel_yellow",   new Vector2(100, 5), (float)Math.PI));
            gameObjectList.Add(new Laser(new Vector2(100, 100), "spr_laser_pixel",          new Vector2(100, 5), (float)Math.PI*1.5f));
            gameObjectList.Add(new Laser(new Vector2(100, 100), "spr_laser_pixel_purple",   new Vector2(100, 5), (float)Math.PI*2f));
            gameObjectList.Add(new Laser(new Vector2(100, 100), "spr_laser_pixel_yellow",   new Vector2(100, 5), (float)Math.PI/4f));
        }
    }
}
