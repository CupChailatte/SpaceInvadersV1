using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace CoreClassLibrary.Entities;

public class Player
{
    private Texture2D _playerSprite;
    public Vector2 PlayerPostion { get; set; }
    public float Speed { get; set; }

    public Player(Texture2D playerSprite, Vector2 playerPosition)
    {
        _playerSprite = playerSprite;
        PlayerPostion = playerPosition;
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(_playerSprite, PlayerPostion, Color.Green);
    }

}