using System;
using CommonTools;
using Godot;

public partial class Themes : Control
{
    private TextureButton back;
    private ColorPickerButton bg_color;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        bg_color = GetNode<ColorPickerButton>(
            "MarginContainer/Panel/HBoxContainer/variables/Panel/main_menu_background_color"
        );
        back = GetNode<TextureButton>("back");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        if (back.ButtonPressed == true)
        {
            //SwitchTo(SettingsMenu);
        }
    }

    private void _on_main_menu_background_color_color_changed(Color color)
    {
        /*GD.Print(color);
        var nodes = GetTree().GetNodesInGroup("Tabs");
        int nodecount = GetTree().GetNodeCountInGroup("Tabs");
        for (int i = 0; i < nodecount; i++)
        {
            //GD.Print(node.Name);
            if (nodes[i].Name == "BackGround")
            {
                Tool Toolnode = (Tool)nodes[i];
                Panel panelnode = (Panel)nodes[i];
                Toolnode.SetTheme("BgColor", color, panelnode);
            }
        }*/
    }
}
