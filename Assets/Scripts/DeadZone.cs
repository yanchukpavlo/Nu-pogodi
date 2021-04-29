using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
            other.gameObject.transform.position = new Vector3(0, 3, 0);
            other.gameObject.SetActive(true);
            //Debug.Log("coll");
        }
    }
}
