using Godot;
using System;

public partial class Mathematics : Button
{
    private void _on_toggled(bool toggle)
    {
        if (toggle)
        {
            GetTree().CallGroup("ButtonCourses", "CourseShow", "mathematics");
        }
        else
        {
            GetTree().CallGroup("ButtonCourses", "CourseHide", "mathematics");
        }
    }
}
