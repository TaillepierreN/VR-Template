using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadPatManager : MonoBehaviour
{
    AudioSource _audioSource;
    Animator _shibaAnimator;
    void Start()
    {
        _shibaAnimator = gameObject.GetComponentInParent<Animator>();
        _audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        _audioSource.Play();
        _shibaAnimator.SetBool("isPatted", true);
        Debug.Log("patpat");
    }
    private void OnTriggerExit(Collider other)
    {
        _shibaAnimator.SetBool("isPatted", false);
    }
}
