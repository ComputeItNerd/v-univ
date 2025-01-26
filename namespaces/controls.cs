using System;
using Godot;

namespace CommonTools
{
    public partial class Tool : Control
    {
        public const String _ExplorePage = "res://menu/explore/explore_page.tscn";
        public const String _AccountSettings = "res://account_settings/account_settings.tscn";
        public String _Settings = "res://menu/settings_menu.tscn";
        public String _About = "res://about/about.tscn";

        public void SwitchTo(String path)
        {
            Tween tween = GetTree().CreateTween();
            tween.TweenCallback(Callable.From(() => AddChild(path)));
            tween.TweenProperty(this, "modulate:a", 0.0f, 1.0f).SetTrans(Tween.TransitionType.Sine);
        }

        private void AddChild(String path)
        {
            var menu = ResourceLoader.Load<PackedScene>(path).Instantiate();
            GetParent().AddChild(menu);
            Free();
        }

        public Control FindTab(String TabName, String GroupName)
        {
            Control? ReturnNode = null;
            var Icon = GetTree().GetNodesInGroup(GroupName);
            int NumIcon = GetTree().GetNodeCountInGroup(GroupName);
            for (int i = 0; i < NumIcon; i++)
            {
                var Retrieve = Icon[i];
                if (Retrieve.Name == TabName)
                {
                    ReturnNode = (Control)Retrieve;
                    break;
                }
            }
            return ReturnNode;
        }

        public void SetTheme(string property, Variant value, Panel node)
        {
            StyleBoxFlat stylebox = (StyleBoxFlat)node.GetThemeStylebox("panel").Duplicate();

            stylebox.Set(property, value);

            node.AddThemeStyleboxOverride("panel", stylebox);
        }

        public void CoursePortfolio(String path, String text)
        {
            Label node = GetNode<Label>(path);
            node.Text = text.Remove(0, 2);
        }
    }

}
