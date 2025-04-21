using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace tabnews_backend_csharp.src.configs.routes;
/* //! descartado, mas fica como exemplo, para uso de rotas dinamicas (estilo next), considerando a namespace
public class ControllersProvider : IApplicationFeatureProvider<ControllerFeature> {
    public void PopulateFeature(IEnumerable<ApplicationPart> parts, ControllerFeature feature) {
        var currentAssembly = typeof(ControllersProvider).Assembly;
        var controllerCandidates = currentAssembly.GetExportedTypes().Where(x => x.GetCustomAttributes(typeof(ApiControllerAttribute), inherit: true).Any());

        foreach (var controllerCandidate in controllerCandidates) {
            feature.Controllers.Add(controllerCandidate.GetTypeInfo());
        }
    }
}
*/
