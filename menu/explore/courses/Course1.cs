using System;
using commonTools;
using Godot;

public partial class Course1 : tool
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
            SwitchTo(ExploreMenu);
        }
    }
}
