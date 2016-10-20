using Orchard.DisplayManagement.Descriptors;

namespace Orchard.Cw.Bootstrap.Providers {
    public class ThemeShapeProvider : IShapeTableProvider {
        public void Discover(ShapeTableBuilder builder) {
            builder.Describe("Content")
                   .OnDisplaying(displaying => {
                       displaying.ShapeMetadata.Wrappers.Add("Wrapper__Cw");
                   });
        }
    }
}