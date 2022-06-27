using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
   **********************
	Author : Taii
	Company: SuperGame

   **********************
*/

public class CharacterInputInteract : MonoBehaviour
{
    private void Update()
    {
        if (CharacterRaycastDetect.Instance == null) return;
        if (Input.GetMouseButtonDown(0))
        {
            IInteractObject currentObj = CharacterRaycastDetect.Instance.GetCurrentInteractiveObject();
            if (currentObj != null)
            {
                currentObj.OnInteract();
            }
        }
    }
}
