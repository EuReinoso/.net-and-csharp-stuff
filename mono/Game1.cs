using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using mgengine;

namespace mono;

public class Game1 : Game
{    
    int windowHeight;
    int windowWidth;
    private Bar bar1;
    private Bar bar2;
    private Ball ball;
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here
        windowHeight =  _graphics.PreferredBackBufferHeight;
        windowWidth = _graphics.PreferredBackBufferWidth;

        bar1 = new Bar(0, windowHeight/2 - 50, 15, 100, Color.White);
        bar2 = new Bar(windowWidth - 15, windowHeight/2 - 50, 15, 100, Color.White);
        ball = new Ball(windowWidth/2 - 7.5f, windowHeight/2 - 7.5f, 15, 15, Color.White); 

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here

        bar1.Load(GraphicsDevice);
        bar2.Load(GraphicsDevice);
        ball.Load(GraphicsDevice);
    }

    protected override void Update(GameTime gameTime)
    {
        float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        KeyboardState state = Keyboard.GetState();

        //KEYS
        if(state.IsKeyDown(Keys.Down)){
            bar2.isDown = true;
        }
        else if(state.IsKeyUp(Keys.Down)){
            bar2.isDown = false;
        }
        
        if(state.IsKeyDown(Keys.Up)){
            bar2.isUp = true;
        }
        else if(state.IsKeyUp(Keys.Up)){
            bar2.isUp = false;
        }

        if(state.IsKeyDown(Keys.S)){
            bar1.isDown = true;
        }
        else if(state.IsKeyUp(Keys.S)){
            bar1.isDown = false;
        }
        
        if(state.IsKeyDown(Keys.W)){
            bar1.isUp = true;
        }
        else if(state.IsKeyUp(Keys.W)){
            bar1.isUp = false;
        }
        
        //BAR LOGIC
        if(bar1.pos.Y >= windowHeight - bar1.height){
            bar1.pos = new Vector2(bar1.pos.X, windowHeight - bar1.height);
        }
        else if(bar1.pos.Y <= 0){
            bar1.pos = new Vector2(bar1.pos.X, 0);
        }

        if(bar2.pos.Y >= windowHeight - bar2.height){
            bar2.pos = new Vector2(bar2.pos.X, windowHeight - bar2.height);
        }
        else if(bar2.pos.Y <= 0){
            bar2.pos = new Vector2(bar2.pos.X, 0);
        }

        //BALL LOGIC
        if (ball.pos.Y >= windowHeight - ball.height || ball.pos.Y <= 0){
            ball.turnY();
        }
        //points
        if (ball.pos.X >= windowWidth - ball.width){
            bar1.points += 1;
            ball.pos = new Vector2(windowWidth/2 - 7.5f, windowHeight/2 - 7.5f);
        }
        if (ball.pos.X <= 0){
            bar2.points += 1;
            ball.pos = new Vector2(windowWidth/2 - 7.5f, windowHeight/2 - 7.5f);
        }
        // ball-bar collission
        if (ball.CollideRect(bar1) || ball.CollideRect(bar2)){
            ball.turnX();
            ball.acelerate();
        } 
        
        bar1.update(dt);
        bar2.update(dt);
        ball.update(dt);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Black);

        // TODO: Add your drawing code here
        _spriteBatch.Begin();

        bar1.Draw(_spriteBatch);
        bar2.Draw(_spriteBatch);
        ball.Draw(_spriteBatch);

        _spriteBatch.End();


        base.Draw(gameTime);
    }
}
