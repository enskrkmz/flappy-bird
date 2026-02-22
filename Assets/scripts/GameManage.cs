using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManage : MonoBehaviour
{
    
    public Birdy control;
    public int score;
    public TextMeshProUGUI scoreText;
    void Start()
    {
        score = 0;
      
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void MenuGame()
    {
        SceneManager.LoadScene(0);
    }
}
