using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Opsive.UltimateCharacterController.Character;
using Opsive.UltimateCharacterController.Character.Abilities;
using Opsive.UltimateCharacterController.Character.Abilities.AI;
using Opsive.UltimateCharacterController.Character.Abilities.Items;

public class ZombieControl : MonoBehaviour
{
    [SerializeField] private Transform _zombieTarget;
    private UltimateCharacterLocomotion _characterLocomotion;
    private NavMeshAgentMovement _navMeshAgentMovement;
    private Use _useAbility;
    private void Start()
    {
        _characterLocomotion = GetComponent<UltimateCharacterLocomotion>();
        _navMeshAgentMovement = _characterLocomotion.GetAbility<NavMeshAgentMovement>();
        _useAbility = _characterLocomotion.GetAbility<Use>();
    }
    private void Update()
    {
        _navMeshAgentMovement.SetDestination(_zombieTarget.position);
        if (Vector3.Distance(transform.position, _zombieTarget.position) < 1.1f)
        {
            _characterLocomotion.TryStartAbility(_useAbility);
        }
    }
}
