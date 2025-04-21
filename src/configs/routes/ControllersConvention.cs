using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace tabnews_backend_csharp.src.configs.routes;
//! descartado, mas fica como exemplo, para uso de rotas dinamicas (estilo next), considerando a namespace
/*
public class ControllersConvention : IControllerModelConvention {
    public void Apply(ControllerModel controller) {
        var targetNamespace = "tabnews_backend_csharp.src.controllers";

        if (controller.ControllerType.Namespace != null &&
            controller.ControllerType.Namespace.StartsWith(targetNamespace, StringComparison.OrdinalIgnoreCase)) {

            var namespaceParts = controller.ControllerType.Namespace.Split('.');
            var index = Array.IndexOf(namespaceParts, "controllers");

            if (index >= 0 && index + 1 < namespaceParts.Length) {
                var folders = namespaceParts.Skip(index + 1).ToArray();
                var path = string.Join("/", folders).ToLower();

                controller.Selectors.Clear();
                controller.Selectors.Add(new SelectorModel {
                    AttributeRouteModel = new AttributeRouteModel(new RouteAttribute("api/" + path))
                });
            }
        }
    }
}
*/
