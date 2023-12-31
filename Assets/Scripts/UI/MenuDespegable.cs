using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuDespegable : MonoBehaviour
{
    public static MenuDespegable Instance { get; private set; }

    [SerializeField] private RectTransform menuDespegable;
    private float posicionFinal;
    private bool abrirMenu;
    [SerializeField] private float tiempoDeRecorrido;
    // Start is called before the first frame update


    private void Awake() {
       
        Instance = this;
    }
    void Start()
    {
      /*   posicionFinal =  menuDespegable.rect.width;
        
       Debug.Log(posicionFinal);
        menuDespegable.position = new Vector3 (-posicionFinal, menuDespegable.position.y, 0); */
        MoverMenu(tiempoDeRecorrido, menuDespegable.position, new Vector3(-Screen.width / 2, menuDespegable.position.y, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator Mover(float time, Vector3 posInit, Vector3 posFin)
    {
        float elapsedTime = 0;
        while (elapsedTime < time)
        {
            menuDespegable.position = Vector3.Lerp(posInit, posFin, (elapsedTime / time));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        menuDespegable.position = posFin;
    }

    private void MoverMenu(float time, Vector3 posInit, Vector3 posFin)
    {
        StartCoroutine(Mover(time, posInit, posFin));
    }

    public void BottonActivarMenuDespegable()
    {
      /*   int signo = 1; */
        if (!abrirMenu)
        {
            MoverMenu(tiempoDeRecorrido, menuDespegable.position, new Vector3(0, menuDespegable.position.y, 0));
        }else{
            MoverMenu(tiempoDeRecorrido, menuDespegable.position, new Vector3(-Screen.width / 2, menuDespegable.position.y, 0));
        }
        
        abrirMenu = !abrirMenu;
    }
}
