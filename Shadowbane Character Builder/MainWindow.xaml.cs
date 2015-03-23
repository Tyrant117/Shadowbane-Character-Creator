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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Shadowbane_Character_Builder.CharacterInfo;

namespace Shadowbane_Character_Builder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Character myCharacter;
        bool isNewCharacter;
        bool isLoadCharacter;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            StartupWindow startWin = new StartupWindow();
            startWin.mainWin = this;
            startWin.ShowDialog();
        }

        public void NewCharacter()
        {
            isNewCharacter = true;
            myCharacter = new Character();
            Race[] RaceArray = new Race[12] { new Human(), new Aelfborn(), new Dwarf(), new Elf(), new HalfGiant(), new Irekei(), new Shade(), 
                                              new Aracoix(), new Centaur(), new Minotaur(), new Nephilim(), new Vampire() };
            for (int i = 0; i < 12; i++)
            {
                RaceSelextBox.Items.Add(RaceArray[i]);
            }

            
        }

        public void LoadCharacter(string loadChar)
        {
            isLoadCharacter = true;
        }

        void UpdateCharacterDisplays()
        {
            StartingAbilityPointsText.Text = myCharacter.AbilityPoints.NewCharValue.ToString();
            AbilityPointsText.Text = myCharacter.AbilityPoints.PostCreateValue.ToString();
            TrainingPointsText.Text = myCharacter.TrainingPoints.ToString();

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
                //if (myCharacter.Strength.Add(1))
                //{
                //    //myCharacter.AbilityPoints.Subtract(1);
                //}
                StrengthText.Text = myCharacter.Strength.ToString();
                StartingAbilityPointsText.Text = myCharacter.AbilityPoints.NewCharValue.ToString();
                AbilityPointsText.Text = myCharacter.AbilityPoints.PostCreateValue.ToString();
            }
        }

        private void StrengthSubButton_Click(object sender, RoutedEventArgs e)
        {
            if (RaceSelextBox.SelectedItem != null && BaseClassSelectBox.SelectedItem != null)
            {
                //if (myCharacter.Strength.Subtract(1))
                //{
                //    //myCharacter.AbilityPoints.Add(1);
                //}
                StrengthText.Text = myCharacter.Strength.ToString();
                StartingAbilityPointsText.Text = myCharacter.AbilityPoints.NewCharValue.ToString();
                AbilityPointsText.Text = myCharacter.AbilityPoints.PostCreateValue.ToString();
            }
        }

        private void DexterityAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (RaceSelextBox.SelectedItem != null && BaseClassSelectBox.SelectedItem != null)
            {
                //if (myCharacter.Dexterity.Add(1))
                //{
                //    //myCharacter.AbilityPoints.Subtract(1);
                //}
                DexterityText.Text = myCharacter.Dexterity.ToString();
                StartingAbilityPointsText.Text = myCharacter.AbilityPoints.NewCharValue.ToString();
                AbilityPointsText.Text = myCharacter.AbilityPoints.PostCreateValue.ToString();
            }
        }

        private void DexteritySubButton_Click(object sender, RoutedEventArgs e)
        {
            if (RaceSelextBox.SelectedItem != null && BaseClassSelectBox.SelectedItem != null)
            {
                //if (myCharacter.Dexterity.Subtract(1))
                //{
                //    //myCharacter.AbilityPoints.Add(1);
                //}
                DexterityText.Text = myCharacter.Dexterity.ToString();
                StartingAbilityPointsText.Text = myCharacter.AbilityPoints.NewCharValue.ToString();
                AbilityPointsText.Text = myCharacter.AbilityPoints.PostCreateValue.ToString();
            }
        }

        private void ConstitutionAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (RaceSelextBox.SelectedItem != null && BaseClassSelectBox.SelectedItem != null)
            {
                //if (myCharacter.Constitution.Add(1))
                //{
                //    //myCharacter.AbilityPoints.Subtract(1);
                //}
                ConstitutionText.Text = myCharacter.Constitution.ToString();
                StartingAbilityPointsText.Text = myCharacter.AbilityPoints.NewCharValue.ToString();
                AbilityPointsText.Text = myCharacter.AbilityPoints.PostCreateValue.ToString();
            }
        }

        private void ConstitutionSubButton_Click(object sender, RoutedEventArgs e)
        {
            if (RaceSelextBox.SelectedItem != null && BaseClassSelectBox.SelectedItem != null)
            {
                //if (myCharacter.Constitution.Subtract(1))
                //{
                //    //myCharacter.AbilityPoints.Add(1);
                //}
                ConstitutionText.Text = myCharacter.Constitution.ToString();
                StartingAbilityPointsText.Text = myCharacter.AbilityPoints.NewCharValue.ToString();
                AbilityPointsText.Text = myCharacter.AbilityPoints.PostCreateValue.ToString();
            }
        }

        private void IntelligenceAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (RaceSelextBox.SelectedItem != null && BaseClassSelectBox.SelectedItem != null)
            {
                //if (myCharacter.Intelligence.Add(1))
                //{
                //   // myCharacter.AbilityPoints.Subtract(1);
                //}
                IntelligenceText.Text = myCharacter.Intelligence.ToString();
                StartingAbilityPointsText.Text = myCharacter.AbilityPoints.NewCharValue.ToString();
                AbilityPointsText.Text = myCharacter.AbilityPoints.PostCreateValue.ToString();
            }
        }

        private void IntelligenceSubButton_Click(object sender, RoutedEventArgs e)
        {
            if (RaceSelextBox.SelectedItem != null && BaseClassSelectBox.SelectedItem != null)
            {
                //if (myCharacter.Intelligence.Subtract(1))
                //{
                //   // myCharacter.AbilityPoints.Add(1);
                //}
                IntelligenceText.Text = myCharacter.Intelligence.ToString();
                StartingAbilityPointsText.Text = myCharacter.AbilityPoints.NewCharValue.ToString();
                AbilityPointsText.Text = myCharacter.AbilityPoints.PostCreateValue.ToString();
            }
        }

        private void SpiritAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (RaceSelextBox.SelectedItem != null && BaseClassSelectBox.SelectedItem != null)
            {
                //if (myCharacter.Spirit.Add(1))
                //{
                //  //  myCharacter.AbilityPoints.Subtract(1);
                //}
                SpiritText.Text = myCharacter.Spirit.ToString();
                StartingAbilityPointsText.Text = myCharacter.AbilityPoints.NewCharValue.ToString();
                AbilityPointsText.Text = myCharacter.AbilityPoints.PostCreateValue.ToString();
            }
        }

        private void SpiritSubButton_Click(object sender, RoutedEventArgs e)
        {
            if (RaceSelextBox.SelectedItem != null && BaseClassSelectBox.SelectedItem != null)
            {
                //if (myCharacter.Spirit.Subtract(1))
                //{
                // //   myCharacter.AbilityPoints.Add(1);
                //}
                SpiritText.Text = myCharacter.Spirit.ToString();
                StartingAbilityPointsText.Text = myCharacter.AbilityPoints.NewCharValue.ToString();
                AbilityPointsText.Text = myCharacter.AbilityPoints.PostCreateValue.ToString();
            }
        }
        #endregion
    }
}
