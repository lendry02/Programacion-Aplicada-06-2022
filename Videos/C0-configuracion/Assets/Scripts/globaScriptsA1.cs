using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globaScriptsA1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.Instance.PlayBackgroundMusic(AudioManager.BackgroundMusic.BackgroundMusic1);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.Fire1);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.Fire2);
        }
        if (Input.GetButtonDown("Fire3"))
        {
            AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.Fire3);
        }
        if (Input.GetButtonDown("Jump"))
        {
            AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.Jump);
        }

    }
}
