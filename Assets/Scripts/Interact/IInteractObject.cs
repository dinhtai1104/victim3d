using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
   **********************
	Author : Taii
	Company: SuperGame

   **********************
*/
public interface IInteractObject
{
	GameObject GetGameObject();
	void OnEnterInteract();
	void DisableInteract();
	void OnInteract();
}
