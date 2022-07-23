using UnityEngine;

public class ScoreScripts : MonoBehaviour
{
    int _currentScore = 0;
    int _vidas = 8;
    int _velocidad = 10;
    public bool activarAceleracion = false;
    public TextMesh scoreText,vidaText;

    float segundos = 0.0f;
    private void Update()
    {
        if (activarAceleracion)
        {
            segundos += Time.deltaTime;
            this.incrementarVelocidad(5);

        }

    }

    public void increment()
    {
        _currentScore++;
        scoreText.text = _currentScore.ToString();
    }

    public void incrementarVida()
    {
        _vidas++;
        vidaText.text = _vidas.ToString();
    }

    public void descrementarVida()
    {
        _vidas--;
        vidaText.text = _vidas.ToString();
    }

    public int GetVelocidad()
    {
        return _velocidad;
    }

    public void incrementarVelocidad(int duracion)
    {
  
        if (segundos <= duracion)
        {
            _velocidad = 20;
        }
        if (segundos >= duracion)
        {
            _velocidad = 10;
            activarAceleracion = false;
            segundos = 0;

        }
        
    }
}
