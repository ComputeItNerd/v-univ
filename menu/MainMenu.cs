using System;
using commonTools;
using Godot;

public partial class MainMenu : tool
{
    public Button Explore;
    public Button settings;
    public Button quit;

    public Panel BackGround;

    private String MainMenu_ = "res://menu/main_menu.tscn";
    private String SettingsMenu = "res://menu/settings_menu.tscn";
    private String ExploreMenu = "res://menu/explore_menu.tscn";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        BackGround = GetNode<Panel>("MarginContainer/BackGround");

        Explore = GetNode<Button>(
            "MarginContainer/BackGround/BoxContainer/middle_margin/explore/explore"
        );
        settings = GetNode<Button>(
            "MarginContainer/BackGround/BoxContainer/middle_margin/settings/settings"
        );
        quit = GetNode<Button>("MarginContainer/BackGround/BoxContainer/middle_margin/quit/quit");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        //GD.Print("MainMenu is Processing");
        if (Explore.ButtonPressed == true)
        {
            SwitchTo(ExploreMenu);
        }
        else if (settings.ButtonPressed == true)
        {
            SwitchTo(SettingsMenu);
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
}
