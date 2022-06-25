using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

   public static AudioManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    public enum SoundEffect
    {
        Fire1,
        Fire2,
        Fire3,
        Jump,
       
    }

    public enum BackgroundMusic
    {
        BackgroundMusic1
    }

    //componente que permite enlazar con archivo de uadio
    public AudioSource fire1Effect, fire2Effect, fire3Effect, jumpEffect, backgroundMusic, audioGlobal;

    public void PlaySoundEffect(SoundEffect type)
    {
        switch (type)
        {
            case SoundEffect.Fire1:
                fire1Effect.Play();
                break;
            case SoundEffect.Fire2:
                fire2Effect.Play();
                break;
            case SoundEffect.Fire3:
                fire3Effect.Play();
                break;
            case SoundEffect.Jump:
                jumpEffect.Play();
                break;

        }

    }

    public void PlayBackgroundMusic(BackgroundMusic type)
    {
        switch (type)
        {
            case BackgroundMusic.BackgroundMusic1:
                backgroundMusic.Play();
                break;
        }

    }
}
