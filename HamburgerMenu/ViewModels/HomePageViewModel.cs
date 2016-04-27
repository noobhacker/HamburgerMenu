using HamburgerMenu.Items;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerMenu.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<HamburgerMenuItem> HamburgerMenuItems =
            new ObservableCollection<HamburgerMenuItem>();

        private string[] icons = { "", "", "", "" }; //http://modernicons.io/segoe-mdl2/cheatsheet/
        private string[] texts = { "Homepage", "Video", "Camera", "Microphone" }; 
        private Type[] frames = { null, null, null, null }; // insert page here typeof(Page)

        public MainPageViewModel()
        {
            for (int i = 0; i < icons.Length; i++)
            {
                HamburgerMenuItems.Add(new HamburgerMenuItem()
                {
                    Icon = icons[i],
                    Text = texts[i],
                    TargetFrame = frames[i]
                });
            }
        }

    }

}
