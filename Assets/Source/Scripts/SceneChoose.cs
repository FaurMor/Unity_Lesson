using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChoose : MonoBehaviour
{
    public void Load(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
