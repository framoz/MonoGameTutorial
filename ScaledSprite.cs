﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MonoGameTutorial
{
    internal class ScaledSprite : Sprite
    {

        public Rectangle Rect
        {
            get
            {
                return new Rectangle((int)position.X, (int)position.Y, 100, 100);
            }
        }
        public ScaledSprite(Texture2D texture, Vector2 position) : base(texture, position)
        {         

        }
    }
}
