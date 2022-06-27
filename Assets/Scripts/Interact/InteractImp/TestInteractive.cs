using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
   **********************
	Author : Taii
	Company: SuperGame

   **********************
*/

public class TestInteractive : MonoBehaviour, IInteractObject
{
    public GameObject highLighObject;
    private Vector3 originPos;
    private void Start()
    {
        originPos = transform.position;
    }
    public void DisableInteract()
    {
        highLighObject.SetActive(false);
        transform.position = originPos;
    }

    public GameObject GetGameObject()
    {
        return gameObject;
    }

    public void OnEnterInteract()
    {
        highLighObject.SetActive(true);
    }

    public void OnInteract()
    {
        Debug.Log("Interact!!!!");
        transform.position += Vector3.up;
    }
}
