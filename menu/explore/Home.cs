using System;
using Godot;

public partial class Home : Button
{
    private void _on_toggled(bool toggle)
    {
        if (toggle)
        {
            GetTree().CallGroup("ButtonCourses", "CourseShow", "all");
        }
        else
        {
            GetTree().CallGroup("ButtonCourses", "CourseHide", "all");
        }
    }
}
