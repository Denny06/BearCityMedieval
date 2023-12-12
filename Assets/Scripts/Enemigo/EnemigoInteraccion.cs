using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoInteraccion : MonoBehaviour
{
    public EnemigoInteraccion EnemigoObjetivo { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void EnemigoNoSeleccionado()
    {
        if (EnemigoObjetivo == null) { return; }
        /* EnemigoObjetivo.MostrarEnemigoSeleccionado(false, TipoDeteccion.Rango); */
        EnemigoObjetivo = null;
    }

    private void EnemigoRangoSeleccionado(EnemigoInteraccion enemigoSeleccionado)
    {
        
        if (EnemigoObjetivo == enemigoSeleccionado) { return; }

        EnemigoObjetivo = enemigoSeleccionado;
        /* EnemigoObjetivo.MostrarEnemigoSeleccionado(true, TipoDeteccion.Rango); */
    }

    private void OnEnable()
    {
        SelectionManager.EventoEnemigoSeleccionado += EnemigoRangoSeleccionado;
        SelectionManager.EventoObjetoNoSeleccionado += EnemigoNoSeleccionado;
        /* PersonajeDetector.EventoEnemigoDetectado += EnemigoMeleeDetectado;
        PersonajeDetector.EventoEnemigoPerdido += EnemigoMeleePerdido; */
    }

    private void OnDisable()
    {
        SelectionManager.EventoEnemigoSeleccionado -= EnemigoRangoSeleccionado;
        SelectionManager.EventoObjetoNoSeleccionado -= EnemigoNoSeleccionado;
        /* PersonajeDetector.EventoEnemigoDetectado -= EnemigoMeleeDetectado;
        PersonajeDetector.EventoEnemigoPerdido -= EnemigoMeleePerdido; */
    }

    private bool estaSeleccionado(){
        if(EnemigoObjetivo == null){return false;}
        return true;
    }
}
