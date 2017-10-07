using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollision : MonoBehaviour
{
    private Animator _animator;
    private AudioSource _audio;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _audio = GetComponent<AudioSource>();
    }

    private Animator m_animator;
    private AudioSource m_sound;

    void start()
    {
        m_animator = GetComponent<Animator>();
        m_sound = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _animator.SetBool("open", true);
            _audio.Play();
            m_animator.SetBool("open", true);
            m_sound.Play();
        }
    }
}
