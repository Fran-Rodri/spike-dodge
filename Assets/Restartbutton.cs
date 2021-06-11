using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Restartbutton : MonoBehaviour
{
    public void recomecar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void newGame()
    {
        SceneManager.LoadScene(1);
    }
    public void VoltarParaMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void quit()
    {
        Application.Quit();
    }





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
