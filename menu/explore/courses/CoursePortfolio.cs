using System;
using CommonTools;
using Godot;

public partial class CoursePortfolio : Tool
{
    private TextureButton back;
    private VBoxContainer Display;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        Display = GetNode<VBoxContainer>(
            "AspectRatioContainer/MarginContainer/MarginContainer2/ForeGround/AspectRatioContainer/VBoxContainer"
        );
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta) { }

    private void DisplayInformation(Godot.Collections.Dictionary dict)
    {
        int CountButton = Display.GetChildCount();

        for (int button = 0; button < CountButton; button++)
        {
            Label n = (Label)Display.GetChild(button);
            int count = dict.Count;

            for (int i = 0; i < count; i++)
            {
                var info = new Godot.Collections.Array<String> { "course", "subject", "professor" };

                if (n.Name == info[i])
                {
                    String s = (String)n.Name;
                    String d = (String)dict[info[i]];
                    n.Text = $"{s.Capitalize()} : {d.Capitalize()}";
                }
            }
        }
    }

    private void ClearDisplay()
    {
        int CountButton = Display.GetChildCount();
        for (int button = 0; button < CountButton; button++)
        {
            Label n = (Label)Display.GetChild(button);
            n.Text = "";
        }
    }
}
