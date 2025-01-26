using System;
using Godot;

public partial class Board : Control
{
    [Export]
    private TextEdit board { get; set; }

    [Export]
    private AnimationPlayer Anim;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready() { }

    private void WriteBoard(string text)
    {
        Tween tween = GetTree().CreateTween();
        tween.Chain().TweenProperty(board, "text", $"   {text}\n", 5.0f);
    }

    private void ClearBoard()
    {
        board.Text = $"";
    }
}
