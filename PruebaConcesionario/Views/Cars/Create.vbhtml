@ModelType PruebaConcesionario.car
@Code
    ViewData("Title") = "Create"
End Code

<h2>Añadir un coche nuevo</h2>

@Using (Html.BeginForm("Create", "Cars"))
    @Html.AntiForgeryToken()

    @<div class="container">
        <div class="row mb-3">
            <div class="col">
                <h4>Información</h4>
                <hr />
            </div>
        </div>
        <div class="row mb-3">
            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        </div>

        <div class="row">
            <div class="col-12 col-md-6">
                @Html.LabelFor(Function(model) model.Marca, htmlAttributes:=New With {.class = "control-label col-md-2"})
                @Html.EditorFor(Function(model) model.Marca, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.Marca, "", New With {.class = "text-danger"})
            </div>

            <div class="col-12 col-md-6">
                @Html.LabelFor(Function(model) model.Modelo, htmlAttributes:=New With {.class = "control-label col-md-2"})
                @Html.EditorFor(Function(model) model.Modelo, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.Modelo, "", New With {.class = "text-danger"})
            </div>
        </div>
        <div class="row mb-3">
            <div class="col-12 col-md-6">
                @Html.LabelFor(Function(model) model.Precio, htmlAttributes:=New With {.class = "control-label col-md-2"})
                @Html.EditorFor(Function(model) model.Precio, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.Precio, "", New With {.class = "text-danger"})
            </div>
            <div class="col-12 col-md-6">
                @Html.LabelFor(Function(model) model.Motor, htmlAttributes:=New With {.class = "control-label col-md-2"})
                @Html.EditorFor(Function(model) model.Motor, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.Motor, "", New With {.class = "text-danger"})
            </div>
        </div>
        <div class="row mb-3">
            <div class="col-12 col-md-6">
                @Html.LabelFor(Function(model) model.Año, htmlAttributes:=New With {.class = "control-label col-md-2"})
                @Html.EditorFor(Function(model) model.Año, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.Año, "", New With {.class = "text-danger"})
            </div>
            <div class="col-12 col-md-6">
                @Html.LabelFor(Function(model) model.Kilometraje, htmlAttributes:=New With {.class = "control-label col-md-2"})
                @Html.EditorFor(Function(model) model.Kilometraje, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.Kilometraje, "", New With {.class = "text-danger"})
            </div>
        </div>
        <div class="row mb-3">
            <div class="col-12 col-md-6">
                @Html.LabelFor(Function(model) model.Combustion, "Combustion", htmlAttributes:=New With {.class = "control-label col-md-2"})
                @Html.DropDownList("Combustion", Nothing, htmlAttributes:=New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(model) model.Combustion, "", New With {.class = "text-danger"})
            </div>
            <div class="col-12 col-md-6">
                @Html.LabelFor(Function(model) model.Marchas, "Marchas", htmlAttributes:=New With {.class = "control-label col-md-2"})
                @Html.DropDownList("Marchas", Nothing, htmlAttributes:=New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(model) model.Marchas, "", New With {.class = "text-danger"})
            </div>
        </div>
        <div class="row mb-3">
            <div class="col-12 col-md-6">
                @Html.LabelFor(Function(model) model.Localidad, htmlAttributes:=New With {.class = "control-label col-md-2"})
                @Html.EditorFor(Function(model) model.Localidad, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.Localidad, "", New With {.class = "text-danger"})
            </div>
        </div>
        <div class="row mb-3">
            <div class="col">
                <input type="submit" value="Create" class="btn btn-primary" />
            </div>
        </div>
    </div>  End Using

<div>
    @Html.ActionLink("Back to List", "Index", "Home")
</div>
