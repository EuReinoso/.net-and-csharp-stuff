using mgengine;
using Microsoft.Xna.Framework;

namespace mono
{
    public class Ball : Rectangle2{   
        private float xVel = 3;
        private float yVel = 3;
        private float aceleration = 1f;

        public Ball(float x, float y, float width, float height, Color color) : base(x, y, width, height, color)
        {
            
        }

        public void update(float dt){
            this.move(dt);
        }

        private void move(float dt){
            this.pos = new Vector2(this.pos.X + this.xVel, this.pos.Y + this.yVel);
        }

        public void acelerate(){
            this.xVel += this.aceleration;
            this.yVel += this.aceleration/2;
        }

        public void turnX(){
            this.xVel *= -1;
        }

        public void turnY(){
            this.yVel *= -1;
        }

    }
}