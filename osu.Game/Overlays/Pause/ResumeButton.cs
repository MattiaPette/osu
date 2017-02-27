﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Framework.Allocation;
using osu.Framework.Audio;
using osu.Game.Graphics;
using osu.Game.Graphics.UserInterface;

namespace osu.Game.Overlays.Pause
{
    public class ResumeButton : DialogButton
    {
        [BackgroundDependencyLoader]
        private void load(AudioManager audio, OsuColour colours)
        {
            Colour = colours.Green;
            SampleHover = audio.Sample.Get(@"Menu/menuclick");
            SampleClick = audio.Sample.Get(@"Menu/menuback");
        }

        public ResumeButton()
        {
            Text = @"Continue";
        }
    }
}
