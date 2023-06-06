@ModelType IEnumerable(Of car)
@Code
    ViewData("Title") = "Home Page"
End Code

<main>
    <section class="row">
        <ul>
            @For Each item In Model
                @<li>@item.Modelo @item.Marca @item.Precio</li>
            Next
        </ul>
    </section>
</main>
