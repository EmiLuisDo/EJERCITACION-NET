import React, {useEffect, useState} from 'react'
import axios from 'axios';

function GEN1()
{
    let [lPokemon, setLPokemon] = useState(null)
    let [imagenPokemon, setImagenPokemon] = useState(null)
    

    useEffect(() => {
        // Good!
        axios.get("https://pokeapi.co/api/v2/generation/1/")
        .then(response =>
        {
            setLPokemon(response.data.pokemon_species)
        })
      }, [] );

    const listaPokemon =()=> lPokemon.map((poke) => <li><button key={poke.name} onClick={(ev)=>cargarImagen(ev)}>{poke.name}</button></li>)


    const cargarImagen = (ev) =>
    {
        let pokeElegido = ev.target.innerHTML
        let opoke = null
        console.log(pokeElegido)
        for (let i = 0 ; i < lPokemon.lenght && opoke==null; i++){
            console.log(lPokemon[i])
            if(lPokemon[i].name === pokeElegido)
            {
                opoke = lPokemon[i]
            }
        }
        console.log(opoke)
    }
    
    return(
        <div>
            {(lPokemon!=null) ? listaPokemon() : ""}
            {console.log(lPokemon)}
            
            
            {/* { (imagenPokemon!=null)? (<img src={imagenPokemon} alt="Logo" />) : ""} */}
        </div>
    );
}

export default GEN1