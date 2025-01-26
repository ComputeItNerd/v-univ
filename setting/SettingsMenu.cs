using System;
using CommonTools;
using Godot;

public partial class SettingsMenu : Tool
{
    private TextureButton back;
    private Button themes;

    //private const String MainMenu = "res://menu/main_menu.tscn";
    //private const String Themes = "res://setting/themes.tscn";

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
            //SwitchTo(MainMenu);
        }
    }
}
