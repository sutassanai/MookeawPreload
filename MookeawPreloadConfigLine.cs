using System;
using SharpDX;

namespace MookeawPreload
{
    public class PreloadConfigLine : ConfigLineBase
    {
        public Func<Color> FastColor { get; set; }
    }

    public abstract class ConfigLineBase
    {
        public string Text { get; set; }
        public Color? Color { get; set; }

        public override bool Equals(object obj)
        {
            return Text == ((ConfigLineBase) obj).Text;
        }

        public override int GetHashCode()
        {
            return Text.GetHashCode();
        }
    }
}
