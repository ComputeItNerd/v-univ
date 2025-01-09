using System;
using Godot;

public partial class Global : Node
{
    public static Global Instance { get; private set; }

    public String PreviousTab { get; set; }

    public override void _Ready()
    {
        Instance = this;
    }
}
