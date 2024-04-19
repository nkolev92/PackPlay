using NuGet.Frameworks;

namespace Leaf;

public class FrameworkUtility
{

    public NuGetFramework GetFramework()
    {
        return FrameworkConstants.CommonFrameworks.Net50;
    }
}
