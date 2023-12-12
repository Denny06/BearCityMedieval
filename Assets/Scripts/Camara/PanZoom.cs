using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class PanZoom : MonoBehaviour
{
    public Camera cam;
    public TMP_Text debug;
    private bool moveAllowed;
    private Vector3 touchPos;

    private void Awake(){
        
    }
    // Start is called before the first frame update
    void Start()
    {
        debug.SetText("Hola que tal");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0){
            if(Input.touchCount == 2){
                //zooming
            }else{
                Touch touch = Input.GetTouch(0);
                debug.SetText("else");
                switch (touch.phase)
                {
                    case TouchPhase.Began:
                    if(EventSystem.current.IsPointerOverGameObject(touch.fingerId))
                    {
                        moveAllowed = false;
                    }else{
                        moveAllowed = true;
                    }
                    touchPos = cam.ScreenToWorldPoint(touch.position);
                    debug.SetText("touchpahse.began");
                    break;
                    case TouchPhase.Moved:
                    if(moveAllowed){
                        Vector3 direction = touchPos - cam.ScreenToWorldPoint(touch.position);
                        cam.transform.position += direction;
                    }
                    debug.SetText("moved");
                    break;

                }
            }
        }
    }
}
