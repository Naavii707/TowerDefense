using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private float _spawnInterval = 5f;
    [SerializeField]
    private float _spawnRadius = 10f;
    [SerializeField]
    private float _positionY = 0f;
    [SerializeField]
    private UnityEvent<Vector3> _instantiateZombie;

    public void Initialize()
    {
        StartCoroutine(SpawnEnemies());
    }

    public void Stop()
    {
        StopAllCoroutines();
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            Vector2 direction = Random.insideUnitCircle.normalized;
            Vector3 spawnPosition = new Vector3(direction.x * _spawnRadius, 0f, direction.y * _spawnRadius);
            spawnPosition.y = _positionY;
            _instantiateZombie?.Invoke(spawnPosition);
            yield return new WaitForSeconds(_spawnInterval);
        }
    }
}
