﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionController : MonoBehaviour
{

    public XRController rightTeleportRay;

    public InputHelpers.Button teleportActivationButton;
    public float activationThreshold = 1.0f;


    // Update is called once per frame
    void Update()
    {
        if (rightTeleportRay)
        {
            rightTeleportRay.gameObject.SetActive(CheckIfActivated(rightTeleportRay));
        }
    }

    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportActivationButton, out bool isActivated, activationThreshold);
        return isActivated;

    }

}
