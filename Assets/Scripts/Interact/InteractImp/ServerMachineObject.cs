using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
   **********************
	Author : Taii
	Company: SuperGame

   **********************
*/

public class ServerMachineObject : MonoBehaviour, IInteractObject
{
    public Animator animator;
    public GameObject highLighObj;
    

    private void OnValidate()
    {
        animator = GetComponent<Animator>();
    }

    public void DisableInteract()
    {
        highLighObj.SetActive(false);
        animator.SetTrigger("close");
    }

    public GameObject GetGameObject()
    {
        return gameObject;
    }

    public void OnEnterInteract()
    {
        highLighObj.SetActive(true);
    }

    public void OnInteract()
    {
        animator.SetTrigger("open");
    }

}
