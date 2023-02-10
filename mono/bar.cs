using mgengine;
using Microsoft.Xna.Framework;

namespace mono
{
    public class Bar : Rectangle2
    {
        public float vel = 0;
        private float aceleration = 0.6f;
        private float velLimit = 5;
        public bool isUp {get;set;}
        public bool isDown {get;set;}
        public int points = 0; 

        public Bar(float x, float y, float width, float height, Color color) : base(x, y, width, height, color)
        {

        }

        public void update(float dt){
            this.move(dt);
            this.acelerate();
        }

        private void move(float dt){
            this.pos = new Vector2(this.pos.X, this.pos.Y + (this.vel));
        }

        private void acelerate(){
            if (this.isDown && this.vel <= this.velLimit){
                this.vel += this.aceleration;
            }
            if (this.isUp && this.vel >= -this.velLimit){
                this.vel -= this.aceleration;
            }
            // // else{
            // //     if (this.vel > 0){
            // //         this.vel -= this.aceleration;
            // //     }
            // //     else if (this.vel < 0){
            // //         this.vel += this.aceleration;
            // //     }
            // }
        }
    }
}