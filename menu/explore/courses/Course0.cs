using System;
using CommonTools;
using Godot;

public partial class Course0 : Tool
{
    private TextureButton back;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        back = GetNode<TextureButton>("back");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        if (back.ButtonPressed == true)
        {
            //SwitchTo(ExploreMenu);
        }
    }

    private String GetTag()
    {
        return "math";
    }

    private Godot.Collections.Dictionary GetCourseInfo()
    {
        Godot.Collections.Dictionary info = new Godot.Collections.Dictionary
        {
            { "professor", "chill_guy" },
            { "course", "Addition of whole numbers" },
            { "subject", "math" },
        };

        return info;
    }
}
