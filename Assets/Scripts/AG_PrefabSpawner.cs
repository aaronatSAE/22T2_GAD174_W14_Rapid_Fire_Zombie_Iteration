using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class AG_PrefabSpawner : MonoBehaviour
    {
        [SerializeField] private Transform[] anchors;
        [SerializeField] private GameObject[] prefabsToInstantiate;

        // Start is called before the first frame update
        void Start()
        {
            for (int i = 0; i < prefabsToInstantiate.Length; i++)
            {
                GameObject newAsset = Instantiate(prefabsToInstantiate[i], anchors[i].position, Quaternion.identity);
            }
        }
    }
}
