using System;
using System.Collections;
using System.Collections.Generic;


[Serializable]
public class Instruction
{
    private string text;
    private string type;

    public Instruction(string text, string type)
    {
        this.text = text;
        this.type = type;
    }

    public string Text
    {
        get { return this.text; }
        set { this.text = value; }
    }
    public string Type
    {
        get { return this.type; }
        set { this.type = value; }
    }
}