using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class charLeft : MonoBehaviour
{
    [SerializeField] GameObject passPanel;
    TextMeshProUGUI Text;
    int length;
    string str1;
    string str2;
    string str_final;
    private void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();
        length = Text.text.Length;
        str1 = Text.text.ToString();
        
    }
    private void Update()
    {
        str2 = passPanel.GetComponent<Pass_listen>().wordLim.ToString();
        str_final = str1.Remove(str1.Length - 1, 1) + str2;
        Text.SetText(str_final);
    }
}
