using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] LatestLev scob;
    public void LoadLatest()
    {
        if (scob.l == 0)
        {
            scob.l = 1; 
        }
        SceneManager.LoadScene(scob.l);
    }
    public void LevelLoad(int a)
    {
        if(a != 0)
        {
            SceneManager.LoadScene(a);
        }
        
    }
    public void HomeLoad()
    {
        SceneManager.LoadScene(0);
    }
}
