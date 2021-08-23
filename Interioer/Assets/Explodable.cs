using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explodable : MonoBehaviour {
    [SerializeField] private GameObject explodedPrefab;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    void Explode() {
        Instantiate(explodedPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision col) {
        if (col.gameObject.CompareTag("Projectile")) {
            Explode();
            Debug.Log("Collision!");
        }
    }
}
