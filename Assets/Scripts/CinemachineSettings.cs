using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Cinemachine.CinemachineFreeLook), typeof(Cinemachine.CinemachineCollider))]
public class CinemachineSettings : MonoBehaviour
{
    void Start()
    {
        Cinemachine.CinemachineFreeLook cinemachine = GetComponent<Cinemachine.CinemachineFreeLook>();

        cinemachine.LookAt = FindObjectOfType<PlayerMovement>().gameObject.transform;
        cinemachine.Follow = FindObjectOfType<PlayerMovement>().gameObject.transform;
        cinemachine.m_BindingMode = Cinemachine.CinemachineTransposer.BindingMode.WorldSpace;

        Cinemachine.CinemachineCollider collider = GetComponent<Cinemachine.CinemachineCollider>();
        collider.m_CollideAgainst = LayerMask.GetMask("Ground");
        collider.m_IgnoreTag = "Player";
    }    
}
