using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using mgengine;

namespace mono;

public class Game1 : Game
{    

    private Rectangle2 bar1;
    private Rectangle2 bar2;

    private float barVel;
    
    private Rectangle2 ball;
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

        bar1 = new Rectangle2(0, _graphics.PreferredBackBufferHeight/2 - 50, 15, 100, Color.White);
        bar2 = new Rectangle2(_graphics.PreferredBackBufferWidth - 15, _graphics.PreferredBackBufferHeight/2 - 50, 15, 100, Color.White);
        ball = new Rectangle2(_graphics.PreferredBackBufferWidth/2 - 15, _graphics.PreferredBackBufferHeight/2 - 15, 15, 15, Color.White);
        
        barVel = 2;

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
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        KeyboardState state = Keyboard.GetState();

        if(state.IsKeyDown(Keys.Up)){
            bar2.pos = new Vector2(bar2.pos.X, bar2.pos.Y - barVel);
        }
        if(state.IsKeyDown(Keys.Down)){
            bar2.pos = new Vector2(bar2.pos.X, bar2.pos.Y + barVel);
        }

        // TODO: Add your update logic here

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
