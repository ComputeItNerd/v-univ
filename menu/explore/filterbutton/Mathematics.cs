using Godot;
using System;

public partial class Mathematics : Button
{
    private void _on_toggled(bool toggle)
    {
        GetTree().CallGroup("ButtonCourses", "CourseHide", "mathematics");
        if (toggle)
        {
            GetTree().CallGroup("ButtonCourses", "CourseShow", "mathematics");
        }
        else
        {
            GetTree().CallGroup("ButtonCourses", "CourseHide", "mathematics");
        }
    }

    private void Unpress()
    {
        ButtonPressed = false;
        GetTree().CallGroup("ButtonCourses", "CourseHide", "all");
    }
}
