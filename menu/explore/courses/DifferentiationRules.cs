using System;
using Godot;

public partial class DifferentiationRules : Control
{
    private TextureButton back;

    [Export]
    private Control board;

    [Export]
    private Control character;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        Lecture();
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta) { }

    private String GetTag()
    {
        return "math";
    }

    private Godot.Collections.Dictionary GetCourseInfo()
    {
        Godot.Collections.Dictionary info = new Godot.Collections.Dictionary
        {
            { "professor", "chill_guy" },
            { "course", "Differentiation Rules" },
            { "subject", "calculus" },
        };

        return info;
    }

    private void Lecture()
    {
        character.Call(
            "Say",
            "The first rule states that deriving any constants, meaning any number denoted by the letter 'k' will always be zero "
        );
        //character.Call("Fade");
        board.Call(
            "WriteBoard",
            "The first rule in Differentiation is called the Constant rule \n    The formula is d/dx k = 0 "
        );
    }
}
