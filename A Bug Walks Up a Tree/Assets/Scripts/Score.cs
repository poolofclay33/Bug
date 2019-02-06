using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public TMP_Text timerText;
    private float secondsCount;

    private void Update()
    {
        secondsCount += Time.deltaTime;

        timerText.text = (int)secondsCount + "";
    }
}
