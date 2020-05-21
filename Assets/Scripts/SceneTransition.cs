using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{

    public string nextSceneName;

    public string spawnName;

    private GameManager gamemanager;

    public Animator transition;

    public float transitionTime = .2f;

    void Awake()
    {
        if (nextSceneName == null)
        {
            Debug.Log("Must set Scene name");
            return;
        }
    }

    void Start()
    {
        GameObject[] gameObjects;
        gameObjects = GameObject.FindGameObjectsWithTag("GameManager");
        gamemanager = gameObjects[0].GetComponent<GameManager>();

        transition = GetComponent<Animator>();
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit something");
        if (collision.name == "Player")
        {
            Debug.Log("Hit Player");

            gamemanager.spawnName = this.spawnName;

            transition.SetTrigger("StartScene");
            SceneManager.LoadScene(nextSceneName);
        }
    }

    /*
    IEnumerator LoadLevel()
    {
        Debug.Log("Transitioning scene");
        transition.SetTrigger("StartScene");

        yield return new WaitForSeconds(transitionTime);

        Debug.Log("Finished Waiting");

        SceneManager.LoadScene(nextSceneName);

        Debug.Log("Transitioned");
    }
    */
}


