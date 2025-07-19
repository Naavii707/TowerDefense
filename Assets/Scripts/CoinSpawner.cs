using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField]
    private float _radius = 0.2f;
    [SerializeField]
    private float _spawnRate = 2f;
    [SerializeField]
    private float _positionY = 0f;

    [SerializeField]
    private UnityEvent<Vector3> _instantiateCoin;
    private Coroutine _spawnCoroutine;
    public void Initialize()
    {
        _spawnCoroutine = StartCoroutine(SpawnCoins());
    }

    public void Stop()
    {
        if (_spawnCoroutine != null)
        {
            StopCoroutine(_spawnCoroutine);
            _spawnCoroutine = null;
        }
    }

    private IEnumerator SpawnCoins()
    {
        while (true)
        {
            Vector3 randomPosition = Random.insideUnitSphere * _radius;
            randomPosition.y = _positionY;
            _instantiateCoin?.Invoke(randomPosition);
            yield return new WaitForSeconds(_spawnRate);
        }
    }
}
