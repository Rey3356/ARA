using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class touchInteraction : MonoBehaviour
{
    [SerializeField] GameObject Canvas;
    [SerializeField] GameObject KeyPadUI;
    [SerializeField] GameObject interactor;
    [SerializeField] GameObject doorframe;
    [SerializeField] GameObject locked_pan;
    public AnimationCurve shake_curve;
    public float duration = 1f;
    bool start;

    void Start()
    {
        start = false;
        locked_pan.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(Canvas.activeSelf == false)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out RaycastHit hitInfo);
            if (Input.GetMouseButtonDown(0))
            {
                if (hitInfo.collider?.tag == "Keypad")
                {
                    Canvas.SetActive(true);
                    KeyPadUI.SetActive(true);
                }

                if (hitInfo.collider?.tag == "painting" || hitInfo.collider?.tag == "note")
                {
                    Canvas.SetActive(true);
                    interactor.SetActive(true);
                }

                if (hitInfo.collider?.tag == "door" && Canvas.activeSelf == false)
                {
                    start = true;
                    if (start == true)
                    {
                        start = false;
                        StartCoroutine(shaking());
                    }
                }
            }

        }
        
    }

    IEnumerator shaking()
    {
        Vector3 startPos = doorframe.GetComponent<Transform>().position;
        float elapsed_time = 0f;

        while(elapsed_time < duration)
        {
            elapsed_time += Time.deltaTime;
            float strength = shake_curve.Evaluate(elapsed_time / duration);
            doorframe.GetComponent<Transform>().position = startPos + Random.insideUnitSphere * strength;
            locked_pan.SetActive(true);
            yield return null;
        }

        doorframe.GetComponent<Transform>().position = startPos;
        locked_pan.SetActive(false);
    }
}
