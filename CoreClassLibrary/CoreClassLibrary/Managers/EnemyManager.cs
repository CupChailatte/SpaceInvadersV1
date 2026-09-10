using System.Collections.Generic; 
using Microsoft.Xna.Framework.Graphics; 
using Microsoft.Xna.Framework; 
using CoreClassLibrary.Entities; 


namespace CoreClassLibrary.Entities; 

public class EnemyManager
{
    //Data,resurser,properties
    private List<Enemy> _enemies; 
    private Texture2D _enemyTexture;

//Consturctorn 
    public EnemyManager(Texture2D texture)
    {
        _enemyTexture = texture; 
        _enemies = new List<Enemy>(); 

    }

    public void SpawnEnemyGrid(int row, int columns)
    {
        float startX = 60f; 
        float startY = 50f;

        float spacingX = 150f;
        float spacingY = 100f; 
        for (int r = 0; r < row; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                float x = startX + (c * spacingX);
                float y = startY + (r * spacingY); 

                Vector2 spawnPosition = new Vector2(x,y); 

                _enemies.Add( new Enemy(_enemyTexture, spawnPosition)); 
            }
        }
    }



    //Uppdatering 
    public void Update(GameTime gameTime)
    {
        //Skapar nya objekt
        //Uppdaterar befintliga objekt i listan
        //städar bort död objekt. (RemoveAll)

        foreach(var enemy in _enemies)
        {
            enemy.Update(gameTime); 
        }
        
    }
    
    public void Draw(SpriteBatch spriteBatch)
    {
        //Ritar/Renderar ut alla aktiva objekt i listan. 
        foreach(var enemy in _enemies)
        {
            enemy.Draw(spriteBatch);
        }
    }

    //Egna Funktioner t.ex AddItem(); 
} 
