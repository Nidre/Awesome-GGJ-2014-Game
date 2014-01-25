﻿using UnityEngine;
using System.Collections;

public class uberAwesomeMogaMecha : MonoBehaviour {

    public int id = -1;
    Spawner spawner;
    NetworkingServer ns;

    void Start()
    {
        spawner = GameObject.Find("Spawner").GetComponent<Spawner>();
        ns = GameObject.Find("Networking").GetComponent<NetworkingServer>();
    }

    void OnEnable()
    {
        if (!ns.isServer)
        {
            id = int.Parse(System.DateTime.Now.ToString("yyMMddhhmmssff"));
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        spawner.RemoveObject(gameObject);
        Destroy(gameObject);
    }
}
