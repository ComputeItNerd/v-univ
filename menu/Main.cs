using System;
using Godot;

public partial class Main : Control
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready() { }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        //String RsPath = Tab.ResourcePath();
        //Global.Instance.PreviousTab = RsPath;
    }

    private void _on_child_order_changed() { }
}
