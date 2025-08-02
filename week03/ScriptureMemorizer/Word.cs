
using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _isHidden = false;
        _text = text;

    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        //return true; just to compile
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            int numberOfLetters = _text.Length;
            string underscores = new string('_', numberOfLetters); //Don´t use ("") instead of that use this ('')
            return underscores;
        }
        else
        {
            return _text;
        }
    }
}
