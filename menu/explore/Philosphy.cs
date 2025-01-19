using System;
using Godot;

public partial class Philosphy : Button
{
    private void _on_toggled(bool toggle)
    {
        if (toggle)
        {
            GetTree().CallGroup("ButtonCourses", "CourseShow", "philosophy");
        }
        else
        {
            GetTree().CallGroup("ButtonCourses", "CourseHide", "philosophy");
        }
    }
}
