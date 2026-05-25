using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroTextScr : MonoBehaviour
{
    float startTime = 0f;
    public GameObject introText;
    // Start is called before the first frame update
    void Start()
    {
        startTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        startTime += Time.deltaTime;
        introText.SetActive(true);
        if (startTime > 3)
        {
            introText.SetActive(false);
        }
    }
}
