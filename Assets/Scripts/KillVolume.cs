using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillVolume : MonoBehaviour
{
    [SerializeField] AudioClip Explode = null;
    AudioSource audioSource = null;


    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        //turn off gameObject that entered
        //other.gameObject.SetActive(false);
        PlayerController playerController = other.GetComponent<PlayerController>();
        if(playerController != null)
        {
            playerController.Die();
            audioSource.clip = Explode;
            audioSource.Play();
        }
    }
}
