﻿using System;

//Skapa en klass Person och ge den följande privata fält: age, fName, lName, height, weight
public class Person
{
    private int _age;
    private string? _fName;
    private string? _lName;
    private double _height;
    private double _weight;

    public Person(string fName, string lName)
	{
        FName = fName;
        LName = lName;
    }

    //Age
    public int Age
    {
        get => _age;
        set
        {
            if (value > 0) 
            {
                _age = value;
            } else {
                throw new ArgumentException("Age must be higher than 0");
            }
        }
    }

    //FName
    public string FName
    {
        get => _fName;
        set
        {
            if (value.Length > 1 && value.Length < 11)
            {
                _fName = value;
            } else {
                throw new ArgumentException("Firstname must have between 2 and 10 characters");
            }
        }
    }

    //LName
    public string LName
    {
        get => _lName;
        set
        {
            if (value.Length > 2 && value.Length < 16)
            {
                _lName = value;
            } else {
                throw new ArgumentException("Lastname must have between 3 and 15 characters");
            }
        }
    }

    //Height
    public double Height
    {
        get => _height;
        set => _height = value;
    }

    //Weight
    public double Weight
    {
        get => _weight;
        set => _weight = value;
    }
}
