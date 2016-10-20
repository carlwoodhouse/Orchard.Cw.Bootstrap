using Orchard.UI.Resources;

namespace Orchard.Cw.Bootstrap {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            manifest.DefineStyle("Cw.Main.Style").SetUrl("cw.min.css", "cw.css");
        }
    }
}
