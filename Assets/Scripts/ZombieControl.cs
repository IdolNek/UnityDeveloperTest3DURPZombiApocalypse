using UnityEngine;
using Opsive.UltimateCharacterController.Character;
using Opsive.UltimateCharacterController.Character.Abilities.AI;
using Opsive.UltimateCharacterController.Character.Abilities.Items;
using Unity.Mathematics;

public class ZombieControl : MonoBehaviour
{
    [SerializeField] private Transform _zombieTarget;
    [SerializeField] private float _attackDistance = 1.1f;
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
        if (Vector3.Distance(transform.position, _zombieTarget.position) < _attackDistance)
            _characterLocomotion.TryStartAbility(_useAbility);
        else
        {
            _navMeshAgentMovement.SetDestination(_zombieTarget.position);
            _characterLocomotion.TryStopAbility(_useAbility);
        }
    }
}
