using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DonotDestroy : MonoBehaviour
{
    public Text btnText;
    private const string pre = "pre", next = "next";
    private bool isforward = true;
    private void Awake()
    {
        GameObject.DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextScene() {
        Scene curScene = SceneManager.GetActiveScene();
        int sceneCount = SceneManager.sceneCountInBuildSettings;
        int nextIndex = 0;
        if (isforward) {
            nextIndex = (curScene.buildIndex + 1) % sceneCount;
            if (nextIndex == sceneCount - 1) {
                isforward = false;
                btnText.text = pre;
            }
        }
        else {
            nextIndex = (curScene.buildIndex - 1) % sceneCount;
            if (nextIndex == 1)
            {
                isforward = true;
                btnText.text = next;
            }
        }
        Debug.LogError("XBW  " + nextIndex);
        SceneManager.LoadScene(nextIndex, LoadSceneMode.Single);
    }
}
