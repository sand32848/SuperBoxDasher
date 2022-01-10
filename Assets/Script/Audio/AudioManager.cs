using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.Audio;
using UnityEngine;
using DG.Tweening;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;   
    public static  AudioManager  instance;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        foreach(Sound s in sounds)
		{
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
		}
    }

    public void Play(string name, float volume = 0.39f)
	{
        Sound s = Array.Find(sounds, sound => sound.name == name);
        DOTween.To(() => s.source.volume, x => s.source.volume = x, volume, 1f);
        if (s == null)
		{
            return;
		}
        s.source.Play();
	}

    public void LerpMute(string name)
	{
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            return;
        }
        DOTween.To(()=> s.source.volume, x=> s.source.volume = x, 0,1f);
    }

	private void Start()
	{
        Play("MainTheme",0.15f);
	}


}


[System.Serializable]
public class Sound
{
    public string name;

    public AudioClip clip;

    [Range(0f,1f)]
    public float volume;
    [Range(.1f, 3f)]
    public float pitch;

    public bool loop;

    [HideInInspector]
    public AudioSource source;
}
