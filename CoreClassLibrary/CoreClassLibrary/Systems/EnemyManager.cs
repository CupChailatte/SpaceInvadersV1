using System.Collections.Generic;
using CoreClassLibrary.Entities;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace CoreClassLibrary.Systems;

/*
public class EnemyManager
{
    private readonly List<Enemy> _enemies = new List<Enemy>();
    private const int Rows = 2;
    private const int Columns = 8;
    private const int SpacingX = 80;
    private const int SpacingY = 70;


    public void SpawnEnemyFleet(Texture2D enemyTexture, Vector2 startPosition, int stopX, int stopY)
    {
        _enemies.Clear();

        for (int row = 0; row < Rows; row++)
        {
            for (int col = 0; col < Columns; col++)
            {
                Vector2 pos = new Vector2(
                    startPosition.X + (col * SpacingX),
                    startPosition.Y + (row * SpacingY)
                );
                _enemies.Add(new Enemy(enemyTexture, pos));
            }
        }
    }
    public void Draw(SpriteBatch spriteBatch)
    {
        foreach (var enemy in _enemies)
        {
            enemy.Draw(spriteBatch);
        }
    }
}
*/