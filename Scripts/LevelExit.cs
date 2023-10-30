using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 1f;
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            StartCoroutine(LoadNextLevel());
        }
    }
    
    IEnumerator LoadNextLevel()
    {
        yield return new WaitForSecondsRealtime(levelLoadDelay);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings - 1)
        {
            FindObjectOfType<GameSession>().ResetGameSession();
            //Debug.Log("next scene is final");
        }
        else
        {
            FindObjectOfType<ScenePersist>().ResetScenePersist(); 
            SceneManager.LoadScene(nextSceneIndex); 
            //Debug.Log("next scene is not final");
        }
    }
}
