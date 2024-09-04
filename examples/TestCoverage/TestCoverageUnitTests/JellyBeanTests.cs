using TestCoverage;

namespace TestCoverageUnitTests;

public class JellyBeanTests
{
    //T1
    [Fact]
    public void JellyBean_ReceiveFlavorList_AllFlavorsReceived()
    {
        //arrange
        var t1Flavors = GetFlavorsT1();
        var allFlavors = JellyBean.GetAllFlavors();

        //make hash of all represented flavors
        var flavorHash = new HashSet<JellyBeanFlavor>();
        foreach (var (flavor, count) in t1Flavors)
        {
            if (flavorHash.Contains(flavor)) continue; //already in hash set
            flavorHash.Add(flavor);
        }

        //assert

        //are there any unknown flavors in the list?
        foreach (var (flavor, count) in t1Flavors)
        {
            Assert.Contains(flavor, allFlavors);
        }

        //are all flavors represented?
        Assert.Equal(flavorHash.Count, JellyBean.GetAllFlavors().Count);

    }

    //T1
    private static List<(JellyBeanFlavor Flavor, int Count)> GetFlavorsT1()
    {
        return new List<(JellyBeanFlavor, int)>
        {
            (JellyBeanFlavor.Lemon, 3),
            (JellyBeanFlavor.Pistachio, 1),
            (JellyBeanFlavor.Cantaloupe, 2),
            (JellyBeanFlavor.Pear, 1),
            (JellyBeanFlavor.Tangerine, 1),
            (JellyBeanFlavor.Apricot, 4)
        };
    }

    //T2
    private static List<(JellyBeanFlavor Flavor, int Count)> GetFlavorsT2()
    {
        return new List<(JellyBeanFlavor, int)>
        {
            (JellyBeanFlavor.Lemon, 1),
            (JellyBeanFlavor.Pistachio, 2),
            (JellyBeanFlavor.Pear, 1),
            (JellyBeanFlavor.Tangerine, 3),
        };
    }

}