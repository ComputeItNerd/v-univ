using System;
using Godot;

namespace commonTools
{
    public partial class tool : Control
    {
        public const String MainMenu = "res://menu/main_menu.tscn";
        public const String Themes = "res://setting/themes.tscn";
        public String SettingsMenu = "res://menu/settings_menu.tscn";
        public String ExploreMenu = "res://menu/explore_menu.tscn";

        public void Open(string path)
        {
            Color Alpha = Modulate;
            if (Alpha.A >= 0.0f)
            {
                Alpha.A -= 0.1f;
                Modulate = Alpha;
            }
            else
            {
                var menu = ResourceLoader.Load<PackedScene>(path).Instantiate();
                GetParent().AddChild(menu);
                Free();
            }
        }
    }
}
