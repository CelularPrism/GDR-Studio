using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private Transform field;
    [SerializeField] private UIManager uiManager;

    private int score = 0;

    private void Update()
    {
        if (field.childCount == 0)
        {
            uiManager.SetRestart();
        }
    }

    public void UpdateScore(GameObject gameObject)
    {
        score++;
        uiManager.SetTextScore(score.ToString());
        Destroy(gameObject);
    }
}
