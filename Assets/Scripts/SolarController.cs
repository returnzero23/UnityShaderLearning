using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarController : MonoBehaviour
{
    private Transform m_Transform;
    // Start is called before the first frame update
    void Start()
    {
        m_Transform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //m_Transform.Rotate(new Vector3(0, 1, 0));
    }
}
