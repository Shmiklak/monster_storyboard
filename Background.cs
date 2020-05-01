using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using System.Linq;
using OpenTK;
using OpenTK.Graphics;
// using StorybrewCommon.Scripting;
// using StorybrewCommon.Storyboarding;
// using StorybrewCommon.Subtitles;
using System;
using System.Drawing;
using System.IO;

namespace StorybrewScripts
{
    public class Background : StoryboardObjectGenerator
    {
        [Configurable]
        public string BackgroundPath = "";

        [Configurable]
        public int StartTime = 0;

        [Configurable]
        public int EndTime = 0;

        [Configurable]
        public double Opacity = 0.2;

        public override void Generate()
        {
            if (BackgroundPath == "") BackgroundPath = Beatmap.BackgroundPath ?? string.Empty;
            if (StartTime == EndTime) EndTime = (int)(Beatmap.HitObjects.LastOrDefault()?.EndTime ?? AudioDuration);

            var bitmap = GetMapsetBitmap(BackgroundPath);
            var bg = GetLayer("").CreateSprite(BackgroundPath, OsbOrigin.Centre);
            var blur = GetLayer("").CreateSprite("sb/bg/blur.jpg", OsbOrigin.Centre);
            var kiai = GetLayer("").CreateSprite("sb/bg/kiai.jpg", OsbOrigin.Centre);
            bg.Scale(StartTime, 0.73);
            bg.Fade(StartTime - 500, StartTime, 0, Opacity);
            bg.Fade(21014, 21522, Opacity, 0);
            bg.Fade(22031, Opacity);
            bg.Fade(135929, 0);
            // bg.Fade(EndTime, EndTime + 500, Opacity, 0);
            blur.Scale(StartTime, 0.73);
            blur.Fade(StartTime - 500, 3725, 1, 0);

            var shakePosition = new Vector2(
                (float)(Math.Cos(45) * 1.3),
                (float)(Math.Sin(45) * 1.3)
            );
            var position = new Vector2(320, 240);
            var beat = 509;

            kiai.Fade(54573, 1);
            kiai.Scale(54573, 0.73);
            kiai.StartLoopGroup(54573, (int)((70844 - 54573)/(beat/4)));
            kiai.Move(0, beat/4, position + shakePosition, position - shakePosition);
            kiai.EndGroup();
            kiai.Fade(70844, 71861, 1, 0);


            var kiai2 = GetLayer("").CreateSprite("sb/bg/kiai.jpg", OsbOrigin.Centre);
            kiai2.Fade(119658, 1);
            kiai2.Scale(119658, 0.73);
            kiai2.StartLoopGroup(119658, (int)((136437 - 119658)/(beat/4)));
            kiai2.Move(0, beat/4, position + shakePosition, position - shakePosition);
            kiai2.EndGroup();
            kiai2.Fade(135929, 0);

            var kiai3 = GetLayer("").CreateSprite("sb/bg/kiai.jpg", OsbOrigin.Centre);
            kiai3.Fade(192878, 1);
            kiai3.Scale(192878, 0.73);
            kiai3.StartLoopGroup(192878, (int)((210166 - 192878)/(beat/4)));
            kiai3.Move(0, beat/4, position + shakePosition, position - shakePosition);
            kiai3.EndGroup();
            kiai3.Fade(209149, 210166, 1, 0);

            var eyePosition = new Vector2(340, 264);
            var eye =  GetLayer("").CreateSprite("sb/etc/eye.jpg", OsbOrigin.Centre, eyePosition);
            eye.Fade(54573, 1);
            eye.Scale(54573, 0.05);
            eye.Additive(54573, 74912);

            eye.StartLoopGroup(54573, (int)((70844 - 54573)/(beat/4)));
            eye.Move(0, beat/4, eyePosition + shakePosition, eyePosition - shakePosition);
            eye.EndGroup();
            eye.StartLoopGroup(54573, (int)((74912 - 54573)/(beat*8)));
            eye.Rotate(0, beat*8, 0, MathHelper.DegreesToRadians(360));
            eye.EndGroup();

            eye.Fade(70844, 71861, 1, 0);


            var eye2 =  GetLayer("").CreateSprite("sb/etc/eye.jpg", OsbOrigin.Centre, eyePosition);
            eye2.Scale(119658, 0.05);
            eye2.Additive(119658, 139997);
            eye2.StartLoopGroup(119658, (int)((135929 - 119658)/(beat/4)));
            eye2.Move(0, beat/4, eyePosition + shakePosition, eyePosition - shakePosition);
            eye2.EndGroup();
            eye2.StartLoopGroup(119658, (int)((139997 - 119658)/(beat*8)));
            eye2.Rotate(0, beat*8, 0, MathHelper.DegreesToRadians(360));
            eye2.EndGroup();

            eye2.Fade(119658, 1);
            eye2.Fade(135929, 0);
            

            var eye3 =  GetLayer("").CreateSprite("sb/etc/eye.jpg", OsbOrigin.Centre, eyePosition);
            eye3.Fade(192878, 1);
            eye3.Fade(209149, 210166, 1, 0);
            eye3.Scale(192878, 0.05);
            eye3.Additive(192878, 210166);

            eye3.StartLoopGroup(192878, (int)((210166 - 192878)/(beat/4)));
            eye3.Move(0, beat/4, eyePosition + shakePosition, eyePosition - shakePosition);
            eye3.EndGroup();
            eye3.StartLoopGroup(192878, (int)((210166 - 192878)/(beat*8)));
            eye3.Rotate(0, beat*8, 0, MathHelper.DegreesToRadians(360));
            eye3.EndGroup();

        }
    }
}
