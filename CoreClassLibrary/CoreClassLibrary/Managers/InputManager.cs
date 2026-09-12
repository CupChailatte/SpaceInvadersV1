using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace CoreClassLibrary.Managers;

public class InputManager
{
    //Tangentbordtillstånd
    private KeyboardState _currentKeyboardState;
    private KeyboardState _previousKeyboardState;

    public InputManager()
    {
        _currentKeyboardState = Keyboard.GetState();
        _previousKeyboardState = _currentKeyboardState;
    }
    public void Update()
    {
        _previousKeyboardState = _currentKeyboardState;
        _currentKeyboardState = Keyboard.GetState();
    }

    // ---TANGENTORD---

    public bool IsKeyDown(Keys key)
    {
        return _currentKeyboardState.IsKeyDown(key);
    }

    public bool IsKeyRelased(Keys key)
    {
        return _currentKeyboardState.IsKeyUp(key);
    }



}