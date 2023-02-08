using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Pass_listen : MonoBehaviour
{
    public GameObject pass_entry;
    [SerializeField] GameObject door;
    [SerializeField] AudioSource AUD;
    [SerializeField] LatestLev scob;
    TextMeshProUGUI tmp;
    public int wordLim;
    int limit;
    int c;
    public bool level_Cleared;
    void Start()
    {
        tmp = pass_entry.GetComponent<TextMeshProUGUI>();
        level_Cleared = false;
        if (SceneManager.GetActiveScene().name == "Level 1")
        {
            limit = 3;// for level 1
        }
        if (SceneManager.GetActiveScene().name == "Level 2")
        {
            limit = 5;// for level 1
        }


        wordLim = limit;
        c = 0;
    }
    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "Level 1" && tmp.text == "DOG" && c==0)
        {
            level_Cleared = true;
            AUD.Play();
            scob.TakeValue(2);
            CanvasCloser();
            door.GetComponent<doorStatus>().doorOpen();

            c++;
        }
        if (SceneManager.GetActiveScene().name == "Level 2" && tmp.text == "MARCH" && c == 0)
        {
            level_Cleared = true;
            AUD.Play();
            CanvasCloser();
            door.GetComponent<doorStatus>().doorOpen();
            c++;
        }

    }

    public void Passwrite(string a)
    {
        if(wordLim != 0 && wordLim <= limit)
        {
            tmp.text += a;
            wordLim -= 1;
        }

    }

    public void passdel()
    {
        if(wordLim != limit)
        {
            tmp.text = tmp.text.Remove(tmp.text.Length - 1);
            wordLim += 1;
        }
    }

    void CanvasCloser()
    {
        GameObject.FindGameObjectWithTag("keyCan").SetActive(false);
        GameObject.FindGameObjectWithTag("canvas").SetActive(false);
    }

}
