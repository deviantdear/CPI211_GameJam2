using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUP : Interactable
{
    public override void Interact()
    {
        base.Interact();

        PickUp();
 
    }

    void PickUp()
    {
        Debug.Log("Picking Up item");
    }
}
