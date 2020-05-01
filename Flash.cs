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
    public class Flash : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var EndTime = (int)(Beatmap.HitObjects.LastOrDefault()?.EndTime ?? AudioDuration);

            int[] timeStamps = {22031,  54573, 87115, 119658, 192878, 135929};
            foreach (var stamp in timeStamps)
            {
                var flash = GetLayer("Flashes").CreateSprite("sb/etc/p.png", OsbOrigin.Centre);
                flash.Scale(stamp, 1000);
                flash.Additive(stamp, stamp+500);
                flash.Fade(stamp, stamp+500, 1, 0);
            }

            var redFlashes = GetLayer("Flashes").CreateSprite("sb/etc/p.png", OsbOrigin.Centre);
           
            var beat = 509;

            redFlashes.Color(54573, 1, 0, 0);
            redFlashes.Scale(54573, 1000);
            redFlashes.Fade(54573,0);
            redFlashes.Additive(54573, 71861);
            redFlashes.StartLoopGroup(54573, (int)((71861 - 54573)/(beat)));
            redFlashes.Fade(0, beat, 0.3, 0);
            redFlashes.EndGroup();

            var redFlashes2 = GetLayer("Flashes").CreateSprite("sb/etc/p.png", OsbOrigin.Centre);
            
            redFlashes2.Color(119658, 1, 0, 0);
            redFlashes2.Scale(119658, 1000);
            redFlashes2.Fade(119658,0);
            redFlashes2.Additive(119658, 136437);
            redFlashes2.StartLoopGroup(119658, (int)((136437 - 119658)/(beat)));
            redFlashes2.Fade(0, beat, 0.3, 0);
            redFlashes2.EndGroup();


            var redFlashes3 = GetLayer("Flashes").CreateSprite("sb/etc/p.png", OsbOrigin.Centre);
            redFlashes3.Color(192878, 1, 0, 0);
            redFlashes3.Scale(192878, 1000);
            redFlashes3.Fade(192878,0);
            redFlashes3.Additive(192878, 210166);
            redFlashes3.StartLoopGroup(192878, (int)((210166 - 192878)/(beat)));
            redFlashes3.Fade(0, beat, 0.3, 0);
            redFlashes3.EndGroup();
        }
    }
}
