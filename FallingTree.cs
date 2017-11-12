using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTree : MonoBehaviour {

    GameObject fallingTree;
    public int treeHealth = 5;
    private bool isFallen = false;
    public Transform woodSpawn;
    public float velocity;

    void Start()
    {
        fallingTree = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (treeHealth <= 0 && isFallen == false)
        {
            Rigidbody rb = fallingTree.AddComponent<Rigidbody>();
            rb.isKinematic = false;
            rb.useGravity = true;
            rb.AddForce(Vector3.forward, ForceMode.Impulse);
            velocity = rb.velocity.magnitude;
            isFallen = true;
        }

        if (isFallen)
        {
            StartCoroutine(fallenTree());
        }
    }

    private IEnumerator fallenTree()
    {
        yield return new WaitForSeconds(6);
        Destroy(fallingTree);
    }
}
