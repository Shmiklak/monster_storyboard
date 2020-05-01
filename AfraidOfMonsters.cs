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
    public class AfraidOfMonsters : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var overlay = GetLayer("Monsters").CreateSprite("sb/etc/p.png", OsbOrigin.Centre);
            overlay.Color(52539, 0,0,0);
            overlay.Scale(52539, 1000);
            overlay.Fade(52539, 53556, 0, 1);
            overlay.Fade(53556, 54572, 1, 1);
            overlay.Fade(54573, 0);

            overlay.Fade(117624, 118641, 0, 1);
            overlay.Fade(118641, 119657, 1, 1);
            overlay.Fade(119657, 0);

            overlay.Fade(190844, 191861, 0, 1);
            overlay.Fade(191861, 192877, 1, 1);
            overlay.Fade(192878, 0);

            var beat = 53725 - 53556;

            for (var i=0; i<6; i++) {
                var xPos = 0;

                if (i<3) {
                    xPos = Random(0, 185);
                } else {
                    xPos = Random(385, 545);
                }

                var handPos = new Vector2(xPos, Random(0, 400));
                var hand = GetLayer("Monsters").CreateSprite("sb/etc/hand.png", OsbOrigin.Centre, handPos);
                var degree = MathHelper.DegreesToRadians(Random(-45, 45));
                if (i>3) {
                    hand.FlipH(53556 + beat * i, 54573);
                }
                hand.Rotate(53556 + beat * i, 54573, degree, degree);
                hand.Scale(53556 + beat * i, 0.3);

                //2
                var hand2 = GetLayer("Monsters").CreateSprite("sb/etc/hand.png", OsbOrigin.Centre, handPos);
                if (i>3) {
                    hand2.FlipH(118641 + beat * i, 119658);
                }
                hand2.Rotate(118641 + beat * i, 119658, degree, degree);
                hand2.Scale(118641 + beat * i, 0.3);

                //3
                var hand3 = GetLayer("Monsters").CreateSprite("sb/etc/hand.png", OsbOrigin.Centre, handPos);
                if (i>3) {
                    hand3.FlipH(191861 + beat * i, 192878);
                }
                hand3.Rotate(191861 + beat * i, 192878, degree, degree);
                hand3.Scale(191861 + beat * i, 0.3);
            }
        }
    }
}
