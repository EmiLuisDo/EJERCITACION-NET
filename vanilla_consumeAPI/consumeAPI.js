var listaRazas = []
var urlListaRazas = "https://dog.ceo/api/breeds/list/all"
var urlImagenes_Raza = "https://dog.ceo/api/breed/RAZA/images"
var imagenes_Raza = []

function cargarRazas(){
    fetch("https://dog.ceo/api/breeds/list/all")
    .then(response => response.json())
    .then(data => cargarListaPerros(data.message))
    .catch(err => alert(err))
}

function cargarListaPerros(listaPerros){
    listaRazas = listaPerros
    elSelectRazas = document.querySelector("#razaSelect")
    razas = Object.keys(listaPerros)

    razas.forEach(raza => {
        elSelectRazas.innerHTML+="<option>"+raza+"</option>"
    });
}

function resetearApp()
{
    elBtnInfoPerros = document.querySelector("#btnInfoRazas")
    elBtnInfoPerros.style.display = "none"
    elImgPerro = document.querySelector("#perroImg")
    elImgPerro.src=""
    imagenes_Raza= []
}

function cargarImagenRandomPerro()
{
    cantidadImagenes = imagenes_Raza.length
    azar =Math.floor( Math.random() * (cantidadImagenes - 0) + 0);
    elImgPerro = document.querySelector("#perroImg")
    console.log(azar)
    elImgPerro.src=imagenes_Raza[azar]
}

function obtenerImagenesRandom()
{
    razaSeleccionada = document.querySelector("#razaSelect").value
    fetch(urlImagenes_Raza.replace("RAZA", razaSeleccionada))
    .then(response => response.json())
    .then(respuesta => 
        {
            console.log(respuesta)
            imagenes_Raza = respuesta.message
            mostrarCantidadImagenes()
            document.querySelector("#btnCargarImagen").disabled=false
        })
    .catch(err => alert(err))
}

function mostrarCantidadImagenes()
{
    elBtnInfoPerros = document.querySelector("#btnInfoRazas")
    elBtnInfoPerros.value = imagenes_Raza.length
    elBtnInfoPerros.style.display="inline"
}