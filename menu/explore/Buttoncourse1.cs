using System;
using Godot;

public partial class Buttoncourse1 : Button
{
    private String Tag = "chemistry";

    private String GetCourseName()
    {
        return Text;
    }

    private void _on_button_up()
    {
        Node Parent = FindParent("explore_page");
        Parent.Call("SetCourse", "course_1");
    }

    private void _on_button_down()
    {
        Node Parent = FindParent("explore_page");
        Parent.Call("RemoveCourse");
    }

    private void CourseHide(String tag)
    {
        if (Tag == tag || tag == "all")
        {
            //GD.Print(Tag);
            Hide();
        }
    }

    private void CourseShow(String tag)
    {
        if (Tag == tag || tag == "all")
        {
            //GD.Print(Tag);
            Show();
        }
    }
}
