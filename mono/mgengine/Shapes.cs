using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace mgengine
{
    public class Rectangle2{

        public Vector2 pos {get;set;}
        public float width {get;set;}
        public float height {get;set;}
        public Color color {get;set;}
        public Texture2D texture {get;set;}
        
        public Rectangle2(float x, float y, float width, float height, Color color){

            this.pos = new Vector2(x, y);
            this.width = width;
            this.height = height;
            this.color = color;
        }

        public void Load(GraphicsDevice graph){
            this.texture = new Texture2D(graph, 1, 1);
            this.texture.SetData(new[] {this.color});
        }

        public void Draw(SpriteBatch spriteBatch){
            spriteBatch.Draw(this.texture, new Rectangle((int)this.pos.X, (int)this.pos.Y, (int)this.width, (int)this.height), this.color);
        }
    }

}

