using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _spawnLocation;
    [SerializeField] private GameObject[] _prefab;

    TargetScript targetScript;

    private void Start()
    {
        StartCoroutine(Spawner1());
        StartCoroutine(Spawner2());
    }

    IEnumerator Spawner1()
    {
        while (true)
        {
            int _randomLocation = Random.Range(0, _spawnLocation.Length);
            int _randomPrefab = Random.Range(0, _prefab.Length);
            int _randomTime = Random.Range(0, 5);
            int _randomSpeed = Random.Range(1, 15);

            yield return new WaitForSeconds(_randomTime);
            
            GameObject clone =Instantiate(_prefab[_randomPrefab],_spawnLocation[_randomLocation].transform.position,Quaternion.identity);
            targetScript = clone.GetComponent<TargetScript>();

            if (_randomLocation % 2 ==1)
            {
                targetScript.speed = -_randomSpeed;
            }
            else
            {
                targetScript.speed = _randomSpeed;
            }

            Destroy(clone,20f);
        }
    }

    IEnumerator Spawner2()
    {
        while (true)
        {
            int _randomLocation = Random.Range(0, _spawnLocation.Length);
            int _randomPrefab = Random.Range(0, _prefab.Length);
            int _randomTime = Random.Range(0, 8);
            int _randomSpeed = Random.Range(1, 15);

            yield return new WaitForSeconds(_randomTime);

            GameObject clone = Instantiate(_prefab[_randomPrefab], _spawnLocation[_randomLocation].transform.position, Quaternion.identity);
            targetScript = clone.GetComponent<TargetScript>();

            if (_randomLocation % 2 == 1)
            {
                targetScript.speed = -_randomSpeed;
            }
            else
            {
                targetScript.speed = _randomSpeed;
            }
        }
    }


}
