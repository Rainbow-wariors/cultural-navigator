using System;
using System.Collections.Generic;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Views;
using Google.Android.Material.BottomNavigation;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Color = Xamarin.Forms.Color;

namespace Navigator.Droid.Renderers.Elements
{
    public class BottomNavAppearance : ShellBottomNavViewAppearanceTracker
    {
        public Brush TabBarItemForeground;

        public BottomNavAppearance(IShellContext shellContext, ShellItem shellItem, Brush tabBarItemForeground) : base(
            shellContext, shellItem)
        {
            TabBarItemForeground = tabBarItemForeground;
        }

        public override void SetAppearance(BottomNavigationView bottomView, IShellAppearanceElement appearance)
        {
            base.SetAppearance(bottomView, appearance);
            IMenu menu = bottomView.Menu;
            var items = new List<IMenuItem>();
            int index = 0;
            do
            {
                try
                {
                    items.Add(menu.GetItem(index++));
                }
                catch
                {
                    break;
                }
            } while (true);
            
            foreach (var item in items)
            {
                // TODO: Add gradient support
            }
        }
    }
}