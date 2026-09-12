using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using CoreClassLibrary.Entities;
using System.Collections.Generic;
namespace CoreClassLibrary.Managers;


public class BulletManager
{
    private List<Bullet> _activeBulletsList;
    private Texture2D _bulletTexture;

    public BulletManager(Texture2D texture)
    {
        _activeBulletsList = new List<Bullet>();
        _bulletTexture = texture;
    }
    public void ShootBullet(Vector2 startPosition, float speed, Vector2 direction, float damage)
    {
        Bullet newBullet = new Bullet(_bulletTexture, startPosition, speed, direction, damage);
        _activeBulletsList.Add(newBullet);
    }

    public void Update(float deltaTime)
    {
        for (int i = _activeBulletsList.Count - 1; i >= 0; i--)
        {
            _activeBulletsList[i].Update(deltaTime); // Backward loop Algorithm 
            //om skotten är offscreen, ta bort objekten - garbage collector rensar den 
            if (_activeBulletsList[i].IsOffScreen)
            {
                _activeBulletsList.RemoveAt(i);
            }
        }
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        foreach (var bullets in _activeBulletsList)
        {
            bullets.Draw(spriteBatch);
        }
    }
}