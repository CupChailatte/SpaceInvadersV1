using System;
using System.Formats.Tar;
using System.IO.Compression;
using System.Collections.Generic; 
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace CoreClassLibrary.Entities;


public class Enemy
{
    public Vector2 Position {get; set;}
    public int Health{get; set;} = 400; 
    private Texture2D _enemyTexture;
    private readonly float _speed = 0.1f;//Fiende Hastighet 
    

    public Enemy(Texture2D texture, Vector2 position)
    {
        _enemyTexture = texture; 
        Position = position; 
    }


   
   public void Update(GameTime gameTime)
    { //enemy går neråt 
        Position = new Vector2(Position.X, Position.Y + _speed); 
    }
    
    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(_enemyTexture, Position, Color.White); 
    }
}

