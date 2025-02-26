using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _pipes;
    [SerializeField] private float _spawnTime = 2.5f;
    [SerializeField] private float _height = 1f;

    private void Start() 
    {
        StartCoroutine(SpawnPipes());    
    }
    private IEnumerator SpawnPipes()
    {
        while(true)
        {
            Instantiate(_pipes,new Vector3(5.3f,Random.Range(-_height,_height),0f),Quaternion.identity);
            yield return new WaitForSeconds(_spawnTime);
        }
    }
}
