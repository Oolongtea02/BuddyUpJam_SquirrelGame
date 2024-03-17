using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] footstep = new AudioClip[3];

    [SerializeField]
    private AudioClip[] push = new AudioClip[2];

    public AudioSource footstepSource1;
    public AudioSource footstepSource2;
    [HideInInspector]
    public AudioSource activeFootstepSource;

    public AudioSource pushSource;

    [HideInInspector]
    public float timeSinceLastFootstep;

    void Start()
    {
        footstepSource1.volume = 0.6f;
        footstepSource2.volume = 0.6f;
        activeFootstepSource = footstepSource1;
        
    }
    public void PlaySFX_Footstep()
    {
        if (!(Time.time - timeSinceLastFootstep >= 0.5f))
        {
            return;
        }

        if (activeFootstepSource == footstepSource1)
        {
            activeFootstepSource = footstepSource2;
        }
        else
        {
            activeFootstepSource = footstepSource1;
        }

        int num = Random.Range(0, footstep.Length - 1);

        activeFootstepSource.clip = footstep[num];
        activeFootstepSource.pitch = Random.Range(0.7f, 1.3f);
        activeFootstepSource.Play();

        timeSinceLastFootstep = Time.time;
    }

    public void PlaySFX_Push()
    {
        int num = Random.Range(0, push.Length - 1);

        pushSource.clip = push[num];
        pushSource.pitch = Random.Range(0.9f, 1.1f);
        pushSource.Play();
    }
}
