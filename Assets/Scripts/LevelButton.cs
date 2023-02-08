using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{
    [SerializeField] GameObject level2Button;
    [SerializeField] LatestLev scob;
    public int max;

    void Start()
    {
        max = scob.l;
        if (scob.l == 2 && max == 2)
        {
            level2Button.SetActive(true);
        }
    }

}
