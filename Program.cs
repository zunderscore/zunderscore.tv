using Statiq.App;
using Statiq.Common;
using Statiq.Web;
using System.Threading.Tasks;

namespace ZunderscoreTv
{
    class Program
    {
        static async Task<int> Main(string[] args) =>
            await Bootstrapper
                .Factory
                .CreateWeb(args)
                .AddSetting(WebKeys.MakeLinksRootRelative, true)
                .AddSetting(Keys.LinksUseHttps, true)
                .RunAsync();
    }
}