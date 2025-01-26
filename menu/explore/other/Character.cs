using System;
using Godot;

public partial class Character : Control
{
    [Export]
    private Label dialogue { get; set; }

    [Export]
    private Button Yes { get; set; }

    [Export]
    private Button No { get; set; }

    [Export]
    private HBoxContainer Ask { get; set; }

    public override void _Ready()
    {
    }

    private void Say(string text)
    {
        dialogue.Text = text;
    }

    private void Ask_(string what, string then, string otherwise)
    {
        dialogue.Text = $"{what}?";
        Ask.Show();
        Yes.Pressed += () => Yes_(then);
        No.Pressed += () => No_(otherwise);
    }

    private void Yes_(string then)
    {
        dialogue.Text = $"{then}";
        Ask.Hide();
    }

    private void No_(string otherwise)
    {
        dialogue.Text = $"{otherwise}";
        Ask.Hide();
    }

    private void Fade()
    {
        Tween tween = GetTree().CreateTween();
        tween.Chain().TweenProperty(this, "modulate:a", 0.2f, 1.0f);
    }
}
