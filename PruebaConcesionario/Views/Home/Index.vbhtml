@ModelType IEnumerable(Of cars)
@Code
    ViewData("Title") = "Home Page"
End Code

<main>
    <section class="row" aria-labelledby="aspnetTitle">
        <h1 id="title">ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS and JavaScript.</p>
        <p><a href="https://asp.net" class="btn btn-primary btn-md">Learn more &raquo;</a></p>
    </section>
    <ul>
        @For Each item In Model
            @<li>@item.brand @item.model @item.price</li>
        Next
    </ul>

    <div Class="row">
        <section Class="col-md-4" aria-labelledby="gettingStartedTitle">
            <h2 id="gettingStartedTitle"> Getting started</h2>
            <p>
                ASP.NET MVC gives you a powerful, patterns-based way To build dynamic websites that
                enables a clean separation Of concerns And gives you full control over markup
                For enjoyable, agile development.
            </p>
            <p> <a Class="btn btn-outline-dark" href="https://go.microsoft.com/fwlink/?LinkId=301865">Learn more &raquo;</a></p>
        </section>
        <section Class="col-md-4" aria-labelledby="librariesTitle">
            <h2 id="librariesTitle">Get more libraries</h2>
            <p> NuGet Is a free Visual Studio extension that makes it easy To add, remove, And update libraries And tools In Visual Studio projects.</p>
            <p> <a Class="btn btn-outline-dark" href="https://go.microsoft.com/fwlink/?LinkId=301866">Learn more &raquo;</a></p>
        </section>
        <section Class="col-md-4" aria-labelledby="hostingTitle">
            <h2 id="hostingTitle"> Web Hosting</h2>
            <p> You can easily find a web hosting company that offers the right mix Of features And price For your applications.</p>
            <p> <a Class="btn btn-outline-dark" href="https://go.microsoft.com/fwlink/?LinkId=301867">Learn more &raquo;</a></p>
        </section>
    </div>
</main>
