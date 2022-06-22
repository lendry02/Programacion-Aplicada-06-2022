using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EcoreManagerS2 : MonoBehaviour
{
    int _currentScore = 0;
    public TextMesh scoreText;

    public void increment()
    {
        _currentScore++;
        scoreText.text = _currentScore.ToString();
    }

}
