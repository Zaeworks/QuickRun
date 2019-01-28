﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace QuickRun.SDK
{
    public class BaseFolder : BaseButton, IFolder
    {
        public virtual IEnumerable<IButton> Buttons { get; }

        public virtual string Title { get; set; }

        public event EventHandler ItemAdded;

        public override void OnClick(object sender, RoutedEventArgs e)
        {
            //XElement.Parse("").remove
            Main.Instance.ShowFolder(this);
        }
    }
}