using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeInteracion : MonoBehaviour
{
    public PersonajeInteracion PersonajeObjetivo { get; private set; }
    private PersonajeFX personajeFx;
    // Start is called before the first frame update
    void Start()
    {
        personajeFx = GetComponent<PersonajeFX>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    //Funciona para seleccionar al personaje, si lo vuelven a seleccionar se deseleciona
    private void PersonajeSeleccionado(PersonajeInteracion personajeSeleccionado)
    {
        //Si el personaje se llama igual al seleccionado 
        if(personajeSeleccionado.name == gameObject.name)
        { 
             if (PersonajeObjetivo != null)
             {
                PersonajeObjetivo = null;
                personajeFx.MostrarPersonajeSelecionado(false);
             }
             else
             {
                PersonajeObjetivo = personajeSeleccionado;
                personajeFx.MostrarPersonajeSelecionado(true);
             }
           
        }
        else
        {
            PersonajeObjetivo = null;
            personajeFx.MostrarPersonajeSelecionado(false);
        }
    }
    private void OnEnable()
    {
        SelectionManager.EventoPersonajeSeleccionado += PersonajeSeleccionado;  
    }
    private void OnDisable()
    {
        SelectionManager.EventoPersonajeSeleccionado -= PersonajeSeleccionado;
    }
}
