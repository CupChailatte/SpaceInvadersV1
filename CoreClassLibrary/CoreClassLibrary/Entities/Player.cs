using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using CoreClassLibrary.Managers;


namespace CoreClassLibrary.Entities;

public class Player
{
    private readonly Texture2D _playerSprite;
    public Vector2 PlayerPosition;
    public float Speed { get; set; } = 1000f;

    public Player(Texture2D playerSprite, Vector2 playerPosition)
    {
        _playerSprite = playerSprite;
        PlayerPosition = playerPosition;
    }

    //Player input 
    public void Update(GameTime gameTime, int screenWidth)
    {
        float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

        if (InputManager.IsKeyDown(Keys.Left) || InputManager.IsKeyDown(Keys.A))
        {
            Console.WriteLine("Left key pressed");

            PlayerPosition.X -= Speed * deltaTime;
        }
        if (InputManager.IsKeyDown(Keys.Right) || InputManager.IsKeyDown(Keys.D))
        {
            PlayerPosition.X += Speed * deltaTime;
        }
        //Håller spelaren infanför spelfönstret. 
        PlayerPosition.X = MathHelper.Clamp(PlayerPosition.X, 0, screenWidth - _playerSprite.Width);
    }

    // Metod som renderar player sprite och dens positions värdet till fönstret
    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(_playerSprite, PlayerPosition, Color.White);
    }

}