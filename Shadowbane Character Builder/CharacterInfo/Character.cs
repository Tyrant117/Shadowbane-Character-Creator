using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowbane_Character_Builder.CharacterInfo
{
    /// <summary>
    /// Default Character Class.
    /// </summary>
    public class Character
    {
        public Race myRace;
        public BaseClass myBaseClass;

        #region Rune Bools - These are the runes that are checked at character creation, so you can't have multiple.
        public bool hasApprenticeRune;
        public bool hasSubrace;
        public bool hasChildhoodRune;
        public bool hasBackgroundRune;
        public bool hasMentorRune;
        public bool hasIntelligenceRune;
        public bool hasSpiritRune;
        public bool hasConstitutionRune;
        public bool hasStrengthRune;
        public bool hasDexterityRune;
        #endregion

        public float Health { get; set; }
        public float Mana { get; set; }
        public float Stamina { get; set; }

        public float TrainingPoints { get; set; }
        public StatAbilityPoints AbilityPoints;

        public StatStrength Strength;
        public StatDexterity Dexterity;
        public StatConstitution Constitution;
        public StatIntelligence Intelligence;
        public StatSpirit Spirit;

        public Trait[] Traits = new Trait[8];

        public Character()
        {
            AbilityPoints.PostCreateMax = 151;
            AbilityPoints.PostCreateValue = AbilityPoints.PostCreateMax;
        }
        public Character(Race newRace, BaseClass newBaseClass)
        {
            AbilityPoints.PostCreateMax = 151;
            AbilityPoints.PostCreateValue = AbilityPoints.PostCreateMax;
            myRace = newRace;
            myRace.SetStartingStats(this);
            myBaseClass = newBaseClass;
            if (myRace.raceType == Race.RaceEnum.Human)
            {
                TrainingPoints = myBaseClass.SetTrainingPoints(true);
            }
            else
            {
                TrainingPoints = myBaseClass.SetTrainingPoints(false);
            }
            myBaseClass.SetStats(this);
        }

        /// <summary>
        /// Set the race of the character.
        /// </summary>
        /// <param name="newRace"></param>
        public void SetNewRace(Race newRace)
        {
            myRace = null;
            myRace = newRace;
            myRace.SetStartingStats(this);
        }

        /// <summary>
        /// Set the base class of the character.
        /// </summary>
        /// <param name="newBaseClass"></param>
        public void SetNewBaseClass(BaseClass newBaseClass)
        {
            myBaseClass = null;
            myBaseClass = newBaseClass;
            if (myRace.raceType == Race.RaceEnum.Human)
            {
                TrainingPoints = myBaseClass.SetTrainingPoints(true);
            }
            else
            {
                TrainingPoints = myBaseClass.SetTrainingPoints(false);
            }
            myBaseClass.SetStats(this);
        }

    }

    public struct StatStrength
    {

        public float Min;
        public float Value;
        public float Max;

        public bool canAdd(float val)
        {
            if (Value + val <= Max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Add(float val)
        {
            if (Value + val <= Max)
            {
                Value += val;
            }
        }
        public void AddMax(float val)
        {
            Max += val;
        }
        public void AddMin(float val)
        {
            Min += val;
        }

        public bool canSubtract(float val)
        {
            if (Value - val >= Min)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Subtract(float val)
        {
            if (Value - val >= 0)
            {
                Value -= val;
            }
        }
        public void SubtractMax(float val)
        {
            Max -= val;
        }
        public void SubtractMin(float val)
        {
            Min -= val;
        }

        public void SetValues(float value, float min, float max)
        {
            Min = min;
            Value = value;
            Max = max;
        }

        public override string ToString()
        {
            return Value.ToString() + " / " + Max.ToString();
        }
    }
    public struct StatDexterity
    {
        public float Min;
        public float Value;
        public float Max;

        public bool canAdd(float val)
        {
            if (Value + val <= Max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Add(float val)
        {
            if (Value + val <= Max)
            {
                Value += val;
            }
        }
        public void AddMax(float val)
        {
            Max += val;
        }
        public void AddMin(float val)
        {
            Min += val;
        }

        public bool canSubtract(float val)
        {
            if (Value - val >= Min)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Subtract(float val)
        {
            if (Value - val >= 0)
            {
                Value -= val;
            }
        }
        public void SubtractMax(float val)
        {
            Max -= val;
        }
        public void SubtractMin(float val)
        {
            Min -= val;
        }

        public void SetValues(float value, float min, float max)
        {
            Min = min;
            Value = value;
            Max = max;
        }

        public override string ToString()
        {
            return Value.ToString() + " / " + Max.ToString();
        }
    }
    public struct StatConstitution
    {
        public float Min;
        public float Value;
        public float Max;

        public bool canAdd(float val)
        {
            if (Value + val <= Max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Add(float val)
        {
            if (Value + val <= Max)
            {
                Value += val;
            }
        }
        public void AddMax(float val)
        {
            Max += val;
        }
        public void AddMin(float val)
        {
            Min += val;
        }

        public bool canSubtract(float val)
        {
            if (Value - val >= Min)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Subtract(float val)
        {
            if (Value - val >= 0)
            {
                Value -= val;
            }
        }
        public void SubtractMax(float val)
        {
            Max -= val;
        }
        public void SubtractMin(float val)
        {
            Min -= val;
        }

        public void SetValues(float value, float min, float max)
        {
            Min = min;
            Value = value;
            Max = max;
        }

        public override string ToString()
        {
            return Value.ToString() + " / " + Max.ToString();
        }
    }
    public struct StatIntelligence
    {
        public float Min;
        public float Value;
        public float Max;

        public bool canAdd(float val)
        {
            if (Value + val <= Max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Add(float val)
        {
            if (Value + val <= Max)
            {
                Value += val;
            }
        }
        public void AddMax(float val)
        {
            Max += val;
        }
        public void AddMin(float val)
        {
            Min += val;
        }

        public bool canSubtract(float val)
        {
            if (Value - val >= Min)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Subtract(float val)
        {
            if (Value - val >= 0)
            {
                Value -= val;
            }
        }
        public void SubtractMax(float val)
        {
            Max -= val;
        }
        public void SubtractMin(float val)
        {
            Min -= val;
        }

        public void SetValues(float value, float min, float max)
        {
            Min = min;
            Value = value;
            Max = max;
        }

        public override string ToString()
        {
            return Value.ToString() + " / " + Max.ToString();
        }
    }
    public struct StatSpirit
    {
        public float Min;
        public float Value;
        public float Max;

        public bool canAdd(float val)
        {
            if (Value + val <= Max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Add(float val)
        {
            if (Value + val <= Max)
            {
                Value += val;
            }
        }
        public void AddMax(float val)
        {
            Max += val;
        }
        public void AddMin(float val)
        {
            Min += val;
        }

        public bool canSubtract(float val)
        {
            if (Value - val >= Min)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Subtract(float val)
        {
            if (Value - val >= 0)
            {
                Value -= val;
            }
        }
        public void SubtractMax(float val)
        {
            Max -= val;
        }
        public void SubtractMin(float val)
        {
            Min -= val;
        }

        public void SetValues(float value, float min, float max)
        {
            Min = min;
            Value = value;
            Max = max;
        }

        public override string ToString()
        {
            return Value.ToString() + " / " + Max.ToString();
        }
    }

    public struct StatAbilityPoints
    {
        public float NewCharValue; // Value used in character creation.
        public float NewCharMax; // Max Value in character creation. 55-Cost of the Race.

        public float PostCreateValue; // Ability points after character creation.
        public float PostCreateMax; // Max ability points after character creation.

        public void AddPost(float val)
        {
            if (NewCharValue + val <= NewCharMax) { NewCharValue += val; } else { NewCharValue = NewCharMax; }
        } //TODO Incomplete

        public void SubtractPost(float val)
        {
            if (PostCreateValue - val >= 0) { PostCreateValue -= val; } else { PostCreateValue = 0; }
        } //TODO Incomplete

        public void SetStartValues(float val)
        {
            NewCharMax = val;
            NewCharValue = val;
        }  //TODO Incomplete

        public bool canAddNew(float val)
        {
            if (NewCharValue + val <= NewCharMax) { return true; } else { return false; }
        }
        public void AddNew(float val)
        {
            if (NewCharValue + val <= NewCharMax) { NewCharValue += val; } else { NewCharValue = NewCharMax; }
        }

        public bool canSubtractNew(float val)
        {
            if (NewCharValue - val >= 0) { return true; } else { return false; }
        }
        public void SubtractNew(float val)
        {
            if (NewCharValue - val >= 0) { NewCharValue -= val; } else { NewCharValue = 0; }
        }
    }
}
