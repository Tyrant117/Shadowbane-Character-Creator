using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowbane_Character_Builder.CharacterInfo
{
    /// <summary>
    /// Abstract class. This is used as a parent for the 4 main base classes. Fighter, Healer, Rogue, Mage.
    /// </summary>
    public abstract class BaseClass
    {
        public enum ClassType {Fighter, Healer, Rogue, Mage };
        public ClassType baseType;

        /// <summary>
        /// Set Max Training Points. Humans have more than other races.
        /// </summary>
        /// <param name="isHuman"></param>
        /// <returns></returns>
        public virtual float SetTrainingPoints(bool isHuman) { return 0; }
        /// <summary>
        /// Sets the bonus stats that a certain class gives.
        /// </summary>
        /// <param name="character"></param>
        public virtual void SetStats(Character character) { return; }

        public override string ToString()
        {
            return baseType.ToString();
        }
    }
    /// <summary>
    /// Fighter Base Class
    /// </summary>
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
    /// <summary>
    /// Healer Base Class
    /// </summary>
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
    /// <summary>
    /// Rogue Base Class
    /// </summary>
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
    /// <summary>
    /// Mage Base Class
    /// </summary>
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
