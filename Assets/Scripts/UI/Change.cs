using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{
    public void ChangeEscene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
