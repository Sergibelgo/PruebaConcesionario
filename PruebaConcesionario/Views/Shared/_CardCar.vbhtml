@ModelType car
<div class="card" style="width: 18rem;">
    @code
        Dim number = Int((19 * Rnd()) + 1)
        Dim text = "https://generatorfun.com/code/uploads/Random-Car-image-" + number.ToString() + ".jpg"
    End Code
    <img src="@text" class="card-img-top" alt="coche">
    <div class="card-body">
        <ul class="">
            <li>Marca: @Model.Marca</li>
            <li>Modelo: @Model.Modelo</li>
            <li>Año: @Model.Año</li>
        </ul>
        <a href="#" Class="btn btn-primary">Go somewhere</a>
    </div>
</div>
