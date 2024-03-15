using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void Change(string Name)
    {
        SceneManager.LoadScene(Name);
    }
}
