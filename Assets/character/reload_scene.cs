using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reload_scene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            ReseTheGame();
    }

    public void ReseTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("Scene has reloaded");
    }
}
