using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable1 : MonoBehaviour
{
    public GameObject player;
    public GameObject box;
    float MaxDistanceToPlayer=2;
  
    public virtual void Interact()
    {
        Debug.Log("destroy obj");
    }
    public virtual bool CanInteract()
    {
        return Vector3.Distance(this.transform.position, player.transform.position) <= MaxDistanceToPlayer;
        
        
    }

   
}
