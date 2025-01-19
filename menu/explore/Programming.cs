using System;
using Godot;

public partial class Programming : Button
{
    private void _on_toggled(bool toggle)
    {
        if (toggle)
        {
            GetTree().CallGroup("ButtonCourses", "CourseShow", "programming");
        }
        else
        {
            GetTree().CallGroup("ButtonCourses", "CourseHide", "programming");
        }
    }
}
