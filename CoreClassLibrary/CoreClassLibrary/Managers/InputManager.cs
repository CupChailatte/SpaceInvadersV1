using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
namespace CoreClassLibrary.Managers;

public static class InputManager
{
    //Tangentbordtillstånd
    private static KeyboardState _currentKeyboardState;
    private static KeyboardState _previousKeyboardState;

    //Mustillstånd
    private static MouseState _currentMouseState;
    private static MouseState _previousMouseState;

    //Egenskap för att hitta muspostionen, space invaders behöver bara x-axlen. 
    public static Vector2 MousePosition => new Vector2(_currentMouseState.X, _currentMouseState.Y);

    /// Anropas en gång i början av varje bildruta i Game1.Update()
    public static void Update()
    {
        _previousKeyboardState = _currentKeyboardState;
        _currentKeyboardState = Keyboard.GetState();

        _previousMouseState = _currentMouseState;
        _currentMouseState = Mouse.GetState();
    }

    // ---TANGENTORD---

    public static bool IsKeyDown(Keys key)
    {
        return _currentKeyboardState.IsKeyDown(key);
    }

    public static bool IsKeyRelased(Keys key)
    {
        return _currentKeyboardState.IsKeyUp(key);
    }


}