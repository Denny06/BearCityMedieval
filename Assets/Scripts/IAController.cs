using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAController : MonoBehaviour
{
    public GameObject destination;
    private NavMeshAgent agent;
    private PersonajeInteracion personajeSeleccionado;
    RaycastHit hit;
    Ray ray;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        personajeSeleccionado = GetComponent<PersonajeInteracion>();
        
    }

    // Update is called once per frame
    void Update()
    {

        
        if(personajeSeleccionado.PersonajeObjetivo == true){
            Movimiento();
        }
        
        
    }


    private void Movimiento(){
        if(Input.GetMouseButtonDown(1)){
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)) {
               
                agent.SetDestination(hit.point);
            }
            
        }
          
        if (Input.touchCount == 1){
            ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            if (Physics.Raycast(ray, out hit)) {
            
                agent.SetDestination(hit.point);
               
            }
        }
      
    }
}
