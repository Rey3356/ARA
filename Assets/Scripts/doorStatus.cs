using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorStatus : MonoBehaviour
{
    Transform tr;
    Transform tri;
    [SerializeField] GameObject levelclearpan;
    [SerializeField] GameObject Canvas;
    public void Start()
    {
        tr = GetComponent<Transform>();
        tri = tr;
    }

    public void doorOpen()
    {
        tr.localPosition = new Vector3(-5.85f, 6.1f, -9.25f);
        tr.rotation = Quaternion.Euler(new Vector3(0, 28f, 0));
        StartCoroutine(WaitSeconds(1.5f));

    }

    IEnumerator WaitSeconds(float a)
    {
        yield return new WaitForSecondsRealtime(a);
        Canvas.SetActive(true);
        levelclearpan.SetActive(true);
    }
}
