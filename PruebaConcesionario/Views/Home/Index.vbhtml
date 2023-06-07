@ModelType IEnumerable(Of car)
@Code
    ViewData("Title") = "Home Page"
End Code

<main>
    <section class="row">
        @For Each item In Model
            @<article>@Html.Partial("_CardCar", item)</article>
        Next
    </section>
</main>
