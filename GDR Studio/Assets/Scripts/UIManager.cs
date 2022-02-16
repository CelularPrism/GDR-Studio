using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text textScore;
    [SerializeField] private GameObject restartBtn;

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SetRestart()
    {
        restartBtn.SetActive(true);
    }

    public void SetTextScore(string text)
    {
        int index = textScore.text.IndexOf(" ") + 1;
        textScore.text = textScore.text.Substring(0, index);
        textScore.text += text;
    }
}
