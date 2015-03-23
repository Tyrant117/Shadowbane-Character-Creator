using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowbane_Character_Builder.CharacterInfo
{
    /// <summary>
    /// Abstract Class for Races.
    /// </summary>
    public abstract class Race
    {
        public float Cost;
        public enum RaceEnum { Human, Aelfborn, Dwarf, Elf, HalfGiant, Irekei, Shade, Aracoix, Centaur, Minotaur, Nephilim, Vampire };
        public RaceEnum raceType{get; set;}

        /// <summary>
        /// Virtual Method for setting the base stats of a race.
        /// </summary>
        /// <param name="character"></param>
        public virtual void SetStartingStats(Character character) { return; }
        public override string ToString()
        {
            return raceType.ToString();
        }
    }

    public class Human : Race
    {
        public Human()
        {
            raceType = RaceEnum.Human;
            Cost = 0;
        }

        public override void SetStartingStats(Character character)
        {
            character.AbilityPoints.SetStartValues(55 - Cost);
            character.Strength.SetValues(35, 35, 100);
            character.Strength.Value = 35;
            character.Dexterity.Value = 35;
            character.Constitution.Value = 35;
            character.Intelligence.Value = 35;
            character.Spirit.Value = 35;

            character.Dexterity.Max = 100;
            character.Constitution.Max = 100;
            character.Intelligence.Max = 100;
            character.Spirit.Max = 100;
            
        }
    }

    public class Aelfborn : Race
    {
        public Aelfborn()
        {
            raceType = RaceEnum.Aelfborn;
            Cost = 5;
        }

        public override void SetStartingStats(Character character)
        {
            character.AbilityPoints.SetStartValues(55 - Cost);
            character.Strength.SetValues(35, 35, 95);
            character.Dexterity.Value = 45;
            character.Constitution.Value = 35;
            character.Intelligence.Value = 40;
            character.Spirit.Value = 30;

            character.Dexterity.Max = 120;
            character.Constitution.Max = 95;
            character.Intelligence.Max = 105;
            character.Spirit.Max = 85;

        }
    }

    public class Dwarf : Race
    {
        public Dwarf()
        {
            raceType = RaceEnum.Dwarf;
            Cost = 15;
        }

        public override void SetStartingStats(Character character)
        {
            character.AbilityPoints.SetStartValues(55 - Cost);
            character.Strength.Value = 40;
            character.Dexterity.Value = 30;
            character.Constitution.Value = 55;
            character.Intelligence.Value = 25;
            character.Spirit.Value = 35;

            character.Strength.Max = 110;
            character.Dexterity.Max = 80;
            character.Constitution.Max = 140;
            character.Intelligence.Max = 70;
            character.Spirit.Max = 100;

        }
    }

    public class Elf : Race
    {
        public Elf()
        {
            raceType = RaceEnum.Elf;
            Cost = 15;
        }

        public override void SetStartingStats(Character character)
        {
            character.AbilityPoints.SetStartValues(55 - Cost);
            character.Strength.Value = 30;
            character.Dexterity.Value = 55;
            character.Constitution.Value = 30;
            character.Intelligence.Value = 45;
            character.Spirit.Value = 35;

            character.Strength.Max = 70;
            character.Dexterity.Max = 140;
            character.Constitution.Max = 70;
            character.Intelligence.Max = 120;
            character.Spirit.Max = 100;

        }
    }

    public class HalfGiant : Race
    {
        public HalfGiant()
        {
            raceType = RaceEnum.HalfGiant;
            Cost = 10;
        }

        public override void SetStartingStats(Character character)
        {
            character.AbilityPoints.SetStartValues(55 - Cost);
            character.Strength.Value = 55;
            character.Dexterity.Value = 35;
            character.Constitution.Value = 55;
            character.Intelligence.Value = 25;
            character.Spirit.Value = 25;

            character.Strength.Max = 150;
            character.Dexterity.Max = 65;
            character.Constitution.Max = 140;
            character.Intelligence.Max = 85;
            character.Spirit.Max = 60;

        }
    }

    public class Irekei : Race
    {
        public Irekei()
        {
            raceType = RaceEnum.Irekei;
            Cost = 15;
        }

        public override void SetStartingStats(Character character)
        {
            character.AbilityPoints.SetStartValues(55 - Cost);
            character.Strength.Value = 35;
            character.Dexterity.Value = 50;
            character.Constitution.Value = 35;
            character.Intelligence.Value = 40;
            character.Spirit.Value = 25;

            character.Strength.Max = 85;
            character.Dexterity.Max = 130;
            character.Constitution.Max = 90;
            character.Intelligence.Max = 110;
            character.Spirit.Max = 85;

        }
    }

    public class Shade : Race
    {
        public Shade()
        {
            raceType = RaceEnum.Shade;
            Cost = 10;
        }

        public override void SetStartingStats(Character character)
        {
            character.AbilityPoints.SetStartValues(55 - Cost);
            character.Strength.Value = 35;
            character.Dexterity.Value = 45;
            character.Constitution.Value = 35;
            character.Intelligence.Value = 40;
            character.Spirit.Value = 25;

            character.Strength.Max = 90;
            character.Dexterity.Max = 115;
            character.Constitution.Max = 95;
            character.Intelligence.Max = 110;
            character.Spirit.Max = 90;

        }
    }

    public class Aracoix : Race
    {
        public Aracoix()
        {
            raceType = RaceEnum.Aracoix;
            Cost = 15;
        }

        public override void SetStartingStats(Character character)
        {
            character.AbilityPoints.SetStartValues(55 - Cost);
            character.Strength.Value = 45;
            character.Dexterity.Value = 50;
            character.Constitution.Value = 40;
            character.Intelligence.Value = 30;
            character.Spirit.Value = 25;

            character.Strength.Max = 115;
            character.Dexterity.Max = 120;
            character.Constitution.Max = 105;
            character.Intelligence.Max = 85;
            character.Spirit.Max = 85;

        }
    }

    public class Centaur : Race
    {
        public Centaur()
        {
            raceType = RaceEnum.Centaur;
            Cost = 10;
        }

        public override void SetStartingStats(Character character)
        {
            character.AbilityPoints.SetStartValues(55 - Cost);
            character.Strength.Value = 40;
            character.Dexterity.Value = 30;
            character.Constitution.Value = 50;
            character.Intelligence.Value = 30;
            character.Spirit.Value = 45;

            character.Strength.Max = 110;
            character.Dexterity.Max = 85;
            character.Constitution.Max = 125;
            character.Intelligence.Max = 85;
            character.Spirit.Max = 105;

        }
    }

    public class Minotaur : Race
    {
        public Minotaur()
        {
            raceType = RaceEnum.Minotaur;
            Cost = 15;
        }

        public override void SetStartingStats(Character character)
        {
            character.AbilityPoints.SetStartValues(55 - Cost);
            character.Strength.Value = 70;
            character.Dexterity.Value = 20;
            character.Constitution.Value = 65;
            character.Intelligence.Value = 20;
            character.Spirit.Value = 20;

            character.Strength.Max = 170;
            character.Dexterity.Max = 70;
            character.Constitution.Max = 140;
            character.Intelligence.Max = 65;
            character.Spirit.Max = 65;

        }
    }

    public class Nephilim : Race
    {
        public Nephilim()
        {
            raceType = RaceEnum.Nephilim;
            Cost = 15;
        }

        public override void SetStartingStats(Character character)
        {
            character.AbilityPoints.SetStartValues(55 - Cost);
            character.Strength.Value = 50;
            character.Dexterity.Value = 10;
            character.Constitution.Value = 35;
            character.Intelligence.Value = 60;
            character.Spirit.Value = 25;

            character.Strength.Max = 140;
            character.Dexterity.Max = 60;
            character.Constitution.Max = 90;
            character.Intelligence.Max = 130;
            character.Spirit.Max = 80;

        }
    }

    public class Vampire : Race
    {
        public Vampire()
        {
            raceType = RaceEnum.Vampire;
            Cost = 25;
        }

        public override void SetStartingStats(Character character)
        {
            character.AbilityPoints.SetStartValues(55 - Cost);
            character.Strength.Value = 40;
            character.Dexterity.Value = 45;
            character.Constitution.Value = 40;
            character.Intelligence.Value = 45;
            character.Spirit.Value = 25;

            character.Strength.Max = 120;
            character.Dexterity.Max = 120;
            character.Constitution.Max = 120;
            character.Intelligence.Max = 120;
            character.Spirit.Max = 65;

        }
    }
}
