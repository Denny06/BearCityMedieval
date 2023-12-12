using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{

    public AudioSource clipMacarena;
    public AudioSource clipThriller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MacarenaMusicOn(){
        clipMacarena.Play();
        clipThriller.Stop();
    }

   

    public void ThrillerMusicOn(){
        clipThriller.Play();
        clipMacarena.Stop();
    }

  
}
