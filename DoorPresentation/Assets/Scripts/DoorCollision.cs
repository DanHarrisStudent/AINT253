using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollision : MonoBehaviour
{
<<<<<<< HEAD
    private Animator _animator;
    private AudioSource _audio;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _audio = GetComponent<AudioSource>();
    }

=======

    private Animator _animator;
    private AudioSource _audio;
>>>>>>> f265fb204ac87d0bbf921776891b75f6f6c2f84d
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
<<<<<<< HEAD
        {
            _animator.SetBool("open", true);
            _audio.Play();
=======
        {        

>>>>>>> f265fb204ac87d0bbf921776891b75f6f6c2f84d
            m_animator.SetBool("open", true);
            m_sound.Play();
        }
    }
}
