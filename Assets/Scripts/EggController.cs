using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour
{
    Transform[] roadPos;
    float speed;
    int posIndex = 1;

    public void StartMove(Transform[] pos, float s)
    {
        roadPos = pos;
        speed = s;

        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        if (posIndex == roadPos.Length)
        {
            yield return new WaitForSeconds(speed);
            MicroGameController.instance.Hit();
            DestroyObject(gameObject);
        }
        else
        {
            yield return new WaitForSeconds(speed);
            transform.position = roadPos[posIndex].position;
            posIndex += 1;

            StartCoroutine(Move());
        }
    }
}
