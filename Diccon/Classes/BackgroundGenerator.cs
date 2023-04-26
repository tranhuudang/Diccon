using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;

namespace Diccon.Classes
{
    internal class BackgroundGenerator
    {
        public static Color GenerateColorFromText(string input)
        {
            // Compute a hash code for the input string using SHA256
            SHA256 sha256 = SHA256.Create();
            byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Take the first three bytes of the hash as the RGB values of the color
            byte red = hashBytes[0];
            byte green = hashBytes[1];
            byte blue = hashBytes[2];

            // Calculate the perceived brightness of the color
            double perceivedBrightness = Math.Sqrt(
                red * red * 0.299 +
                green * green * 0.587 +
                blue * blue * 0.114);

            // If the color is too light, adjust the brightness to a darker value
            if (perceivedBrightness > 180)
            {
                int adjustment = (int)Math.Round((perceivedBrightness - 180) * 2);
                red = (byte)Math.Max(0, red - adjustment);
                green = (byte)Math.Max(0, green - adjustment);
                blue = (byte)Math.Max(0, blue - adjustment);
            }

            return Color.FromArgb(red, green, blue);
        }
    }
}
