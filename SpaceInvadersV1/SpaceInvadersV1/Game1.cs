using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using CoreClassLibrary.Entities;
using System.Collections.Generic;
using CoreClassLibrary.Systems;
using CoreClassLibrary.Managers;


namespace SpaceInvadersV1;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private DisplayManager _displayManager;
    private SpriteBatch _spriteBatch;
    private Player _player;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
        //Inställning för fönsterstorlek 
        _displayManager = new DisplayManager(_graphics, 2560, 1440, true);

    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        // TODO: use this.Content to load your game content here

        //laddar upp player sprite och dens start position. 
        Texture2D _playerSprite = Content.Load<Texture2D>("Ship_01-1");

        float startX = (_displayManager.Width / 2f - _playerSprite.Width / 2f);
        float startY = _displayManager.Height - _playerSprite.Height;

        //start position för spelare 
        Vector2 startPosition = new Vector2(startX);
        _player = new Player(_playerSprite, startPosition);


    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Black);

        _spriteBatch.Begin(); //preparerar rendering. 
        //Renderar player till fönstret
        _player.Draw(_spriteBatch);

        _spriteBatch.End();//avslutar sprite batch när spelet är avslutad. 
        // TODO: Add your drawing code here
        base.Draw(gameTime);
    }
}
