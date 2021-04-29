using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] GameObject consoleObject;
    GameObject consoleInWorld;
    PlayerMovement playerMovement;

    public static bool inGame = false;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();

        Cursor.lockState = CursorLockMode.Locked;
    }

    public void StartGame(GameObject console)
    {
        if (!inGame)
        {
            consoleInWorld = console;
            consoleInWorld.SetActive(false);
            consoleObject.SetActive(true);

            MicroGameController.instance.StartMicroGame();

            StartCoroutine(BoolChange());
        }
    }

    public void StopGame()
    {
        if (inGame)
        {
            MicroGameController.instance.StopMicroGame();

            consoleInWorld.SetActive(true);
            consoleObject.SetActive(false);
            consoleInWorld = null;

            playerMovement.IsMove = true;
            StartCoroutine(BoolChange());
        }
    }

    IEnumerator BoolChange()
    {
        yield return new WaitForSeconds(0.1f);
        inGame = !inGame;
    }
}
