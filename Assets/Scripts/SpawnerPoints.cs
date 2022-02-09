using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPoints : MonoBehaviour
{
    [SerializeField] private Enemy _tempMob;
    [SerializeField] private int _numberMobs;
    [SerializeField] private Transform[] _points;

    private void Start()
    {
        StartCoroutine(SpawnMob());
    }

    private IEnumerator SpawnMob()
    {
        var waitForTwoSeconds = new WaitForSeconds(2);

        for (int i = 0; i < _numberMobs; i++)
        {
            Instantiate(_tempMob, _points[Random.Range(0, _points.Length)].position, Quaternion.identity);

            yield return waitForTwoSeconds;
        }
    }
}
