using System;
using System.Collections.Generic;

public class ScripturesLibrary
{
    private List<Scripture> _scripture;
    private Random _random = new Random();

    public ScripturesLibrary()
    {
        _scripture = new List<Scripture>();

        _scripture.Add(new Scripture(new Reference("1 Nephi", 3, 7), " And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them"));
        _scripture.Add(new Scripture(new Reference("Alma", 34, 32), " For behold, this life is the time for men to prepare to meet God; yea, behold the day of this life is the day for men to perform their labors"));
        _scripture.Add(new Scripture(new Reference("Jonh", 3, 16), " For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life"));
        _scripture.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), " Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him,and he shall direct thy paths"));
        _scripture.Add(new Scripture(new Reference("Joshua", 1, 9), " Have not I commanded thee? Be strong and of a good courage; be not afraid, neither be thou dismayed: for the Lord thy God is with thee whithersoever thou goest."));
    }

    public Scripture getRandom()
    {
        int index = _random.Next(_scripture.Count);
        return _scripture[index];
    }

}