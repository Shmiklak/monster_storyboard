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
    public class Heart : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            var flash = GetLayer("Heart").CreateSprite("sb/etc/p.png", OsbOrigin.Centre);
            flash.Scale(38302, 1000);
            flash.Fade(38302, 1);
            flash.Fade(53557, 0);
            //2
            var flash2 = GetLayer("Heart").CreateSprite("sb/etc/p.png", OsbOrigin.Centre);
            flash2.Scale(103387, 1000);
            flash2.Fade(103387, 1);
            flash2.Fade(118642, 0);

            //3
            var flash3 = GetLayer("Heart").CreateSprite("sb/etc/p.png", OsbOrigin.Centre);
            flash3.Scale(176607, 1000);
            flash3.Fade(176607, 1);
            flash3.Fade(191862, 0);

		    var heart = GetLayer("Heart").CreateSprite("sb/etc/ht.png", OsbOrigin.Centre);
            var heartCopy = GetLayer("Heart").CreateSprite("sb/etc/ht.png", OsbOrigin.Centre);
            var beat = 509;
            
            heart.Fade(38302, 1);
            heart.Fade(54573, 0);
            heart.Scale(38302, 0.3);

            heartCopy.StartLoopGroup(38302, (54573 - 38302) / beat - 1);
            heartCopy.Fade(OsbEasing.Out, 0, beat, 1, 0);
            heartCopy.Scale(OsbEasing.Out, 0, beat, 0.3, 0.35);
            heartCopy.EndGroup();

            //2
            var heart2 = GetLayer("Heart").CreateSprite("sb/etc/ht.png", OsbOrigin.Centre);
            var heartCopy2 = GetLayer("Heart").CreateSprite("sb/etc/ht.png", OsbOrigin.Centre);
            heart2.Fade(103387, 1);
            heart2.Fade(119658, 0);
            heart2.Scale(103387, 0.3);

            heartCopy2.StartLoopGroup(103387, (119658 - 103387) / beat - 1);
            heartCopy2.Fade(OsbEasing.Out, 0, beat, 1, 0);
            heartCopy2.Scale(OsbEasing.Out, 0, beat, 0.3, 0.35);
            heartCopy2.EndGroup();

            //3
            var heart3 = GetLayer("Heart").CreateSprite("sb/etc/ht.png", OsbOrigin.Centre);
            var heartCopy3 = GetLayer("Heart").CreateSprite("sb/etc/ht.png", OsbOrigin.Centre);
            heart3.Fade(176607, 1);
            heart3.Fade(191862, 0);
            heart3.Scale(191862, 0.3);

            heartCopy3.StartLoopGroup(176607, (192878 - 176607) / beat - 1);
            heartCopy3.Fade(OsbEasing.Out, 0, beat, 1, 0);
            heartCopy3.Scale(OsbEasing.Out, 0, beat, 0.3, 0.35);
            heartCopy3.EndGroup();
        }
    }
}
