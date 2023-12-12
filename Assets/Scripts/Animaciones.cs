using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{

    public Animator animation;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ThrillerOn (){
        animation.SetBool("Thriller", true );
    }
    public void ThrillerOff (){
        animation.SetBool("Thriller", false );
    }
}
