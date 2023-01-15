using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHitEvent : MonoBehaviour
{
    [SerializeField] private float _onDamagedHitForce;
    [SerializeField] private float _onDiedHitForce;
    private Rigidbody _rigidbody;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    public void OnZombieDamaged()
    {
        Debug.Log("Получил урон");
        _rigidbody.AddForce(Vector3.back * _onDamagedHitForce, ForceMode.Force);
    }
    public void OnZombieDied()
    {
        Debug.Log("Died");
        _rigidbody.AddForce(Vector3.back * _onDamagedHitForce, ForceMode.Force);
    }
}
