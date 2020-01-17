using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
public class LoadLeve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadLev(string _name)
    {
        SceneManager.LoadScene(_name);
    }
    public void Quit()
    {
        Application.Quit();
        //EditorApplication.Exit(0);
    }
}
