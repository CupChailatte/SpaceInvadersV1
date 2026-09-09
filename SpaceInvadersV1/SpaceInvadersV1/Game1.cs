using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using CoreClassLibrary.Entities;
using System.Collections.Generic;
using CoreClassLibrary.Systems;


namespace SpaceInvadersV1;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    Texture2D _player;
    Vector2 pos1;
    private EnemyManager _enemyManager = new EnemyManager(); public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
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

        _player = Content.Load<Texture2D>("Ship_01-1");
        Texture2D enemyTexture = Content.Load<Texture2D>("alien02_sprite02");

        _enemyManager.SpawnEnemyFleet(enemyTexture, new Vector2(50, 50));



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
        _spriteBatch.Draw(_player, Vector2.Zero, Color.Wheat); // ritar ut spriten på skärmen
        _enemyManager.Draw(_spriteBatch);
        _spriteBatch.End();//avslutar sprite batch när spelet är avslutad. 
        // TODO: Add your drawing code here
        base.Draw(gameTime);
    }
}
