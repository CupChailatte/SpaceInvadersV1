using CoreClassLibrary.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CoreClassLibrary.Entities;


public class Bullet
{
    public float Velocity { get; set; } = 500f;
    public int Damage { get; set; } = 10;
    private Texture2D _bulletTexture;
    public Vector2 Position;


    public Bullet(Texture2D texture, Vector2 startPosition, float speed, int dmg)
    {
        _bulletTexture = texture;
        Position = startPosition;
        Velocity = speed;
        Damage = dmg;
    }

    public void Shoot(Texture2D texture, Vector2 playerPosition)
    {

    }

    public void Update()
    {
        Position.Y = Position.Y + 1;
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(_bulletTexture, Position, Color.Red);

    }
}