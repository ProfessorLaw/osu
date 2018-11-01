// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using System;
using osu.Framework.Timing;
using osu.Game.Graphics;

namespace osu.Game.Rulesets.Mods
{
    public abstract class ModPractice : Mod, IApplicableToClock
    {
        public override string Name => "Practice";
        public override string ShortenedName => "PT";
        public override FontAwesome Icon => FontAwesome.fa_graduation_cap;
        public override ModType Type => ModType.Fun;
        public override string Description => "Let's train...";
        public override bool Ranked => false;
        public override Type[] IncompatibleMods => new[] { typeof(ModDoubleTime), typeof(ModHalfTime) };

        public virtual void ApplyToClock(IAdjustableClock clock)
        {
            clock.Rate = 0.9;
        }
    }
}
