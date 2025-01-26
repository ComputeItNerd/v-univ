using System;
using Godot;

public partial class Philosphy : Button
{
    private void _on_toggled(bool toggle)
    {
        GetTree().CallGroup("ButtonCourses", "CourseHide", "philosophy");
        if (toggle)
        {
            GetTree().CallGroup("ButtonCourses", "CourseShow", "philosophy");
        }
        else
        {
            GetTree().CallGroup("ButtonCourses", "CourseHide", "philosophy");
        }
    }

    private void Unpress()
    {
        ButtonPressed = false;
        GetTree().CallGroup("ButtonCourses", "CourseHide", "all");
    }
}
