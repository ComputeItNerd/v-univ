using System;
using Godot;

public partial class Chemistry : Button
{
    private void _on_toggled(bool toggle)
    {
        GetTree().CallGroup("ButtonCourses", "CourseHide", "chemistry");
        if (toggle)
        {
            GetTree().CallGroup("ButtonCourses", "CourseShow", "chemistry");
        }
        else
        {
            GetTree().CallGroup("ButtonCourses", "CourseHide", "chemistry");
        }
    }
}
