using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooling : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }
    private Dictionary<string, Queue<GameObject>> poolingDictionary = new Dictionary<string, Queue<GameObject>>();

    [SerializeField] private List<Pool> poolList = new List<Pool>();

    private IPooledObj iPool = null;
    void Awake()
    {
        foreach (Pool pool in poolList)
        {
            Queue<GameObject> filaDeObjetos = new Queue<GameObject>();
            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                filaDeObjetos.Enqueue(obj);
                if (iPool != null)
                {
                    iPool = obj.GetComponent<IPooledObj>();
                }
                obj.SetActive(false);
            }
            poolingDictionary.Add(pool.tag,filaDeObjetos);
        }

    }

    public GameObject SpawnFromPool(string poolTag, Vector3 pos, Quaternion rot)
    {
        if (!poolingDictionary.ContainsKey(poolTag))
        {
            Debug.LogError("Tag não encontrada");
            return null;
        }
        
        
        GameObject pooledObj = poolingDictionary[poolTag].Dequeue();

        iPool?.OnSpawnedObject();
        
        pooledObj.SetActive(true);
        pooledObj.transform.position = pos;
        pooledObj.transform.rotation = rot;

        return pooledObj;
    }
    
}
