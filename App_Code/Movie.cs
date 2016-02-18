﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Movie
/// </summary>
public class Movie
{
    private String name;
    private String description;
    private int length;
    private byte[] poster;
    private String director;
    private String trailerURL;
    private String rating;
    private List<String> starring;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    public string Description
    {
        get
        {
            return description;
        }

        set
        {
            description = value;
        }
    }

    public int Length
    {
        get
        {
            return length;
        }

        set
        {
            length = value;
        }
    }

    public byte [] Poster
    {
        get
        {
            return poster;
        }

        set
        {
            poster = value;
        }
    }

    public string Director
    {
        get
        {
            return director;
        }

        set
        {
            director = value;
        }
    }

    public string TrailerURL
    {
        get
        {
            return trailerURL;
        }

        set
        {
            trailerURL = value;
        }
    }

    public string Rating
    {
        get
        {
            return rating;
        }

        set
        {
            rating = value;
        }
    }

    public List<string> Starring
    {
        get
        {
            return starring;
        }

        set
        {
            starring = value;
        }
    }

    public void AddActor(String actor)
    {
        starring.Add(actor);
    }

    public Movie()
    {
    }

    public Movie(string name, string description, int length, byte[] poster, string director, string trailerURL, string rating)
    {
        this.name = name;
        this.description = description;
        this.length = length;
        this.poster = poster;
        this.director = director;
        this.trailerURL = trailerURL;
        this.rating = rating;
    }
}