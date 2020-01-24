using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BgmController : MonoBehaviour
{
    public AudioSource nomalSource;
    public AudioSource ufoSurce;
    public double FadeInSeconds = 1.0;
    double FadeDeltaTime = 0;

    public static bool ufoBgm;


    // Start is called before the first frame update
    void Start()
    {
        ufoSurce.volume = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (ufoBgm)
        {
            FadeDeltaTime += Time.deltaTime;
            if (FadeDeltaTime >= FadeInSeconds)
            {
                FadeDeltaTime = FadeInSeconds;
            }
            nomalSource.volume = (float)(1.0 - FadeDeltaTime / FadeInSeconds);

            FadeDeltaTime += Time.deltaTime;
            if (FadeDeltaTime >= FadeInSeconds)
            {
                FadeDeltaTime = FadeInSeconds;
            }
            ufoSurce.volume = (float)(FadeDeltaTime / FadeInSeconds);
        }
        else
        {
            FadeDeltaTime += Time.deltaTime;
            if (FadeDeltaTime >= FadeInSeconds)
            {
                FadeDeltaTime = FadeInSeconds;
            }
            ufoSurce.volume = (float)(1.0 - FadeDeltaTime / FadeInSeconds);

            FadeDeltaTime += Time.deltaTime;
            if (FadeDeltaTime >= FadeInSeconds)
            {
                FadeDeltaTime = FadeInSeconds;
            }
            nomalSource.volume = (float)(FadeDeltaTime / FadeInSeconds);
        }
    }
}
