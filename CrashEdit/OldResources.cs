using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;

namespace CrashEdit
{
    internal static class OldResources
    {
        [Resource("NSDIcon")]
        private static Icon nsdicon = null;

        [Resource("NSFIcon")]
        private static Icon nsficon = null;

        [Resource("ArrowImage")]
        private static Image arrowimage = null;

        [Resource("BinocularsImage")]
        private static Image binocularsimage = null;

        [Resource("BinocularsNextImage")]
        private static Image binocularsnextimage = null;

        [Resource("FileImage")]
        private static Image fileimage = null;

        [Resource("FolderImage")]
        private static Image folderimage = null;

        [Resource("ImageImage")]
        private static Image imageimage = null;

        [Resource("MusicImage")]
        private static Image musicimage = null;

        [Resource("MusicRedImage")]
        private static Image musicredimage = null;

        [Resource("MusicYellowImage")]
        private static Image musicyellowimage = null;

        [Resource("OpenImage")]
        private static Image openimage = null;

        [Resource("SaveImage")]
        private static Image saveimage = null;

        [Resource("SpeakerImage")]
        private static Image speakerimage = null;

        [Resource("ThingImage")]
        private static Image thingimage = null;

        [Resource("BlueJournalImage")]
        private static Image bluejournalimage = null;

        [Resource("WhiteJournalImage")]
        private static Image whitejournalimage = null;

        [Resource("YellowJournalImage")]
        private static Image yellowjournalimage = null;

        [Resource("PointTexture")]
        private static Bitmap pointtexture = null;

        [Resource("MaskTexture")]
        private static Bitmap masktexture = null;

        [Resource("LifeTexture")]
        private static Bitmap lifetexture = null;

        [Resource("AppleTexture")]
        private static Bitmap appletexture = null;

        [Resource("TNTBoxTexture")]
        [ExternalTexture(1,0)]
        private static Bitmap tntboxtexture = null;

        [Resource("TNTBoxTopTexture")]
        [ExternalTexture(0,0)]
        private static Bitmap tntboxtoptexture = null;

        [Resource("EmptyBoxTexture")]
        [ExternalTexture(5,0)]
        private static Bitmap emptyboxtexture = null;

        [Resource("SpringBoxTexture")]
        [ExternalTexture(6,0)]
        private static Bitmap springboxtexture = null;

        [Resource("ContinueBoxTexture")]
        [ExternalTexture(7,0)]
        private static Bitmap continueboxtexture = null;

        [Resource("IronBoxTexture")]
        [ExternalTexture(8,0)]
        private static Bitmap ironboxtexture = null;

        [Resource("FruitBoxTexture")]
        [ExternalTexture(9,0)]
        private static Bitmap fruitboxtexture = null;

        [Resource("ActionBoxTexture")]
        [ExternalTexture(10,0)]
        private static Bitmap actionboxtexture = null;

        [Resource("LifeBoxTexture")]
        [ExternalTexture(11,0)]
        private static Bitmap lifeboxtexture = null;

        [Resource("DoctorBoxTexture")]
        [ExternalTexture(12,0)]
        private static Bitmap doctorboxtexture = null;

        [Resource("PickupBoxTexture")]
        [ExternalTexture(0,1)]
        private static Bitmap pickupboxtexture = null;

        [Resource("UnknownBoxTexture")]
        [ExternalTexture(1,1)]
        private static Bitmap powboxtexture = null;

        [Resource("IronSpringBoxTexture")]
        [ExternalTexture(2,1)]
        private static Bitmap ironspringboxtexture = null;

        [Resource("NitroBoxTexture")]
        [ExternalTexture(4,1)]
        private static Bitmap nitroboxtexture = null;

        [Resource("NitroBoxTopTexture")]
        [ExternalTexture(3,1)]
        private static Bitmap nitroboxtoptexture = null;

        [Resource("SteelBoxTexture")]
        [ExternalTexture(5,1)]
        private static Bitmap steelboxtexture = null;

        [Resource("ActionNitroBoxTexture")]
        [ExternalTexture(6,1)]
        private static Bitmap actionnitroboxtexture = null;

        [Resource("ActionNitroBoxTopTexture")]
        [ExternalTexture(8,0)]
        private static Bitmap actionnitroboxtoptexture = null;

        [Resource("UnknownBoxTexture")]
        [ExternalTexture(9,1)]
        private static Bitmap slotboxtexture = null;

        [Resource("UnknownBoxTexture")]
        [ExternalTexture(5,2)]
        private static Bitmap timeboxtexture = null;

        [Resource("UnknownBoxTopTexture")]
        [ExternalTexture(2,2)]
        private static Bitmap timeboxtoptexture = null;

        [Resource("UnknownBoxTexture")]
        [ExternalTexture(6,2)]
        private static Bitmap ironcontinueboxtexture = null;

        [Resource("UnknownBoxTexture")]
        [ExternalTexture(7,2)]
        private static Bitmap clockboxtexture = null;

        [Resource("UnknownBoxTexture")]
        private static Bitmap unknownboxtexture = null;

        [Resource("UnknownBoxTopTexture")]
        private static Bitmap unknownboxtoptexture = null;

        [Resource("UnknownPickupTexture")]
        private static Bitmap unknownpickuptexture = null;

        [Resource("GreyBuckle")]
        private static Image greybuckle = null;

        [Resource("CodeBuckle")]
        private static Image codebuckle = null;

        [Resource("CrimsonBuckle")]
        private static Image crimsonbuckle = null;

        [Resource("LimeBuckle")]
        private static Image limebuckle = null;

        [Resource("BlueBuckle")]
        private static Image bluebuckle = null;

        [Resource("VioletBuckle")]
        private static Image violetbuckle = null;

        static OldResources()
        {
            ResourceManager manager = new ResourceManager("CrashEdit.OldResources",Assembly.GetExecutingAssembly());
            foreach (FieldInfo field in typeof(OldResources).GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
            {
                foreach (ResourceAttribute attribute in field.GetCustomAttributes(typeof(ResourceAttribute),false))
                {
                    field.SetValue(null,manager.GetObject(attribute.Name));
                }
            }
            string exefilename = Assembly.GetExecutingAssembly().Location;
            string exedirname = Path.GetDirectoryName(exefilename);
            string texturespngfilename = Path.Combine(exedirname,"Textures.png");
            if (File.Exists(texturespngfilename))
            {
                using (Image texturespng = Image.FromFile(texturespngfilename))
                {
                    foreach (FieldInfo field in typeof(OldResources).GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
                    {
                        foreach (ExternalTextureAttribute attribute in field.GetCustomAttributes(typeof(ExternalTextureAttribute),false))
                        {
                            Bitmap texture = new Bitmap(32,32);
                            int x = attribute.X * 32;
                            int y = attribute.Y * 32;
                            using (Graphics g = Graphics.FromImage(texture))
                            {
                                g.DrawImage(texturespng,new Rectangle(0,0,32,32),new Rectangle(x,y,32,32),GraphicsUnit.Pixel);
                            }
                            field.SetValue(null,texture);
                        }
                    }
                }
            }
        }

        public static Icon NSDIcon => nsdicon;
        public static Icon NSFIcon => nsficon;
        public static Image ArrowImage => arrowimage;
        public static Image BinocularsImage => binocularsimage;
        public static Image BinocularsNextImage => binocularsnextimage;
        public static Image FileImage => fileimage;
        public static Image FolderImage => folderimage;
        public static Image ImageImage => imageimage;
        public static Image MusicImage => musicimage;
        public static Image MusicRedImage => musicredimage;
        public static Image MusicYellowImage => musicyellowimage;
        public static Image OpenImage => openimage;
        public static Image SaveImage => saveimage;
        public static Image SpeakerImage => speakerimage;
        public static Image ThingImage => thingimage;
        public static Image BlueJournalImage => bluejournalimage;
        public static Image WhiteJournalImage => whitejournalimage;
        public static Image YellowJournalImage => yellowjournalimage;
        public static Bitmap AppleTexture => appletexture;
        public static Bitmap LifeTexture => lifetexture;
        public static Bitmap MaskTexture => masktexture;
        public static Bitmap PointTexture => pointtexture;
        public static Bitmap ActionBoxTexture => actionboxtexture;
        public static Bitmap ActionNitroBoxTexture => actionnitroboxtexture;
        public static Bitmap ActionNitroBoxTopTexture => actionnitroboxtoptexture;
        public static Bitmap ClockBoxTexture => clockboxtexture;
        public static Bitmap ContinueBoxTexture => continueboxtexture;
        public static Bitmap DoctorBoxTexture => doctorboxtexture;
        public static Bitmap EmptyBoxTexture => emptyboxtexture;
        public static Bitmap FruitBoxTexture => fruitboxtexture;
        public static Bitmap IronBoxTexture => ironboxtexture;
        public static Bitmap IronContinueBoxTexture => ironcontinueboxtexture;
        public static Bitmap IronSpringBoxTexture => ironspringboxtexture;
        public static Bitmap LifeBoxTexture => lifeboxtexture;
        public static Bitmap NitroBoxTexture => nitroboxtexture;
        public static Bitmap NitroBoxTopTexture => nitroboxtoptexture;
        public static Bitmap PickupBoxTexture => pickupboxtexture;
        public static Bitmap POWBoxTexture => powboxtexture;
        public static Bitmap SlotBoxTexture => slotboxtexture;
        public static Bitmap SpringBoxTexture => springboxtexture;
        public static Bitmap SteelBoxTexture => steelboxtexture;
        public static Bitmap TimeBoxTexture => timeboxtexture;
        public static Bitmap TimeBoxTopTexture => timeboxtoptexture;
        public static Bitmap TNTBoxTexture => tntboxtexture;
        public static Bitmap TNTBoxTopTexture => tntboxtoptexture;
        public static Bitmap UnknownBoxTexture => unknownboxtexture;
        public static Bitmap UnknownBoxTopTexture => unknownboxtoptexture;
        public static Bitmap UnknownPickupTexture => unknownpickuptexture;
        public static Image BlueBuckle => bluebuckle;
        public static Image CodeBuckle => codebuckle;
        public static Image CrimsonBuckle => crimsonbuckle;
        public static Image GreyBuckle => greybuckle;
        public static Image LimeBuckle => limebuckle;
        public static Image VioletBuckle => violetbuckle;

        [AttributeUsage(AttributeTargets.Field)]
        private class ResourceAttribute : Attribute
        {
            public ResourceAttribute(string name)
            {
                Name = name;
            }

            public string Name { get; }
        }

        [AttributeUsage(AttributeTargets.Field)]
        private class ExternalTextureAttribute : Attribute
        {
            public ExternalTextureAttribute(int x,int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; }
            public int Y { get; }
        }
    }
}
