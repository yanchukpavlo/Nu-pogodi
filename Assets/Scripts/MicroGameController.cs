using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class MicroGameController : MonoBehaviour
{
    public static MicroGameController instance;

    [SerializeField] float delayBetweenSpawn = 2f;
    [SerializeField] float gameSpeed = 2f;
    [SerializeField] GameObject eggPref;
    [SerializeField] Text pointText;
    [SerializeField] GameObject[] hpObj;
    int hp = 3;
    int point = 0;

    [SerializeField] GameObject boxObj;
    [SerializeField] GameObject[] buttonsObj;
    [SerializeField] Transform[] boxPos;
    [SerializeField] ExtraArray roads;

    private void Awake()
    {
        instance = this;
    }


    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Q))
    //    {
    //        boxObj.transform.position = boxPos[0].position;
    //        StartCoroutine(ButtonPos(buttonsObj[0]));
    //    }
    //    else if (Input.GetKeyDown(KeyCode.A))
    //    {
    //        boxObj.transform.position = boxPos[1].position;
    //        StartCoroutine(ButtonPos(buttonsObj[1]));
    //    }
    //    else if (Input.GetKeyDown(KeyCode.W))
    //    {
    //        boxObj.transform.position = boxPos[2].position;
    //        StartCoroutine(ButtonPos(buttonsObj[2]));
    //    }
    //    else if (Input.GetKeyDown(KeyCode.S))
    //    {
    //        boxObj.transform.position = boxPos[3].position;
    //        StartCoroutine(ButtonPos(buttonsObj[3]));
    //    }
    //}

    public void OnInteraction(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if (GameManager.inGame) GameManager.instance.StopGame();
        }
    }
    
    public void OnMicroGameControl(InputAction.CallbackContext context)
    {
        if (context.started && GameManager.inGame)
        {
            Vector2 vector = context.ReadValue<Vector2>();

            if (vector.y == 1)
            {
                boxObj.transform.position = boxPos[0].position;
                StartCoroutine(ButtonPos(buttonsObj[0]));
            }
            else if (vector.y == -1)
            {
                boxObj.transform.position = boxPos[1].position;
                StartCoroutine(ButtonPos(buttonsObj[1]));
            }
            else if (vector.x == -1)
            {
                boxObj.transform.position = boxPos[2].position;
                StartCoroutine(ButtonPos(buttonsObj[2]));
            }
            else if (vector.x == 1)
            {
                boxObj.transform.position = boxPos[3].position;
                StartCoroutine(ButtonPos(buttonsObj[3]));
            }
        }
    }

    public void StartMicroGame()
    {
        foreach (var item in hpObj)
        {
            item.SetActive(true);
        }
        hp = 3;
        point = 0;
        pointText.text = point.ToString();

        StartCoroutine(EggSpawn());
    }

    IEnumerator EggSpawn()
    {
        yield return new WaitForSeconds(delayBetweenSpawn);

        int r = Random.Range(0, roads.groups.Length);
        GameObject egg = Instantiate(eggPref, roads.groups[r].pos[0].position, Quaternion.identity);
        var controller = egg.AddComponent<EggController>();
        controller.StartMove(roads.groups[r].pos, gameSpeed);

        StartCoroutine(EggSpawn());
    }

    IEnumerator ButtonPos(GameObject obj)
    {
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, 
            obj.transform.localPosition.y, obj.transform.localPosition.z - 0.25f);

        yield return new WaitForSeconds(0.1f);

        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x,
            obj.transform.localPosition.y, obj.transform.localPosition.z + 0.25f);
    }


    public void StopMicroGame()
    {
        StopAllCoroutines();

        foreach (var egg in FindObjectsOfType<EggController>())
        {
            Destroy(egg.gameObject);
        }
    }

    public void AddPoint()
    {
        point += 1;
        pointText.text = point.ToString();
    }

    public void Hit()
    {
        hpObj[hpObj.Length - hp].SetActive(false);
        hp--;

        if (hp == 0) StopMicroGame();
    }
}
