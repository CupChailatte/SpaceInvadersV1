using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace CoreClassLibrary.Entities;

public class Enemy
{
    public const int DefaultArmyCount = 1;
    public const int DefaultSpacing = 50;
    public const int StartPosX = 50;
    public const int StartPosY = 50;

    public Vector2 Position { get; set; }
    private Texture2D _enemyTexture;

    public Enemy(Texture2D texture, Vector2 startPosition)
    {
        _enemyTexture = texture;
        Position = startPosition;
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(_enemyTexture, Position, Color.Red);
    }

}