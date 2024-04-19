using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;

namespace Lib;

public class SDK
{
    public static string GetFramework()
    {
        var json = new JsonObject();
        return (new Leaf.FrameworkUtility()).GetFramework().ToString();
    }
}
