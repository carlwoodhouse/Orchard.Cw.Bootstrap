using Orchard.UI.Resources;

namespace Orchard.Cw.Bootstrap {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            manifest.DefineScript("Bootstrap.Base.Script").SetUrl("assets/js/bootstrap.min.js", "assets/js/bootstrap.js")
                .SetVersion("3.3.5")
                .SetDependencies("jQuery");
      

            manifest.DefineStyle("Bootstrap.Base.Style").SetUrl("assets/css/bootstrap.min.css", "assets/css/bootstrap.css");
        }
    }
}
