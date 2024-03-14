using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] private float timeElapsed;
    [SerializeField] private int minutes, seconds;

    private void Update()
    {
        timeElapsed += Time.deltaTime;
        minutes = (int)(timeElapsed / 60f);
        seconds = (int)(timeElapsed - minutes*60f);

        text.text =string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
