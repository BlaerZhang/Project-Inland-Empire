using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartCurrentScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
