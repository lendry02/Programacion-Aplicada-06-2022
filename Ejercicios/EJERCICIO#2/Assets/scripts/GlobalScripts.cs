using UnityEngine;

public class GlobalScripts : MonoBehaviour
{
    int _score = 0;
    public TextMesh Score;

    public void increment() 
    {
        _score++;
        Score.text = _score.ToString();
    }


}
