using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace MonoGameTutorial
{
    internal class ColoredSprite : ScaledSprite
    {
        public Color color;
        public ColoredSprite(Texture2D texture, Vector2 position) : base(texture, position)
        {
            color = Color.White;
        }
        public ColoredSprite(Texture2D texture, Vector2 position, Color color) : base(texture, position)
        {
            this.color = color;
        }
    }
}
