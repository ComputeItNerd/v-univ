using System;
using commonTools;
using Godot;

public partial class SettingsMenu : tool
{
    private TextureButton back;
    private Button themes;

    //private const String MainMenu = "res://menu/main_menu.tscn";
    //private const String Themes = "res://setting/themes.tscn";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        back = GetNode<TextureButton>("back");
        themes = GetNode<Button>(
            "settings/Panel/VBoxContainer/Panel/PanelContainer/VBoxContainer/Themes/themes"
        );
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        if (back.ButtonPressed == true)
        {
            Open(MainMenu);
        }
        else if (themes.ButtonPressed == true)
        {
            Open(Themes);
        }
    }
}
