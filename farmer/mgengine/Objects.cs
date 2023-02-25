using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace mgengine
{
    public class Obj
    {
        private Texture2D _img;
        public Vector2 Pos;

        public Obj(float x, float y){
            
            this.Pos = new Vector2(x, y);
        }

        public void Load(Texture2D texture){
            this._img = texture;
        }

        public void Draw(SpriteBatch spriteBatch){
            spriteBatch.Draw(this._img, this.Pos, Color.White);
        }
    }
}