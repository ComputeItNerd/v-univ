using Godot;

[GlobalClass]
public partial class Buttoncourse0 : Button
{
    [Export]
    private string Tag { get; set; } = "";

    [Export]
    private string Title;

    [Export]
    private string CourseName = "";

    public override void _Ready()
    {
        AddToGroup("ButtonCourses");
        Connect(Button.SignalName.ButtonUp, Callable.From(_on_button_up));
        Connect(Button.SignalName.ButtonDown, Callable.From(_on_button_down));
        SetTitle();
        CheckParam();
    }

    private void SetTitle()
    {
        Text = Title;
        GD.Print("Djfd");
    }

    private void CheckParam()
    {
        if (Tag == "" || Tag == null)
        {
            GD.PushError($"Tag parameter should be specified");
        }
        if (CourseName == null)
        {
            GD.PushError($"'CourseName' parameter should be specified {GetPath()}");
        }
    }

    private string GetCourseName()
    {
        return Text;
    }

    private void _on_button_up()
    {
        Node Parent = FindParent("explore_page");
        // The second argument is small letters 'course' with an '_' followed by a number 'x', this argument
        // is the name of this scene as .tscn file.
        Parent.Call("SetCourse", $"{CourseName}");
    }

    private void _on_button_down()
    {
        Node Parent = FindParent("explore_page");
        Parent.Call("RemoveCourse");
    }

    private void CourseHide(string tag)
    {
        if (Tag == tag || tag == "all")
        {
            Hide();
            GD.Print("Hidden");
        }
    }

    private void CourseShow(string tag)
    {
        if (Tag == tag || tag == "all")
        {
            Show();
            GD.Print("Showed");
        }
    }
}
