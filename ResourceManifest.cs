using Orchard.UI.Resources;

namespace Orchard.Cw.Bootstrap {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            manifest.DefineScript("Bootstrap.Base.Script")
                .SetUrl("~/Themes/Orchard.Cw.Bootstrap/assets/js/bootstrap.min.js",
                        "~/Themes/Orchard.Cw.Bootstrap/assets/js/bootstrap.js")
                .SetVersion("3.3.5")
                .SetDependencies("jQuery");


            manifest.DefineStyle("Bootstrap.Base.Style")
                .SetUrl("~/Themes/Orchard.Cw.Bootstrap/assets/css/bootstrap.min.css", 
                        "~/Themes/Orchard.Cw.Bootstrap/assets/css/bootstrap.css");
        }
    }
}
