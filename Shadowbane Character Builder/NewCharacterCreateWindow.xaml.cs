using System;
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
using System.Windows.Shapes;
using Shadowbane_Character_Builder.CharacterInfo;

namespace Shadowbane_Character_Builder
{
    /// <summary>
    /// Interaction logic for NewCharacterCreateWindow.xaml
    /// </summary>
    public partial class NewCharacterCreateWindow : Window
    {
        Character myCharacter;
        public MainWindow mainWin;
        List<TraitControl> Traits = new List<TraitControl>();

        public NewCharacterCreateWindow()
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            myCharacter = new Character();
            Race[] RaceArray = new Race[12] { new Human(), new Aelfborn(), new Dwarf(), new Elf(), new HalfGiant(), new Irekei(), new Shade(), 
                                              new Aracoix(), new Centaur(), new Minotaur(), new Nephilim(), new Vampire() };
            for (int i = 0; i < 12; i++)
            {
                RaceSelextBox.Items.Add(RaceArray[i]);
            }
            Traits.Add(new TraitControl().newControl(new Mighty()));
            Traits.Add(new TraitControl().newControl(new HerosStrength()));
            Traits.Add(new TraitControl().newControl(new Hearty()));
            Traits.Add(new TraitControl().newControl(new HealthyAsAnOx()));
            for (int i = 0; i < Traits.Count; i++)
            {
                TraitSelectBox.Items.Add(Traits[i]);
            }
        }

        void UpdateCharacterDisplays()
        {
            StartingAbilityPointsText.Text = myCharacter.AbilityPoints.NewCharValue.ToString();

            StrengthText.Text = myCharacter.Strength.ToString();
            DexterityText.Text = myCharacter.Dexterity.ToString();
            ConstitutionText.Text = myCharacter.Constitution.ToString();
            IntelligenceText.Text = myCharacter.Intelligence.ToString();
            SpiritText.Text = myCharacter.Spirit.ToString();
        }

        private void RaceSelextBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RaceSelextBox.SelectedItem != null)
            {
                BaseClass[] BaseArray = new BaseClass[4] { new Fighter(), new Healer(), new Rogue(), new Mage() };
                BaseClassSelectBox.Items.Clear();
                var myItem = (Race)RaceSelextBox.SelectedItem;
                myCharacter.SetNewRace(myItem);
                switch (myItem.raceType)
                {
                    case Race.RaceEnum.Human:
                        BaseClassSelectBox.Items.Add(BaseArray[0]);
                        BaseClassSelectBox.Items.Add(BaseArray[1]);
                        BaseClassSelectBox.Items.Add(BaseArray[2]);
                        BaseClassSelectBox.Items.Add(BaseArray[3]);
                        break;
                    case Race.RaceEnum.Aelfborn:
                        BaseClassSelectBox.Items.Add(BaseArray[0]);
                        BaseClassSelectBox.Items.Add(BaseArray[1]);
                        BaseClassSelectBox.Items.Add(BaseArray[2]);
                        BaseClassSelectBox.Items.Add(BaseArray[3]);
                        break;
                    case Race.RaceEnum.Dwarf:
                        BaseClassSelectBox.Items.Add(BaseArray[0]);
                        BaseClassSelectBox.Items.Add(BaseArray[1]);
                        break;
                    case Race.RaceEnum.Elf:
                        BaseClassSelectBox.Items.Add(BaseArray[0]);
                        BaseClassSelectBox.Items.Add(BaseArray[1]);
                        BaseClassSelectBox.Items.Add(BaseArray[2]);
                        BaseClassSelectBox.Items.Add(BaseArray[3]);
                        break;
                    case Race.RaceEnum.HalfGiant:
                        BaseClassSelectBox.Items.Add(BaseArray[0]);
                        break;
                    case Race.RaceEnum.Irekei:
                        BaseClassSelectBox.Items.Add(BaseArray[0]);
                        BaseClassSelectBox.Items.Add(BaseArray[1]);
                        BaseClassSelectBox.Items.Add(BaseArray[2]);
                        BaseClassSelectBox.Items.Add(BaseArray[3]);
                        break;
                    case Race.RaceEnum.Shade:
                        BaseClassSelectBox.Items.Add(BaseArray[0]);
                        BaseClassSelectBox.Items.Add(BaseArray[2]);
                        BaseClassSelectBox.Items.Add(BaseArray[3]);
                        break;
                    case Race.RaceEnum.Aracoix:
                        BaseClassSelectBox.Items.Add(BaseArray[0]);
                        BaseClassSelectBox.Items.Add(BaseArray[1]);
                        BaseClassSelectBox.Items.Add(BaseArray[2]);
                        break;
                    case Race.RaceEnum.Centaur:
                        BaseClassSelectBox.Items.Add(BaseArray[0]);
                        BaseClassSelectBox.Items.Add(BaseArray[1]);
                        break;
                    case Race.RaceEnum.Minotaur:
                        BaseClassSelectBox.Items.Add(BaseArray[0]);
                        BaseClassSelectBox.Items.Add(BaseArray[1]);
                        break;
                    case Race.RaceEnum.Nephilim:
                        BaseClassSelectBox.Items.Add(BaseArray[0]);
                        BaseClassSelectBox.Items.Add(BaseArray[1]);
                        BaseClassSelectBox.Items.Add(BaseArray[2]);
                        BaseClassSelectBox.Items.Add(BaseArray[3]);
                        break;
                    case Race.RaceEnum.Vampire:
                        BaseClassSelectBox.Items.Add(BaseArray[0]);
                        BaseClassSelectBox.Items.Add(BaseArray[2]);
                        BaseClassSelectBox.Items.Add(BaseArray[3]);
                        break;

                }
                UpdateCharacterDisplays();
            }
        }

        private void BaseClassSelectBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BaseClassSelectBox.SelectedItem != null)
            {
                var myItem = (BaseClass)BaseClassSelectBox.SelectedItem;
                myCharacter.SetNewBaseClass(myItem);
                UpdateCharacterDisplays();
            }
        }

        #region Stat Change Buttons
        private void StrengthAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (RaceSelextBox.SelectedItem != null && BaseClassSelectBox.SelectedItem != null)
            {
                if (myCharacter.AbilityPoints.canSubtractNew(1) && myCharacter.Strength.canAdd(1))
                {
                    myCharacter.AbilityPoints.SubtractNew(1);
                    myCharacter.Strength.Add(1);
                }
                StrengthText.Text = myCharacter.Strength.ToString();
                StartingAbilityPointsText.Text = myCharacter.AbilityPoints.NewCharValue.ToString();
            }
        }

        private void StrengthSubButton_Click(object sender, RoutedEventArgs e)
        {
            if (RaceSelextBox.SelectedItem != null && BaseClassSelectBox.SelectedItem != null)
            {
                if (myCharacter.AbilityPoints.canAddNew(1) && myCharacter.Strength.canSubtract(1))
                {
                    myCharacter.AbilityPoints.AddNew(1);
                    myCharacter.Strength.Subtract(1);
                }
                StrengthText.Text = myCharacter.Strength.ToString();
                StartingAbilityPointsText.Text = myCharacter.AbilityPoints.NewCharValue.ToString();
            }
        }

        private void DexterityAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (RaceSelextBox.SelectedItem != null && BaseClassSelectBox.SelectedItem != null)
            {
                if (myCharacter.AbilityPoints.canSubtractNew(1) && myCharacter.Dexterity.canAdd(1))
                {
                    myCharacter.AbilityPoints.SubtractNew(1);
                    myCharacter.Dexterity.Add(1);
                }
                DexterityText.Text = myCharacter.Dexterity.ToString();
                StartingAbilityPointsText.Text = myCharacter.AbilityPoints.NewCharValue.ToString();
            }
        }

        private void DexteritySubButton_Click(object sender, RoutedEventArgs e)
        {
            if (RaceSelextBox.SelectedItem != null && BaseClassSelectBox.SelectedItem != null)
            {
                if (myCharacter.AbilityPoints.canAddNew(1) && myCharacter.Dexterity.canSubtract(1))
                {
                    myCharacter.AbilityPoints.AddNew(1);
                    myCharacter.Dexterity.Subtract(1);
                }
                DexterityText.Text = myCharacter.Dexterity.ToString();
                StartingAbilityPointsText.Text = myCharacter.AbilityPoints.NewCharValue.ToString();
            }
        }

        private void ConstitutionAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (RaceSelextBox.SelectedItem != null && BaseClassSelectBox.SelectedItem != null)
            {
                if (myCharacter.AbilityPoints.canSubtractNew(1) && myCharacter.Constitution.canAdd(1))
                {
                    myCharacter.AbilityPoints.SubtractNew(1);
                    myCharacter.Constitution.Add(1);
                }
                ConstitutionText.Text = myCharacter.Constitution.ToString();
                StartingAbilityPointsText.Text = myCharacter.AbilityPoints.NewCharValue.ToString();
            }
        }

        private void ConstitutionSubButton_Click(object sender, RoutedEventArgs e)
        {
            if (RaceSelextBox.SelectedItem != null && BaseClassSelectBox.SelectedItem != null)
            {
                if (myCharacter.AbilityPoints.canAddNew(1) && myCharacter.Constitution.canSubtract(1))
                {
                    myCharacter.AbilityPoints.AddNew(1);
                    myCharacter.Constitution.Subtract(1);
                }
                ConstitutionText.Text = myCharacter.Constitution.ToString();
                StartingAbilityPointsText.Text = myCharacter.AbilityPoints.NewCharValue.ToString();
            }
        }

        private void IntelligenceAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (RaceSelextBox.SelectedItem != null && BaseClassSelectBox.SelectedItem != null)
            {
                if (myCharacter.AbilityPoints.canSubtractNew(1) && myCharacter.Intelligence.canAdd(1))
                {
                    myCharacter.AbilityPoints.SubtractNew(1);
                    myCharacter.Intelligence.Add(1);
                }
                IntelligenceText.Text = myCharacter.Intelligence.ToString();
                StartingAbilityPointsText.Text = myCharacter.AbilityPoints.NewCharValue.ToString();
            }
        }

        private void IntelligenceSubButton_Click(object sender, RoutedEventArgs e)
        {
            if (RaceSelextBox.SelectedItem != null && BaseClassSelectBox.SelectedItem != null)
            {
                if (myCharacter.AbilityPoints.canAddNew(1) && myCharacter.Intelligence.canSubtract(1))
                {
                    myCharacter.AbilityPoints.AddNew(1);
                    myCharacter.Intelligence.Subtract(1);
                }
                IntelligenceText.Text = myCharacter.Intelligence.ToString();
                StartingAbilityPointsText.Text = myCharacter.AbilityPoints.NewCharValue.ToString();
            }
        }

        private void SpiritAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (RaceSelextBox.SelectedItem != null && BaseClassSelectBox.SelectedItem != null)
            {
                if (myCharacter.AbilityPoints.canSubtractNew(1) && myCharacter.Spirit.canAdd(1))
                {
                    myCharacter.AbilityPoints.SubtractNew(1);
                    myCharacter.Spirit.Add(1);
                }
                SpiritText.Text = myCharacter.Spirit.ToString();
                StartingAbilityPointsText.Text = myCharacter.AbilityPoints.NewCharValue.ToString();
            }
        }

        private void SpiritSubButton_Click(object sender, RoutedEventArgs e)
        {
            if (RaceSelextBox.SelectedItem != null && BaseClassSelectBox.SelectedItem != null)
            {
                if (myCharacter.AbilityPoints.canAddNew(1) && myCharacter.Spirit.canSubtract(1))
                {
                    myCharacter.AbilityPoints.AddNew(1);
                    myCharacter.Spirit.Subtract(1);
                }
                SpiritText.Text = myCharacter.Spirit.ToString();
                StartingAbilityPointsText.Text = myCharacter.AbilityPoints.NewCharValue.ToString();
            }
        }
        #endregion


    }


}
