using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField] private SceneController sceneController;
    [SerializeField] private LayerMask layer;
    void Start()
    {
        sceneController = transform.parent.GetComponent<SceneController>();
    }

    void Update()
    {
        Collider2D[] colliders = Physics2D.OverlapBoxAll(transform.position, transform.localScale, 0f, layer);

        if (colliders.Length > 0)
        {
            foreach (Collider2D collider in colliders)
                sceneController.UpdateScore(collider.gameObject);
        }
    }
}
