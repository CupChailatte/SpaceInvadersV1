using CoreClassLibrary.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CoreClassLibrary.Entities;
//Data Blueprint of Bullet
public class Bullet
{
    //properties
    private Texture2D _bulletTexture;
    private Vector2 _startPosition;
    private float _speed;
    private float _damage;
    private Vector2 _direction;


    public Vector2 startPosition => _startPosition; //public egenskap så att manager och collision algoritm kan se var den är. 
    public bool IsOffScreen => _startPosition.Y < 0; // Egenskap som kollar om bullet är borta från fönstret - garbage collection 

    public Bullet(Texture2D texture, Vector2 startPosition, float speed, Vector2 direction, float damage)
    {
        _bulletTexture = texture;
        _startPosition = startPosition;
        _speed = speed;
        _direction = direction;
        _damage = damage;
    }

    public void Update(float deltaTime)
    {
        // position = position + (direction * speed * time)
        _startPosition += _direction * _speed * deltaTime;
    }
    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(_bulletTexture, _startPosition, Color.Red);
    }
}