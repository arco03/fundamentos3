using UnityEngine;

public class Quit : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Saliste del Juego");
    }
}
