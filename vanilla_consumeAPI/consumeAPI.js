function consumirAPI(){
    fetch("https://dog.ceo/api/breeds/list/all")
    .then(response => response.json())
    .then(data => console.log(data.message))
}