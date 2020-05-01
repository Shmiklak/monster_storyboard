using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class Blood : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            var Position1 = new Vector2(113, 128);
            var Position2 = new Vector2(504, 219);
            var Position3 = new Vector2(148, 392);
		    
            var blood1 = GetLayer("Blood").CreateSprite("sb/etc/blood1.png", OsbOrigin.Centre, Position1);
            var blood2 = GetLayer("Blood").CreateSprite("sb/etc/blood2.png", OsbOrigin.Centre, Position2);
            var blood3 = GetLayer("Blood").CreateSprite("sb/etc/blood3.png", OsbOrigin.Centre, Position3);

            blood1.Scale(21522, 22031, 0.25, 0.25);
            blood1.Fade(21522, 0.7);
            
            blood2.Scale(21692, 22031, 0.25, 0.25);
            blood2.Fade(21692, 0.7);

            blood3.Scale(21861, 22031, 0.25, 0.25);
            blood3.Fade(21861, 0.7);
        }
    }
}
