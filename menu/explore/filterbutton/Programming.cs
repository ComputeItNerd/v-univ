using System;
using Godot;

public partial class Programming : Button
{
    private void _on_toggled(bool toggle)
    {
        GetTree().CallGroup("ButtonCourses", "CourseHide", "programming");
        if (toggle)
        {
            GetTree().CallGroup("ButtonCourses", "CourseShow", "programming");
        }
        else
        {
            GetTree().CallGroup("ButtonCourses", "CourseHide", "programming");
        }
    }

    private void Unpress()
    {
        ButtonPressed = false;
        GetTree().CallGroup("ButtonCourses", "CourseHide", "all");
    }
}
