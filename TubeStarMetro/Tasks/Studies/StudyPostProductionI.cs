﻿using System;

namespace TubeStarMetro
{
    public class StudyPostProductionI : Study
    {
        public override string Name
        {
            get { return EnglishStrings.StudyPostProduction1.Translate(); }
        }

        public override Study Prerequisite
        {
            get { return null; }
        }

        public override int Cost
        {
            get { return 200; }
        }

        public override int HoursToComplete
        {
            get { return 4; }
        }

        public override int SkillModifier
        {
            get { return 5; }
        }

        public override SkillModifierType SkillModifierType
        {
            get { return SkillModifierType.PostProduction; }
        }
    }
}