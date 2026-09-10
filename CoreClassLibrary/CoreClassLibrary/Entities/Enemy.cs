using System;
using System.Formats.Tar;
using System.IO.Compression;
using System.Collections.Generic; 
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace CoreClassLibrary.Entities;


public class Enemy
{
    private List<Enemy> _enemies = new List<Enemy>(); 
    public int DefaultArmyCount = 10; 
    public int DefaultSpacingX = 50; 
    public int DefaultSpacingY = 50; 
    public int Column = 3;
    public int Row = 3; 
    private Texture2D _enemySprite; 
    public Vector2 EnemyPosition; 
    public int StopX, StopY; 
    

    public Enemy(Texture2D texture, Vector2 startPosition, int stopX, int stopY)
    {
        _enemySprite = texture; 
        EnemyPosition = startPosition;
        StopX = stopX; 
        StopY = stopY;
    }

    /*
    public void SpawnEnemyFleet(Texture2D texture, Vector2 startPosition)
    {
        for(int i = 0; i < Column; i++)
        {
            for (int k = 0; k < Row; i++)
            {
                Vector2 Position = new Vector2(
                    startPosition.X + (Column * DefaultSpacingX),
                    startPosition.Y + (Row * DefaultSpacingY)
                ); 
                _enemies.Add(new Enemy(_enemySprite, EnemyPosition)); 
                
            }
        }
        
        
    }*/

    public void Update()
    {
        if(EnemyPosition.X < StopX && EnemyPosition.Y < StopY)
        {
            EnemyPosition.X = EnemyPosition.X + 1; 
            EnemyPosition.Y = EnemyPosition.Y + 1;
        }
    }
    
    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(_enemySprite, EnemyPosition, Color.Red); 
        /*
        foreach(var enemy in _enemies)
        {
            enemy.Draw(spriteBatch); 
        }*/
    }
}




/*
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


*/ 