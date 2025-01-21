using System;
using CommonTools;
using Godot;

public partial class ExplorePage : Tool
{
    private TextureButton Back;
    private Button AccountSettings;
    private Button Settings;
    private Button About;
    private Button AccountDetails;
    private VBoxContainer Course_Select;
    private Control CourseProfile;
    private LineEdit SearchBar;

    private MarginContainer TopRightCorner;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        Back = GetNode<TextureButton>("MarginContainer/BackGround/MarginContainer5/back");
        AccountDetails = GetNode<Button>(
            "MarginContainer/BackGround/MarginContainer4/Panel/account_details"
        );
        AccountSettings = GetNode<Button>(
            "MarginContainer/BackGround/MarginContainer3/HBoxContainer/HSplitContainer/MarginContainer6/account/MarginContainer/VBoxContainer/account_settings"
        );
        TopRightCorner = GetNode<MarginContainer>(
            "MarginContainer/BackGround/MarginContainer3/HBoxContainer/HSplitContainer/MarginContainer6"
        );
        Course_Select = GetNode<VBoxContainer>(
            "MarginContainer/BackGround/MarginContainer3/HBoxContainer/HSplitContainer/MarginContainer3/Panel/HBoxContainer/MarginContainer/course/ScrollContainer/course_selection"
        );
        CourseProfile = GetNode<Control>(
            "MarginContainer/BackGround/MarginContainer3/HBoxContainer/HSplitContainer/MarginContainer3/Panel/HBoxContainer/MarginContainer2/portfolio/course_portfolio"
        );
        SearchBar = GetNode<LineEdit>(
            "MarginContainer/BackGround/MarginContainer2/search/MarginContainer/searchBar"
        );
        AccountDetails.Toggled += OpenPanel;
        AccountSettings.Pressed += SwitchTab;

        SearchBar.TextChanged += (new_text) => SearchTag(new_text);

        GetTree().CallGroup("ButtonCourses", "CourseShow", "all");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta) { }

    private void SearchTag(String new_text)
    {
        String input = new_text.Capitalize();
        int CourseCount = Course_Select.GetChildCount();
        for (int i = 0; i < CourseCount; i++)
        {
            Button course = (Button)Course_Select.GetChild(i);
            String CourseName = (String)course.Call("GetCourseName");
            String CourseNameCapitalized = CourseName.Capitalize();
            if (CourseNameCapitalized.Contains(input))
            {
                course.Show();
            }
            else
            {
                course.Hide();
            }
        }
    }

    private void SetCourse(String course)
    {
        var file = (PackedScene)ResourceLoader.Load($"res://menu/explore/courses/{course}.tscn");
        Node instanced = file.Instantiate();
        if (!instanced.HasMethod("GetTag"))
        {
            GD.PushError($"Given path {course} is not a course file.");
        }

        var dict = instanced.Call("GetCourseInfo");
        CourseProfile.Call("DisplayInformation", dict);
        instanced.Free();
    }

    private void RemoveCourse()
    {
        CourseProfile.Call("ClearDisplay");
    }

    private void SwitchTab()
    {
        AccountDetails.Toggled -= OpenPanel;
        AccountSettings.Pressed -= SwitchTab;
        SwitchTo(_AccountSettings);
    }

    private void OpenPanel(bool toggle)
    {
        if (toggle == true)
        {
            TopRightCorner.Show();
        }
        else
        {
            TopRightCorner.Hide();
        }
    }

    /* edit the stylebox of a panel
    StyleBoxFlat styleBox = (StyleBoxFlat)Explore.GetThemeStylebox("panel").Duplicate();
    while (styleBox.BorderWidthLeft != 160)
    {
        styleBox.BorderWidthLeft += 1;
    }
    Explore.AddThemeStyleboxOverride("panel", styleBox);*/

    public void on_tree_entered()
    {
        SetProcess(true);
        Show();
    }
}
