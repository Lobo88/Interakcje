using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionScript : MonoBehaviour
{
    Interactable1 ObjectInteract;
    private bool CanTake=false;

    void Update()
    {
        if (Input.GetButtonDown("Fire3") && CanTake==true)
        {
            InteractWithInteractable();
        }
    }

    public void InteractWithInteractable()
    {
        ObjectInteract.Interact();
    }
    public void SubscribeInteract()
    {
        CanTake = true;
        Debug.Log("moge wziąć przedmiot");
    }
    public void UnsubscribeInteract()
    {
        CanTake = false;
        Debug.Log("nie mogę wziąc przedmiotu");
    }
}
