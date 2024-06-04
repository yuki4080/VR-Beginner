using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor))]
public class TriggerAnimationEvent : MonoBehaviour
{
    public string TriggerName;

    int m_TriggerID;
    
    void Start()
    {
        m_TriggerID = Animator.StringToHash(TriggerName);
        var interactor = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor>();
        interactor.selectEntered.AddListener(TriggerAnim);
    }

    public void TriggerAnim(SelectEnterEventArgs args)
    {
        var interactable = args.interactableObject;
        var animator = interactable.transform.GetComponentInChildren<Animator>();

        if (animator != null)
        {
            animator.SetTrigger(TriggerName);
        }

        //interactable.interactionLayers &= ~(1<<LayerMask.NameToLayer("Hands"));
    }
}
