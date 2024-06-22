using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [SerializeField] public List<AudioClip> SE;
    [SerializeField] public List<AudioClip> BGM;

    private AudioSource[] BGM_Sources = new AudioSource[2];
    private AudioSource[] SE_Sources = new AudioSource[16];




    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        // BGM�p AudioSource�ǉ�
        BGM_Sources[0] = gameObject.AddComponent<AudioSource>();
        BGM_Sources[1] = gameObject.AddComponent<AudioSource>();

        // SE�p AudioSource�ǉ�
        for (int i = 0; i < SE_Sources.Length; i++)
        {
            SE_Sources[i] = gameObject.AddComponent<AudioSource>();

        }
    }
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayBGM(int BGMnum, float volume, bool loop)
    {
        BGM_Sources[0].loop = loop;
        BGM_Sources[0].clip = BGM[BGMnum];
        BGM_Sources[0].volume = volume;
        BGM_Sources[0].Play();
    }

    public void PlaySE(int SEnum, float volume = 1.0f)
    {
        foreach (AudioSource source in SE_Sources)
        {
            if (source.isPlaying)
                continue;
            source.clip = SE[SEnum];
            source.volume = volume;
            source.Play();
            break;
        }
    }

    public void StopBGM()
    {
        BGM_Sources[0].Stop();
        BGM_Sources[1].Stop();
        BGM_Sources[0].clip = null;
        BGM_Sources[1].clip = null;
    }

    public void StopSE()
    {
        foreach (AudioSource source in SE_Sources)
        {
            source.Stop();
            source.clip = null;
        }
    }
}

