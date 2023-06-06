<nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark">
    <div class="container">
        @Html.ActionLink("Concesionario VB", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
        <button type="button" class="navbar-toggler" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" title="Alternar navegación" aria-controls="navbarSupportedContent"
                aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse d-sm-inline-flex justify-content-between">
            <ul class="navbar-nav flex-grow-1">
                <li>@Html.ActionLink("Inicio", "Index", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                <li>@Html.ActionLink("Contacto", "Contact", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                <li>@Html.ActionLink("Add", "Create", "Cars", New With {.area = ""}, New With {.class = "nav-link"})</li>
            </ul>
        </div>
    </div>
</nav>