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
            Traits.Add(new TraitControl().newControl(new Agile()));
            Traits.Add(new TraitControl().newControl(new LightningReflexes()));
            Traits.Add(new TraitControl().newControl(new Clever()));
            Traits.Add(new TraitControl().newControl(new BrilliantMind()));
            Traits.Add(new TraitControl().newControl(new TrueFaith()));
            Traits.Add(new TraitControl().newControl(new FaithOfAges()));
            Traits.Add(new TraitControl().newControl(new BlacksmithsApprentice()));
            Traits.Add(new TraitControl().newControl(new PriestsAcolyte()));
            Traits.Add(new TraitControl().newControl(new WarlordsPage()));
            Traits.Add(new TraitControl().newControl(new WizardsApprentice()));
            Traits.Add(new TraitControl().newControl(new TaughtByMasterThief()));
            Traits.Add(new TraitControl().newControl(new Ambidexterity()));
            Traits.Add(new TraitControl().newControl(new Blessed()));
            Traits.Add(new TraitControl().newControl(new BloodOfTheNorth()));
            Traits.Add(new TraitControl().newControl(new BloodOfTheCountry()));
            Traits.Add(new TraitControl().newControl(new BornInTheCountry()));
            Traits.Add(new TraitControl().newControl(new BornOfTheEthyri()));
            Traits.Add(new TraitControl().newControl(new BornOfTheGwendannen()));
            Traits.Add(new TraitControl().newControl(new BornOfTheInvorri()));
            Traits.Add(new TraitControl().newControl(new BornOfTheIrydnu()));
            Traits.Add(new TraitControl().newControl(new BornOfTheTaripontor()));
            Traits.Add(new TraitControl().newControl(new BowyerBorn()));
            Traits.Add(new TraitControl().newControl(new Brawler()));
            Traits.Add(new TraitControl().newControl(new Bruiser()));
            Traits.Add(new TraitControl().newControl(new Changeling()));
            Traits.Add(new TraitControl().newControl(new EyesOfTheEagle()));
            Traits.Add(new TraitControl().newControl(new FleetOfFoot()));
            Traits.Add(new TraitControl().newControl(new GiantsBlood()));
            Traits.Add(new TraitControl().newControl(new Hunter()));
            Traits.Add(new TraitControl().newControl(new IncreasedConstitution()));
            Traits.Add(new TraitControl().newControl(new IncreasedDexterity()));
            Traits.Add(new TraitControl().newControl(new IncreasedIntelligence()));
            Traits.Add(new TraitControl().newControl(new IncreasedSpirit()));
            Traits.Add(new TraitControl().newControl(new IncreasedStrength()));
            Traits.Add(new TraitControl().newControl(new IronWill()));
            Traits.Add(new TraitControl().newControl(new KnifeFighter()));
            Traits.Add(new TraitControl().newControl(new KnightsSquire()));
            Traits.Add(new TraitControl().newControl(new Lucky()));
            Traits.Add(new TraitControl().newControl(new Mercenary()));
            Traits.Add(new TraitControl().newControl(new MilitaryTraining()));
            Traits.Add(new TraitControl().newControl(new Precise()));
            Traits.Add(new TraitControl().newControl(new ProficientWithCrossbows()));
            Traits.Add(new TraitControl().newControl(new ProficientWithPoleArms()));
            Traits.Add(new TraitControl().newControl(new ProficientWithSpears()));
            Traits.Add(new TraitControl().newControl(new ProficientWithStaves()));
            Traits.Add(new TraitControl().newControl(new RaisedByBarbarians()));
            Traits.Add(new TraitControl().newControl(new RaisedByCentaurs()));
            Traits.Add(new TraitControl().newControl(new RaisedByDwarves()));
            Traits.Add(new TraitControl().newControl(new RaisedByElves()));
            Traits.Add(new TraitControl().newControl(new RaisedByThieves()));
            Traits.Add(new TraitControl().newControl(new RaisedInTheWoods()));
            Traits.Add(new TraitControl().newControl(new Sellsword()));
            Traits.Add(new TraitControl().newControl(new Sharpshooter()));
            Traits.Add(new TraitControl().newControl(new ShopKeepersApprentice()));
            Traits.Add(new TraitControl().newControl(new SnakeHandler()));
            Traits.Add(new TraitControl().newControl(new SoldToThePits()));
            Traits.Add(new TraitControl().newControl(new SoldierBorn()));
            Traits.Add(new TraitControl().newControl(new Stormborn()));
            Traits.Add(new TraitControl().newControl(new TaintOfMadness()));
            Traits.Add(new TraitControl().newControl(new TaughtByBlademaster()));
            Traits.Add(new TraitControl().newControl(new Tireless()));
            Traits.Add(new TraitControl().newControl(new ToughAsNails()));
            Traits.Add(new TraitControl().newControl(new ToughHide()));
            Traits.Add(new TraitControl().newControl(new TrainedByMasterOfArms()));
            Traits.Add(new TraitControl().newControl(new Wanderer()));
            Traits.Add(new TraitControl().newControl(new WitchSight()));
            Traits.Add(new TraitControl().newControl(new Woodsman()));

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
