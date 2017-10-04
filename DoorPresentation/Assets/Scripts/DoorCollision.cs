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
=======
    private Animator m_animator;
    private AudioSource m_sound;

    void Start()
    {
        m_animator = GetComponent<Animator>();
        m_sound = GetComponent<AudioSource>();
>>>>>>> b6f1b798b06b72feb962b88218f485b44748a764
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
<<<<<<< HEAD
            _animator.SetBool("open", true);
            _audio.Play();
=======
            m_animator.SetBool("open", true);
            m_sound.Play();
>>>>>>> b6f1b798b06b72feb962b88218f485b44748a764
        }
    }
}
