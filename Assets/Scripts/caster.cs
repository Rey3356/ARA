using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class caster : MonoBehaviour
{
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hitInfo))    //, out hitInfo))// && hitInfo.transform.gameObject.CompareTag("Keypad"))
        {
            Debug.Log(hitInfo.collider.gameObject.name);
        }
    }
}
