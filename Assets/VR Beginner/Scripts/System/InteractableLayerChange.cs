using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InteractableLayerChange : MonoBehaviour
{
    public UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable TargetInteractable;
    public LayerMask NewLayerMask;

    public void ChangeLayerDynamic(UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable interactable)
    {
        //interactable.interactionLayers = NewLayerMask;
    }

    public void ChangeLayer()
    {
        //TargetInteractable.interactionLayerMask = NewLayerMask;
    }
}
