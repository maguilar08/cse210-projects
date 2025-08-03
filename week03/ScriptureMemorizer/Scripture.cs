
using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private Random _random = new Random();
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(" ");
        foreach (string word in splitWords)
        {
            Word oneWord = new Word(word);
            _words.Add(oneWord);
        }
    }

    public void HideRandomWords(int numberToHidde)
    {
        int hidded = 0;

        while (hidded < numberToHidde)
        {
            List<Word> visibleWords = new List<Word>();
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    visibleWords.Add(word);
                }
            }
            if (visibleWords.Count == 0)
            {
                break;
            }
            int randomNumberWord = _random.Next(visibleWords.Count);
            Word wordToHide = visibleWords[randomNumberWord];
            wordToHide.Hide();
            hidded++;
        }
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();

        foreach (Word word in _words)
        {
            string displayText = word.GetDisplayText();
            displayWords.Add(displayText);
        }
        string fullText = string.Join(" ", displayWords);
        string referenceText = _reference.GetDisplayText();
        string finalText = referenceText + " " + fullText;

        return finalText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}