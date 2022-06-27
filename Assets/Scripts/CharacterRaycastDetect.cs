using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
   **********************
	Author : Taii
	Company: SuperGame

   **********************
*/

public class CharacterRaycastDetect : MonoBehaviour
{
    public static CharacterRaycastDetect Instance;
    public float rayLength = 5;
    private Camera cam;
    private IInteractObject currentInteractObject;
    public LayerMask objectMask;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (cam == null) return;
        Ray mouseRay = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(mouseRay, out RaycastHit hitInfo, Mathf.Infinity, objectMask))
        {
            IInteractObject interactObj = hitInfo.collider.GetComponent<IInteractObject>();
            if (interactObj != null)
            {
                if (currentInteractObject != null)
                {
                    if (interactObj.GetGameObject() != currentInteractObject.GetGameObject())
                    {
                        Debug.Log("Change Object");
                        currentInteractObject.DisableInteract();
                        currentInteractObject = interactObj;
                        currentInteractObject.OnEnterInteract();
                    }
                } else
                {
                    currentInteractObject = interactObj;
                    currentInteractObject.OnEnterInteract();
                }
            }
            else
            {
                if (currentInteractObject != null)
                {
                    Debug.Log("Object has not Interact");
                    currentInteractObject.DisableInteract();
                    currentInteractObject = null;
                }
            }
        } else
        {
            if (currentInteractObject != null)
            {
                Debug.Log("Not collider Object Without Raycast");
                currentInteractObject.DisableInteract();
                currentInteractObject = null;
            }
        }
    }

    public IInteractObject GetCurrentInteractiveObject()
    {
        return currentInteractObject;
    }

}
