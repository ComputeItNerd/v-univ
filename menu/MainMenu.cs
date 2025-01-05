using System;
using Godot;

public partial class MainMenu : Control
{
    public Button Explore;
    public Button settings;
    public Button quit;

    private String MainMenu_ = "res://menu/main_menu.tscn";
    private String SettingsMenu = "res://menu/settings_menu.tscn";
    private String ExploreMenu = "res://menu/explore_menu.tscn";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        Explore = GetNode<Button>(
            "MarginContainer/Panel/BoxContainer/middle_margin/explore/explore"
        );
        settings = GetNode<Button>(
            "MarginContainer/Panel/BoxContainer/middle_margin/settings/settings"
        );
        quit = GetNode<Button>("MarginContainer/Panel/BoxContainer/middle_margin/quit/quit");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        //GD.Print("MainMenu is Processing");
        if (Explore.ButtonPressed == true)
        {
            OpenMenu(ExploreMenu);
        }
        else if (settings.ButtonPressed == true)
        {
            OpenMenu(SettingsMenu);
        }
        else if (quit.ButtonPressed == true)
        {
            GetTree().Quit();
        }
    }

    /* edit the stylebox of a panel
    StyleBoxFlat styleBox = (StyleBoxFlat)Explore.GetThemeStylebox("panel").Duplicate();
    while (styleBox.BorderWidthLeft != 160)
    {
        styleBox.BorderWidthLeft += 1;
    }
    Explore.AddThemeStyleboxOverride("panel", styleBox);*/

    private void OpenMenu(string path)
    {
        Color Alpha = Modulate;
        if (Alpha.A >= 0.0f)
        {
            Alpha.A -= 0.1f;
            Modulate = Alpha;
        }
        else
        {
            //var menu = ResourceLoader.Load<PackedScene>(path).Instantiate();
            var menu = ResourceLoader.Load<PackedScene>(path).Instantiate();
            GetParent().AddChild(menu);
            Free();
        }
    }
}
