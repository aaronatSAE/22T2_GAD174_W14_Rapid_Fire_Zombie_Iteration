using UnityEngine;
using System.Collections;

public class OrbBehaviour : MonoBehaviour
{

    [SerializeField] private float howFastItTurns;
    [SerializeField] private float bobHeight;
    [SerializeField] private float bobFrequency;

    
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    // Use this for initialization
    void Start()
    {
        posOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //spin
        transform.Rotate(new Vector3(0f, Time.deltaTime * howFastItTurns, 0f), Space.World);

        // bob up and down
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * bobFrequency) * bobHeight;

        transform.position = tempPos;
    }
}