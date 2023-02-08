using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelNo : MonoBehaviour
{
    TextMeshProUGUI Text;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text += SceneManager.GetActiveScene().name;
    }

}
