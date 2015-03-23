using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowbane_Character_Builder.CharacterInfo
{
    public abstract class BaseClass
    {
        public enum ClassType {Fighter, Healer, Rogue, Mage };
        public ClassType baseType;

        public virtual float SetTrainingPoints(bool isHuman) { return 0; }
        public virtual void SetStats(Character character) { return; }

        public override string ToString()
        {
            return baseType.ToString();
        }
    }

    public class Fighter : BaseClass
    {
        public Fighter()
        {
            baseType = ClassType.Fighter;
        }

        public override float SetTrainingPoints(bool isHuman)
        {
            if (isHuman)
            {
                return 646;
            }
            else
            {
                return 588;
            }
        }

        public override void SetStats(Character character)
        {
            character.Strength.Add(5);
            character.Constitution.Add(5);
            character.Intelligence.Subtract(10);
        }
    }

    public class Healer : BaseClass
    {
        public Healer()
        {
            baseType = ClassType.Healer;
        }

        public override float SetTrainingPoints(bool isHuman)
        {
            if (isHuman)
            {
                return 704;
            }
            else
            {
                return 646;
            }
        }

        public override void SetStats(Character character)
        {
            character.Spirit.Add(5);
            character.Constitution.Add(5);
            character.Dexterity.Subtract(10);
        }
    }

    public class Rogue : BaseClass
    {
        public Rogue()
        {
            baseType = ClassType.Rogue;
        }

        public override float SetTrainingPoints(bool isHuman)
        {
            if (isHuman)
            {
                return 646;
            }
            else
            {
                return 588;
            }
        }

        public override void SetStats(Character character)
        {
            character.Dexterity.Add(5);
            character.Intelligence.Add(5);
            character.Spirit.Subtract(10);
        }
    }

    public class Mage : BaseClass
    {
        public Mage()
        {
            baseType = ClassType.Mage;
        }

        public override float SetTrainingPoints(bool isHuman)
        {
            if (isHuman)
            {
                return 704;
            }
            else
            {
                return 646;
            }
        }

        public override void SetStats(Character character)
        {
            character.Spirit.Add(5);
            character.Intelligence.Add(5);
            character.Strength.Subtract(10);
        }
    }
}
