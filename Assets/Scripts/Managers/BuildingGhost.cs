using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingGhost : MonoBehaviour {

    private Transform visual;
    private PlacedObjectTypeSO placedObjectTypeSO;

    private void Start() {
        /* RefreshVisual();*/

        GridBuildingSystem3D.Instance.OnSelectedChanged += Instance_OnSelectedChanged; 
    }

    private void Instance_OnSelectedChanged(object sender, System.EventArgs e) {
        RefreshVisual();
        Debug.Log("BuildingGhost");
    }

    private void Update() {

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 targetPosition = GridBuildingSystem3D.Instance.GetMouseWorldSnappedPosition();
        
        targetPosition.y = 2f;
        transform.position = targetPosition;
            

        /* transform.rotation = Quaternion.Lerp(transform.rotation, GridBuildingSystem3D.Instance.GetPlacedObjectRotation(), Time.deltaTime * 15f); */
        transform.rotation = GridBuildingSystem3D.Instance.GetPlacedObjectRotation();
        }

        if(Input.touchCount == 1)
        {
            Vector3 targetPosition = GridBuildingSystem3D.Instance.GetMouseWorldSnappedPosition();
        
            targetPosition.y = 1f;
            transform.position = targetPosition;
            transform.rotation = GridBuildingSystem3D.Instance.GetPlacedObjectRotation();
        }
        
    }

    private void RefreshVisual() {
        if (visual != null) {
            Destroy(visual.gameObject);
            visual = null;
        }

        PlacedObjectTypeSO placedObjectTypeSO = GridBuildingSystem3D.Instance.GetPlacedObjectTypeSO();

        if (placedObjectTypeSO != null) {
            visual = Instantiate(placedObjectTypeSO.visual, Vector3.zero, Quaternion.identity);
            visual.parent = transform;
            visual.localPosition = Vector3.zero;
            visual.localEulerAngles = Vector3.zero;
            SetLayerRecursive(visual.gameObject, 11);
        }
    }

    private void SetLayerRecursive(GameObject targetGameObject, int layer) {
        targetGameObject.layer = layer;
        foreach (Transform child in targetGameObject.transform) {
            SetLayerRecursive(child.gameObject, layer);
        }
    }

}

