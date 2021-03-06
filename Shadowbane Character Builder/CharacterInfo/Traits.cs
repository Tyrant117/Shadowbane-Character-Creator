﻿/*
 * V0.1, 03/23/2015
 * This is the class for governing the attributes and tool tips given to
 * Traits selected at character creation. 
 * The trait list for the trait window can be found
 * by selecting the trait window and viewing its code.
 * 
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowbane_Character_Builder.CharacterInfo
{
    /// <summary>
    /// Abstract Class for Traits. These are selected only at character creation.
    /// </summary>
    public abstract class Trait
    {
        public float Cost;
        public virtual void SetTrait(Character character) { return; }
        public virtual void RemoveTrait(Character character) { return; }

        public virtual float GetMinStatRequired() { return 0; }
        public virtual float GetMinStatRequired_2() { return 0; }
        public virtual bool isRequiredClass(Character character) { return true; }
        public virtual bool isRequiredRace(Character character) { return true; }
        public virtual bool isNotProhibitedRace(Character character) { return true; }

        public override string ToString()
        {
            return GetType().Name + " - " + Cost.ToString();
        }
        public virtual string ToTooltip() { return ""; }
    }

    #region Stat Runes
    public class Mighty : Trait
    {
        float Str;
        float MaxStr;
        float MinReqStr;
        public Mighty()
        {
            Str = 5;
            MaxStr = 5;
            MinReqStr = 40;
            Cost = 6;
        }

        public override void SetTrait(Character character)
        {
            character.Strength.Max += MaxStr;
            character.Strength.Add(Str);
            character.hasStrengthRune = true;
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override void RemoveTrait(Character character)
        {
            character.Strength.Subtract(Str);
            character.Strength.SubtractMax(MaxStr);
            character.hasStrengthRune = false;
            character.AbilityPoints.AddNew(Cost);
        }

        public override float GetMinStatRequired()
        {
            return MinReqStr;
        }

        public override string ToTooltip()
        {
            return "Mighty\n" +
                "Effects:\n" +
                "Strength Rune\n" +
                "+5 to Str\n" +
                "+5 to max Str\n"+
                "Min Str: 40";
        }
    }
    public class HerosStrength : Trait
    {
        float Str;
        float MaxStr;
        float MinReqStr;
        public HerosStrength()
        {
            Str = 10;
            MaxStr = 10;
            MinReqStr = 50;
            Cost = 12;
        }

        public override void SetTrait(Character character)
        {
            character.Strength.Max += MaxStr;
            character.Strength.Add(Str);
            character.hasStrengthRune = true;
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override void RemoveTrait(Character character)
        {
            character.Strength.Subtract(Str);
            character.Strength.SubtractMax(MaxStr);
            character.hasStrengthRune = false;
            character.AbilityPoints.AddNew(Cost);
        }

        public override float GetMinStatRequired()
        {
            return MinReqStr;
        }

        public override string ToTooltip()
        {
            return "Hero's Strength\n" +
                "Effects:\n" +
                "Strength Rune\n" +
                "+10 to Str\n" +
                "+10 to max Str\n" +
                "Min Str: 50";
        }
    }

    public class Hearty : Trait
    {
        float Con;
        float MaxCon;
        float MinReqCon;
        public Hearty()
        {
            Con = 5;
            MaxCon = 5;
            MinReqCon = 40;
            Cost  = 6;
        }

        public override void SetTrait(Character character)
        {
            character.Constitution.Max += MaxCon;
            character.Constitution.Add(Con);
            character.hasConstitutionRune = true;
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override void RemoveTrait(Character character)
        {
            character.Constitution.Subtract(Con);
            character.Constitution.SubtractMax(MaxCon);
            character.hasConstitutionRune = false;
            character.AbilityPoints.AddNew(Cost);
        }

        public override float GetMinStatRequired()
        {
            return MinReqCon;
        }

        public override string ToTooltip()
        {
            return "Hearty\n" +
                "Effects:\n" +
                "Constitution Rune\n" +
                "+5 to Con\n" +
                "+5 to max Con\n" +
                "Min Con: 40";
        }
    }
    public class HealthyAsAnOx : Trait
    {
        float Con;
        float MaxCon;
        float MinReqCon;
        public HealthyAsAnOx()
        {
            Con = 10;
            MaxCon = 10;
            MinReqCon = 50;
            Cost  = 12;
        }

        public override void SetTrait(Character character)
        {
            character.Constitution.Max += MaxCon;
            character.Constitution.Add(Con);
            character.hasConstitutionRune = true;
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override void RemoveTrait(Character character)
        {
            character.Constitution.Subtract(Con);
            character.Constitution.SubtractMax(MaxCon);
            character.hasConstitutionRune = false;
            character.AbilityPoints.AddNew(Cost);
        }

        public override float GetMinStatRequired()
        {
            return MinReqCon;
        }

        public override string ToTooltip()
        {
            return "Healthy as an Ox\n" +
                "Effects:\n" +
                "Constitution Rune\n" +
                "+10 to Con\n" +
                "+10 to max Con\n" +
                "Min Con: 50";
        }
    }

    public class Agile : Trait
    {
        float Dex;
        float MaxDex;
        public float MinRequiredDex;
        public Agile()
        {
            Dex = 5;
            MaxDex = 5;
            MinRequiredDex = 40;
            Cost  = 6;
        }

        public override void SetTrait(Character character)
        {
            character.Dexterity.Max += MaxDex;
            character.Dexterity.Add(Dex);
            character.hasDexterityRune = true;
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override void RemoveTrait(Character character)
        {
            character.Dexterity.Subtract(Dex);
            character.Dexterity.SubtractMax(MaxDex);
            character.hasDexterityRune = false;
            character.AbilityPoints.AddNew(Cost);
        }

        public override float GetMinStatRequired()
        {
            return MinRequiredDex;
        }

        public override string ToTooltip()
        {
            return "Agile\n" +
                "Effects:\n" +
                "Dexterity Rune\n" +
                "+5 to Dex\n" +
                "+5 to max Dex\n" +
                "Min Dex: 40";
        }
    }
    public class LightningReflexes : Trait
    {
        float Dex;
        float MaxDex;
        float MinReqDex;
        public LightningReflexes()
        {
            Dex = 10;
            MaxDex = 10;
            MinReqDex = 50;
            Cost  = 12;
        }

        public override void SetTrait(Character character)
        {
            character.Dexterity.Max += MaxDex;
            character.Dexterity.Add(Dex);
            character.hasDexterityRune = true;
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override void RemoveTrait(Character character)
        {
            character.Dexterity.Subtract(Dex);
            character.Dexterity.SubtractMax(MaxDex);
            character.hasDexterityRune = false;
            character.AbilityPoints.AddNew(Cost);
        }

        public override float GetMinStatRequired()
        {
            return MinReqDex;
        }

        public override string ToTooltip()
        {
            return "Lightning Reflexes\n" +
                "Effects:\n" +
                "Dexterity Rune\n" +
                "+10 to Dex\n" +
                "+10 to max Dex" +
                "Min Dex: 50";
        }
    }

    public class Clever : Trait
    {
        float Int;
        float MaxInt;
        float MinReqInt;
        public Clever()
        {
            Int = 5;
            MaxInt = 5;
            MinReqInt = 40;
            Cost  = 6;
        }

        public override void SetTrait(Character character)
        {
            character.Intelligence.Max += MaxInt;
            character.Intelligence.Add(Int);
            character.hasIntelligenceRune = true;
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override void RemoveTrait(Character character)
        {
            character.Intelligence.Subtract(Int);
            character.Intelligence.SubtractMax(MaxInt);
            character.hasIntelligenceRune = false;
            character.AbilityPoints.AddNew(Cost);
        }

        public override float GetMinStatRequired()
        {
            return MinReqInt;
        }

        public override string ToTooltip()
        {
            return "Clever\n" +
                "Effects:\n" +
                "Intelligence Rune\n" +
                "+5 to Int\n" +
                "+5 to max Int\n" +
                "Min Int: 40";
        }
    }
    public class BrilliantMind : Trait
    {
        float Int;
        float MaxInt;
        float MinReqInt;
        public BrilliantMind()
        {
            Int = 10;
            MaxInt = 10;
            MinReqInt = 50;
            Cost  = 12;
        }

        public override void SetTrait(Character character)
        {
            character.Intelligence.Max += MaxInt;
            character.Intelligence.Add(Int);
            character.hasIntelligenceRune = true;
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override void RemoveTrait(Character character)
        {
            character.Intelligence.Subtract(Int);
            character.Intelligence.SubtractMax(MaxInt);
            character.hasIntelligenceRune = false;
            character.AbilityPoints.AddNew(Cost);
        }

        public override float GetMinStatRequired()
        {
            return MinReqInt;
        }

        public override string ToTooltip()
        {
            return "Brilliant Mind\n" +
                "Effects:\n" +
                "Intelligence Rune\n" +
                "+10 to Int\n" +
                "+10 to max Int\n" +
                "Min Int: 50";
        }
    }

    public class TrueFaith : Trait
    {
        float Spi;
        float MaxSpi;
        float MinReqSpi;
        public TrueFaith()
        {
            Spi = 5;
            MaxSpi = 5;
            MinReqSpi = 40;
            Cost  = 6;
        }

        public override void SetTrait(Character character)
        {
            character.Spirit.Max += MaxSpi;
            character.Spirit.Add(Spi);
            character.hasSpiritRune = true;
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override void RemoveTrait(Character character)
        {
            character.Spirit.Subtract(Spi);
            character.Spirit.SubtractMax(MaxSpi);
            character.hasSpiritRune = false;
            character.AbilityPoints.AddNew(Cost);
        }

        public override float GetMinStatRequired()
        {
            return MinReqSpi;
        }

        public override string ToTooltip()
        {
            return "True Faith\n" +
                "Effects:\n" +
                "Spirit Rune\n" +
                "+5 to Spi\n" +
                "+5 to max Spi\n" +
                "Min Spi: 40";
        }
    }
    public class FaithOfAges : Trait
    {
        float Spi;
        float MaxSpi;
        float MinReqSpi;
        public FaithOfAges()
        {
            Spi = 10;
            MaxSpi = 10;
            MinReqSpi = 50;
            Cost  = 12;
        }

        public override void SetTrait(Character character)
        {
            character.Spirit.Max += MaxSpi;
            character.Spirit.Add(Spi);
            character.hasSpiritRune = true;
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override void RemoveTrait(Character character)
        {
            character.Spirit.Subtract(Spi);
            character.Spirit.SubtractMax(MaxSpi);
            character.hasSpiritRune = false;
            character.AbilityPoints.AddNew(Cost);
        }

        public override float GetMinStatRequired()
        {
            return MinReqSpi;
        }

        public override string ToTooltip()
        {
            return "Faith of Ages\n" +
                "Effects:\n" +
                "Spirit Rune\n" +
                "+10 to Spi\n" +
                "+10 to max Spi\n" +
                "Min Spi: 50";
        }
    }
    #endregion

    #region Apprentice Runes

    public class BlacksmithsApprentice : Trait
    {
        float Str;
        float Dex;
        float Int;
        float MaxStr;
        float MaxDex;
        float MaxInt;
        public float MinRequiredStr;

        public BlacksmithsApprentice()
        {
            Str = 10;
            MaxStr = 10;
            Dex = -5;
            MaxDex = -5;
            Int = -5;
            MaxInt = -5;
            MinRequiredStr = 40;
            Cost  = 8;
        }

        public override void SetTrait(Character character)
        {
            character.Strength.Max += MaxStr;
            character.Dexterity.Max += MaxDex;
            character.Intelligence.Max += MaxInt;

            character.Strength.Add(Str);
            character.Dexterity.Add(Dex);
            character.Intelligence.Add(Int);
            character.hasApprenticeRune = true;
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override float GetMinStatRequired()
        {
            return MinRequiredStr;
        }
    }

    public class PriestsAcolyte : Trait
    {
        float Str;
        float Spi;
        float Int;
        float MaxStr;
        float MaxSpi;
        float MaxInt;
        public float MinRequiredSpi;

        public PriestsAcolyte()
        {
            Str = -5;
            MaxStr = -5;
            Spi = 10;
            MaxSpi = 10;
            Int = -5;
            MaxInt = -5;
            MinRequiredSpi = 40;
            Cost  = 8;
        }

        public override void SetTrait(Character character)
        {
            character.Strength.Max += MaxStr;
            character.Spirit.Max += MaxSpi;
            character.Intelligence.Max += MaxInt;

            character.Strength.Add(Str);
            character.Spirit.Add(Spi);
            character.Intelligence.Add(Int);
            character.hasApprenticeRune = true;
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override float GetMinStatRequired()
        {
            return MinRequiredSpi;
        }
    }

    public class WarlordsPage : Trait
    {
        float Con;
        float Dex;
        float Spi;
        float MaxCon;
        float MaxDex;
        float MaxSpi;
        public float MinRequiredCon;

        public WarlordsPage()
        {
            Con = 10;
            MaxCon = 10;
            Dex = -5;
            MaxDex = -5;
            Spi = -5;
            MaxSpi = -5;
            MinRequiredCon = 40;
            Cost  = 8;
        }

        public override void SetTrait(Character character)
        {
            character.Constitution.Max += MaxCon;
            character.Dexterity.Max += MaxDex;
            character.Spirit.Max += MaxSpi;

            character.Constitution.Add(Con);
            character.Dexterity.Add(Dex);
            character.Spirit.Add(Spi);
            character.hasApprenticeRune = true;
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override float GetMinStatRequired()
        {
            return MinRequiredCon;
        }
    }

    public class WizardsApprentice : Trait
    {
        float Con;
        float Int;
        float Spi;
        float MaxCon;
        float MaxInt;
        float MaxSpi;
        public float MinRequiredInt;

        public WizardsApprentice()
        {
            Con = -5;
            MaxCon = -5;
            Int = 10;
            MaxInt = 10;
            Spi = -5;
            MaxSpi = -5;
            MinRequiredInt = 40;
            Cost  = 8;
        }

        public override void SetTrait(Character character)
        {
            character.Constitution.Max += MaxCon;
            character.Intelligence.Max += MaxInt;
            character.Spirit.Max += MaxSpi;

            character.Constitution.Add(Con);
            character.Intelligence.Add(Int);
            character.Spirit.Add(Spi);
            character.hasApprenticeRune = true;
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override float GetMinStatRequired()
        {
            return MinRequiredInt;
        }
    }

    public class TaughtByMasterThief : Trait
    {
        float Str;
        float Dex;
        float Con;
        float MaxStr;
        float MaxDex;
        float MaxCon;
        public float MinRequiredDex;

        public TaughtByMasterThief()
        {
            Str = -5;
            MaxStr = -5;
            Dex = 10;
            MaxDex = 10;
            Con = -5;
            MaxCon = -5;
            MinRequiredDex = 40;
            Cost  = 8;
        }

        public override void SetTrait(Character character)
        {
            character.Strength.Max += MaxStr;
            character.Dexterity.Max += MaxDex;
            character.Constitution.Max += MaxCon;

            character.Strength.Add(Str);
            character.Dexterity.Add(Dex);
            character.Constitution.Add(Con);
            character.hasApprenticeRune = true;
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override float GetMinStatRequired()
        {
            return MinRequiredDex;
        }
    }

    #endregion

    public class Ambidexterity : Trait
    {
        public float MinRequiredDex;

        public Ambidexterity()
        {
            MinRequiredDex = 50;
            Cost  = 12;
        }

        public override void SetTrait(Character character)
        {
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override float GetMinStatRequired()
        {
            return MinRequiredDex;
        }

        public override bool isRequiredClass(Character character)
        {
            if (character.myBaseClass.baseType == BaseClass.ClassType.Fighter)
            {
                return true;
            }
            else { return false; }
        }

        public override string ToTooltip()
        {
            return "Ambidexterity\n" + 
                "Grants the ability to wield two weapons" +
                "Min Dex Req: 50 ";
        }
    }

    public class Blessed : Trait //TODO Implement
    {
        public override string ToTooltip()
        {
            return "Blessed \n" +
                "Grants +5 holy resist";
        }
    }

    public class BloodOfTheDesert : Trait // TODO Implement
    {
        public override string ToTooltip()
        {
            return "Blood of The Desert \n" +
                "Grants +5 fire resist";
        }
    }

    public class BloodOfTheNorth : Trait // TODO Implement
    {
        public override string ToTooltip()
        {
            return "Blood of the North \n" +
                "Grants +5 Cold resist";
        }
    }

    public class BloodOfTheCountry : Trait // TODO Implement
    {
        public override string ToTooltip()
        {
            return "Blessed \n" +
                "Grants +5 holy resist";
        }
    }

    public class BornInTheCountry : Trait // TODO Implement
    {
        public override string ToTooltip()
        {
            return "Born in The Country \n" +
                "Grants +5 Staff skill";
        }
    }

    #region Subrace

    public class BornOfTheEthyri : Trait
    {
        float Spi;
        float MaxSpi;

        public BornOfTheEthyri()
        {
            Spi = 5;
            MaxSpi = 10;
            Cost  = 10;
        }

        public override void SetTrait(Character character)
        {
            character.Spirit.Max += MaxSpi;
            character.Spirit.Add(Spi);
            character.hasSubrace = true;
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override bool isRequiredRace(Character character)
        {
            if (character.myRace.raceType == Race.RaceEnum.Human)
            {
                return true;
            }
            else { return false; }
        }
    }

    public class BornOfTheGwendannen : Trait
    {
        float Con;
        float MaxCon;

        public BornOfTheGwendannen()
        {
            Con = 5;
            MaxCon = 10;
            Cost  = 10;
        }

        public override void SetTrait(Character character)
        {
            character.Constitution.Max += MaxCon;
            character.Constitution.Add(Con);
            character.hasSubrace = true;
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override bool isRequiredRace(Character character)
        {
            if (character.myRace.raceType == Race.RaceEnum.Human)
            {
                return true;
            }
            else { return false; }
        }
    }

    public class BornOfTheInvorri : Trait
    {
        float Str;
        float MaxStr;

        public BornOfTheInvorri()
        {
            Str = 5;
            MaxStr = 10;
            Cost  = 10;
        }

        public override void SetTrait(Character character)
        {
            character.Strength.Max += MaxStr;
            character.Strength.Add(Str);
            character.hasSubrace = true;
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override bool isRequiredRace(Character character)
        {
            if (character.myRace.raceType == Race.RaceEnum.Human)
            {
                return true;
            }
            else { return false; }
        }
    }

    public class BornOfTheIrydnu : Trait
    {
        float Int;
        float MaxInt;

        public BornOfTheIrydnu()
        {
            Int = 5;
            MaxInt = 10;
            Cost  = 10;
        }

        public override void SetTrait(Character character)
        {
            character.Intelligence.Max += MaxInt;
            character.Intelligence.Add(Int);
            character.hasSubrace = true;
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override bool isRequiredRace(Character character)
        {
            if (character.myRace.raceType == Race.RaceEnum.Human)
            {
                return true;
            }
            else { return false; }
        }
    }

    public class BornOfTheTaripontor : Trait
    {
        float Dex;
        float MaxDex;

        public BornOfTheTaripontor()
        {
            Dex = 5;
            MaxDex = 10;
            Cost  = 10;
        }

        public override void SetTrait(Character character)
        {
            character.Dexterity.Max += MaxDex;
            character.Dexterity.Add(Dex);
            character.hasSubrace = true;
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override bool isRequiredRace(Character character)
        {
            if (character.myRace.raceType == Race.RaceEnum.Human)
            {
                return true;
            }
            else { return false; }
        }
    }

    #endregion

    public class BowyerBorn : Trait // TODO Implement
    {
        public override string ToTooltip()
        {
            return "Bowyer Born\n" +
                "Grants +5 bow skill";
        }
    }

    public class Brawler : Trait // TODO Implement
    {
        public override string ToTooltip()
        {
            return "Brawler\n" +
                "Grants +10 Unarmed Combat Skill" +
                "Grants the Unarmed Combat Skill";
        }
    }

    public class Bruiser : Trait // TODO Implement
    {
        public override string ToTooltip()
        {
            return "Bruiser\n" +
                "Grants +5 Hammer Skill";
        }
    }

    public class Changeling : Trait //TODO Implement
    {
        public override string ToTooltip()
        {
            return "Changeling\n" +
                "Grants +5 magic resist";
        }
    }

    public class EyesOfTheEagle : Trait //TODO Implement
    {

    }

    public class FleetOfFoot : Trait
    {
        public float MinRequiredDex;

        public FleetOfFoot()
        {
            MinRequiredDex = 50;
            Cost  = 10;
        }

        public override void SetTrait(Character character)
        {
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override float GetMinStatRequired()
        {
            return MinRequiredDex;
        }

        public override bool isNotProhibitedRace(Character character)
        {
            if (character.myRace.raceType == Race.RaceEnum.Centaur)
            {
                return false;
            }
            else { return true; }
        }

        public override string ToTooltip()
        {
            return "Fleet Of Foot\n" +
                "Effects:\n" +
                "Speed Rune\n" +
                "+5% to Movement Speed\n";
        }
    }

    public class GiantsBlood : Trait
    {
        float Str;
        float Dex;
        float Con;
        float Int;
        float MaxStr;
        float MaxDex;
        float MaxCon;
        float MaxInt;

        float MinReqStr;
        float MinReqCon;

        public GiantsBlood()
        {
            Str = 10;
            MaxStr = 15;
            Dex = -5;
            MaxDex = -10;
            Con = 5;
            MaxCon = 10;
            Int = -5;
            MaxInt = -10;
        }

        public override void SetTrait(Character character)
        {
            character.Strength.Max += MaxStr;
            character.Strength.Add(Str);
            character.Constitution.Max += MaxCon;
            character.Constitution.Add(Con);
            character.Dexterity.Max += MaxDex;
            character.Dexterity.Add(Dex);
            character.Intelligence.Max += MaxInt;
            character.Intelligence.Add(Int);
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override float GetMinStatRequired()
        {
            return MinReqStr;
        }
        public override float GetMinStatRequired_2()
        {
            return MinReqCon;
        }

        public override bool isRequiredRace(Character character)
        {
            if (character.myRace.raceType == Race.RaceEnum.Human || character.myRace.raceType == Race.RaceEnum.Shade || character.myRace.raceType == Race.RaceEnum.Aelfborn)
            {
                return true;
            }
            else { return false; }
        }

        public override string ToTooltip()
        {
            return "Giant's Blood\n" +
                "Effects:\n" +
                "Racial Rune\n" +
                "+10 to Str\n" +
                "+15 max Str\n" +
                "-5 Dex\n" +
                "-10 max Dex" +
                "+5 Con\n" +
                "+10 max Con\n"+
                "-5 Int\n" +
                "-10 to max Int";
        }
    }

    public class Hunter : Trait // TODO Implement
    {
        public override string ToTooltip()
        {
            return "Hunter\n" +
                "Grants +5 Spear Skill";
        }
    }

    #region Small Stats
    public class IncreasedConstitution : Trait
    {
        float Value;
        float Max;
        public IncreasedConstitution()
        {
            Value = 1;
            Max = 3;
            Cost = 2;
        }

        public override void SetTrait(Character character)
        {
            character.Constitution.Max += Max;
            character.Constitution.Add(Value);
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override void RemoveTrait(Character character)
        {
            character.Constitution.Subtract(Value);
            character.Constitution.Max -= Max;
            character.AbilityPoints.AddNew(Cost);
        }
    }
    public class IncreasedDexterity : Trait
    {
        float Value;
        float Max;
        public IncreasedDexterity()
        {
            Value = 1;
            Max = 3;
            Cost = 2;
        }

        public override void SetTrait(Character character)
        {
            character.Dexterity.Max += Max;
            character.Dexterity.Add(Value);
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override void RemoveTrait(Character character)
        {
            character.Dexterity.Subtract(Value);
            character.Dexterity.Max -= Max;
            character.AbilityPoints.AddNew(Cost);
        }
    }
    public class IncreasedIntelligence : Trait
    {
        float Value;
        float Max;
        public IncreasedIntelligence()
        {
            Value = 1;
            Max = 3;
            Cost = 2;
        }

        public override void SetTrait(Character character)
        {
            character.Intelligence.Max += Max;
            character.Intelligence.Add(Value);
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override void RemoveTrait(Character character)
        {
            character.Intelligence.Subtract(Value);
            character.Intelligence.Max -= Max;
            character.AbilityPoints.AddNew(Cost);
        }
    }
    public class IncreasedSpirit : Trait
    {
        float Value;
        float Max;
        public IncreasedSpirit()
        {
            Value = 1;
            Max = 3;
            Cost = 2;
        }

        public override void SetTrait(Character character)
        {
            character.Spirit.Max += Max;
            character.Spirit.Add(Value);
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override void RemoveTrait(Character character)
        {
            character.Spirit.Subtract(Value);
            character.Spirit.Max -= Max;
            character.AbilityPoints.AddNew(Cost);
        }
    }
    public class IncreasedStrength : Trait
    {
        float Value;
        float Max;
        public IncreasedStrength()
        {
            Value = 1;
            Max = 3;
            Cost  = 2;
        }

        public override void SetTrait(Character character)
        {
            character.Strength.Max += Max;
            character.Strength.Add(Value);
            character.AbilityPoints.SubtractNew(Cost);
        }

        public override void RemoveTrait(Character character)
        {
            character.Strength.Subtract(Value);
            character.Strength.Max -= Max;
            character.AbilityPoints.AddNew(Cost);
        }
    }
    #endregion

    public class IronWill : Trait //TODO Implement
    {
        public override string ToTooltip()
        {
            return "Iron Will \n" +
                "Grants +5 Mental Resist";
        }
    }

    public class KnifeFighter : Trait // TODO Implement
    {
        public override string ToTooltip()
        {
            return "Knife Fighter\n" +
                "Grants +5 Dagger Skill";
        }
    }

    public class KnightsSquire : Trait // TODO Implement
    {
        public override string ToTooltip()
        {
            return "Knight's Squire\n" +
                "Grants +5 Medium Armor Skill";
        }
    }

    public class Lucky : Trait //TODO Implement
    {
        public override string ToTooltip()
        {
            return "lucky \n" +
                "Grants +5% Defense Rating";
        }
    }

    public class Mercenary : Trait // TODO Implement
    {
        public override string ToTooltip()
        {
            return "Mercenary\n" +
                "Grants +5 Pole Arm Skill";
        }
    }

    public class MilitaryTraining : Trait // TODO Implement
    {
        public override string ToTooltip()
        {
            return "Military Training\n" +
                "Grants +5 Light Armor Skill";
        }
    }

    public class Precise : Trait // TODO Implement
    {
        public override string ToTooltip()
        {
            return "Precise\n" +
                "Grants +5% Attack Rating";
        }
    }

    public class ProficientWithCrossbows : Trait //TODO Implement
    {
        public override string ToTooltip()
        {
            return "Proficient With Crossbows\n" +
                "Grants Crossbow Skill";
        }
    }

    public class ProficientWithPoleArms : Trait //TODO Implement
    {
        public override string ToTooltip()
        {
            return "Proficient With Pole Arms\n" +
                "Grants Pole Arm Skill";
        }
    }

    public class ProficientWithSpears : Trait //TODO Implement
    {
        public override string ToTooltip()
        {
            return "Proficient With Spears\n" +
                "Grants Spear Skill";
        }
    }

    public class ProficientWithStaves : Trait //TODO Implement
    {
        public override string ToTooltip()
        {
            return "Proficient With Staves\n" +
                "Grants Staff Skill";
        }
    }

    public class RaisedByBarbarians : Trait // TODO Implement
    {
        public override string ToTooltip()
        {
            return "Raised By Barbarians\n" +
                "Grants +5 Axe Skill";
        }
    }

    public class RaisedByCentaurs : Trait // TODO Implement
    {
        public override string ToTooltip()
        {
            return "Raised By Centaurs\n" +
                "Grants +5 Spear Skill";
        }
    }

    public class RaisedByDwarves : Trait // TODO Implement
    {

    }

    public class RaisedByElves : Trait // TODO Implement
    {

    }

    public class RaisedByThieves : Trait // TODO Implement
    {

    }

    public class RaisedInTheWoods : Trait // TODO Implement
    {

    }

    public class Sellsword : Trait // TODO Implement
    {

    }

    public class Sharpshooter : Trait // TODO Implement
    {

    }

    public class ShopKeepersApprentice : Trait // TODO Implement
    {

    }

    public class SnakeHandler : Trait // TODO Implement
    {

    }

    public class SoldToThePits : Trait // TODO Implement
    {

    }

    public class SoldierBorn : Trait // TODO Implement
    {

    }

    public class Stormborn : Trait // TODO Implement
    {

    }

    public class TaintOfMadness : Trait // TODO Implement
    {

    }

    public class TaughtByBlademaster : Trait // TODO Implement
    {

    }

    public class Tireless : Trait //TODO Implement
    {

    }

    public class ToughAsNails : Trait// TODO Implement
    {

    }

    public class ToughHide : Trait // TODO Implement
    {

    }

    public class TrainedByMasterOfArms : Trait // TODO Implement
    {

    }

    public class Wanderer : Trait // TODO Implement
    {

    }

    public class WitchSight : Trait // TODO Implement
    {

    }

    public class Woodsman : Trait // TODO Implement
    {

    }
}
