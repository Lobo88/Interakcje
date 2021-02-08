using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : Interactable1
{
 
    public override bool CanInteract()
    {
        
        return base.CanInteract();
    }

    public override bool Equals(object other)
    {
        return base.Equals(other);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override void Interact()
    {
        
    }

    public override string ToString()
    {
        return base.ToString();
    }
    
    private  void OnTriggerEnter(Collider other)
    {
        if (CanInteract() == true && other.name=="Player")
        {
            other.SendMessage("SubscribeInteract");
            Debug.Log("przedmiot");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        CanInteract();
        other.SendMessage("UnsubscribeInteract");
        Debug.Log("brak przedmiotu");
    }
}
