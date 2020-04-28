﻿using System;

public enum Rating
{
    Good,
    Great,
    Excellent
}

public struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog( string dgName, float dgAge, string dgOwner, Rating dgRating)
    {
        name = dgName;
        age = dgAge;
        owner = dgOwner;
        rating = dgRating;
    }

    public override string ToString()
    {
        return "Dog name: " + name + "\n" + "Agr: " + age + "\n" + "Owner: " + owner + "\n" + "Rating: " + rating; 
    }
}
