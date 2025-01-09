using System;
using commonTools;
using Godot;

public partial class ExploreMenu : tool
{
    private TextureButton back;
    private VBoxContainer course;
    private Panel portfolio;

    [Signal]
    public delegate void ButtonClickEventHandler();

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        // Reference the Back button
        back = GetNode<TextureButton>("back");
        // Reference the Course button
        course = GetNode<VBoxContainer>(
            "PanelContainer/PanelContainer/BackGround/MarginContainer/HBoxContainer/courses/courses_tab"
        );
        // Reference the Portfolio button
        portfolio = GetNode<Panel>(
            "PanelContainer/PanelContainer/BackGround/MarginContainer/HBoxContainer/port"
        );

        Connect(SignalName.ButtonClick, Callable.From(CourseSelect));
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        // Go to previous window if back button is clicked
        if (back.ButtonPressed == true)
        {
            SwitchTo(MainMenu);
        }
        // Checks if the user clicked any part of the program
        if (Input.IsAnythingPressed())
        {
            // Emit the signal ButtonClick
            EmitSignal("ButtonClick");
        }
    }

    // This method will check for any course button selected
    private void CourseSelect()
    {
        if (portfolio.Visible == false)
        {
            // Get the number of courses
            int coursenumber = course.GetChildCount();
            // Loop through the courses
            for (int x = 0; x < coursenumber; x++)
            {
                // Cast the Node that's returned by GetChild() method to button class to
                // access the ButtonPressed() method
                Button c = (Button)course.GetChild(x);
                //GD.Print(c.ButtonPressed);
                if (c.ButtonPressed == true && portfolio.Visible == false)
                {
                    portfolio.Show();
                    break;
                }
            }
        }
        else if (portfolio.Visible == true)
        {
            portfolio.Hide();
        }
    }
}
