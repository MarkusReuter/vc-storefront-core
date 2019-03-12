using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace VirtoCommerce.LiquidThemeEngine
{
    public interface ILiquidThemeEngine
    {
        IEnumerable<string> DiscoveryPaths { get; }
        string ResolveTemplatePath(string templateName);
        ValueTask<string> RenderTemplateByNameAsync(string templateName, object context);
        ValueTask<string> RenderTemplateAsync(string templateContent, string templatePath, object context);
        IDictionary<string, object> GetSettings(string defaultValue = null);
        JObject ReadLocalization();
        ValueTask<Stream> GetAssetStreamAsync(string fileName);
        string GetAssetHash(string fileName);
        string GetAssetAbsoluteUrl(string assetName);
    }
}
