using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShibaManager : MonoBehaviour
{
    NavMeshAgent _agent;
    [SerializeField] Transform _destination;
    Animator _animator;
    AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _audioSource = GetComponent<AudioSource>();
        _animator = GetComponent<Animator>();
        _agent.SetDestination(_destination.position);

    }

    // Update is called once per frame
    void Update()
    {
        if(_agent.remainingDistance < 1f && _agent.remainingDistance !=0)
        {
        _audioSource.Play();
        _animator.SetBool("isRunning", false);
        _agent.isStopped = true;        
        }
        else
        {
        _agent.isStopped = false;        
        _animator.SetBool("isRunning", true);        
            
        }
        _agent.SetDestination(_destination.position);
    }
}
