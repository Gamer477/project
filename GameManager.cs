using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {
    bool gamehasended = false;
    public float restartdelay = 1f;
    public GameObject completelevelui;
    public void completelevel()
    {
        completelevelui.SetActive(true);
    }
	public void EndGame()
    {
       
        if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("Game Over");
            //Restart();
            Invoke("Restart", restartdelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
