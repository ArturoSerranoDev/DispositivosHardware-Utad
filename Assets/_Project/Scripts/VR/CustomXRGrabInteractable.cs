using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CustomXRGrabInteractable : XRGrabInteractable
{
    protected override void OnActivate(XRBaseInteractor interactor)
    {
        base.OnActivate(interactor);
        this.GetComponent<Renderer>().material.color = Random.ColorHSV();
    }

}
