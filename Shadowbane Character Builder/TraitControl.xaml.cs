﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Shadowbane_Character_Builder.CharacterInfo;

namespace Shadowbane_Character_Builder
{
    /// <summary>
    /// Interaction logic for TraitControl.xaml
    /// </summary>
    public partial class TraitControl : UserControl
    {
        public Trait myTrait;

        public TraitControl()
        {
            InitializeComponent();
        }

        public TraitControl newControl(Trait trait)
        {

            myTrait = trait;
            TraitText.Content = trait.ToString();
            TraitText.ToolTip = trait.ToTooltip();
            return this;
        }

    }
}
