namespace TestCoverage;

public static class JellyBean
{
    public static HashSet<JellyBeanFlavor> GetAllFlavors()
    {
        return
        [
            JellyBeanFlavor.Lemon,
            JellyBeanFlavor.Pistachio,
            JellyBeanFlavor.Cantaloupe,
            JellyBeanFlavor.Pear,
            JellyBeanFlavor.Tangerine,
            JellyBeanFlavor.Apricot
        ];
    }

    public static HashSet<JellyBeanColor> GetAllColors()
    {
        return
        [
            JellyBeanColor.Yellow,
            JellyBeanColor.Green,
            JellyBeanColor.Orange,
            JellyBeanColor.White
        ];
    }

    public static JellyBeanFlavor[] GetFlavorsForColor(JellyBeanColor jellyBeanColor)
    {
        return jellyBeanColor switch
        {
            JellyBeanColor.Yellow => new[] { JellyBeanFlavor.Lemon, JellyBeanFlavor.Apricot },
            JellyBeanColor.Green => new[] { JellyBeanFlavor.Pistachio },
            JellyBeanColor.Orange => new[] { JellyBeanFlavor.Cantaloupe, JellyBeanFlavor.Tangerine },
            JellyBeanColor.White => new[] { JellyBeanFlavor.Pear },
            _ => new [] { JellyBeanFlavor.Unknown }
        };
    }

    public static JellyBeanColor GetColorForFlavor(JellyBeanFlavor jellyBeanFlavor)
    {
        return jellyBeanFlavor switch
        {
            JellyBeanFlavor.Lemon => JellyBeanColor.Yellow,
            JellyBeanFlavor.Apricot => JellyBeanColor.Yellow,
            JellyBeanFlavor.Pistachio => JellyBeanColor.Green,
            JellyBeanFlavor.Cantaloupe => JellyBeanColor.Orange,
            JellyBeanFlavor.Tangerine => JellyBeanColor.Orange,
            JellyBeanFlavor.Pear => JellyBeanColor.White,
            _ => JellyBeanColor.Unknown
        };
    }
}