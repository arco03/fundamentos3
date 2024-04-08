using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] GameObject GameOverUI;
    [SerializeField] GameObject TimeUI;

    [SerializeField] TMP_Text record;
    [SerializeField] TMP_Text current;

    public void ShowGameOver(string recordText, string currentText)
    {
        GameOverUI.SetActive(true);
        TimeUI.SetActive(false);
        record.text = recordText;
        current.text = currentText;
    }

    public void Change(string Name)
    {
        SceneManager.LoadScene(Name);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Saliste del Juego");
    }

}
