using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DebugText : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text debubText;
    void Start()
    {
        debubText.SetText("texto");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DebugTextScreen(string texto){
        debubText.SetText(texto);
    }
}
