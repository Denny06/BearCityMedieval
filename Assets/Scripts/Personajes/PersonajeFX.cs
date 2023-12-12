using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeFX : MonoBehaviour
{
    public GameObject personajeSeleccionado;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MostrarPersonajeSelecionado(bool esActivo){
        personajeSeleccionado.SetActive(esActivo);
    }

}
