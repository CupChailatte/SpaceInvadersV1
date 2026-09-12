using System;
using System.Collections.Generic;
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
    private BulletManager _bulletManager;

    // ---Variabler för liv och text --- 

    public Player(Texture2D playerSprite, Texture2D bulletTexture, Vector2 playerPosition)
    {
        _playerSprite = playerSprite;
        PlayerPosition = playerPosition;
        _bulletManager = new BulletManager(bulletTexture);

        //--- Init liv och text ---

    }

    //Player input 
    public void Update(GameTime gameTime, int screenWidth, InputManager input)
    {
        float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

        if (input.IsKeyDown(Keys.Left) || input.IsKeyDown(Keys.A))
        {
            PlayerPosition.X -= Speed * deltaTime;
        }
        if (input.IsKeyDown(Keys.Right) || input.IsKeyDown(Keys.D))
        {
            PlayerPosition.X += Speed * deltaTime;
        }
        //* Skjuta /
        // TODO: Mouse input 
        if (input.IsKeyDown(Keys.Space))
        {
            //laser goes here!
            Vector2 bulletOrigin = new Vector2(PlayerPosition.X + (_playerSprite.Width / 2), PlayerPosition.Y);

            _bulletManager.ShootBullet(bulletOrigin, 2000f, new Vector2(0, -1), 10); // Skott inställning - hastighet, skada eller position

        }
        _bulletManager.Update(deltaTime);


        //Håller spelaren infanför spelfönstret. 
        PlayerPosition.X = MathHelper.Clamp(PlayerPosition.X, 0, screenWidth - _playerSprite.Width);
    }

    // Metod som renderar player sprite och dens positions värdet till fönstret
    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(_playerSprite, PlayerPosition, Color.White);
        _bulletManager.Draw(spriteBatch);

        ///--- Ritar ut texten - färg, typsnit, sträng och position
    }

}