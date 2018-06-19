using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuideGame : MonoBehaviour
{
    public float timeShow;
    public Text guidText;
    private bool isHide;

    private float timer;
    // Use this for initialization
    void Start()
    {
        isHide = true;
        timer = timeShow - 1f;
        guidText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isHide)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                guidText.enabled = true;
                timer = timeShow;
                isHide = false;
            }
        }
        else
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                guidText.enabled = false;
                this.enabled = false;
            }
        }
    }
}
