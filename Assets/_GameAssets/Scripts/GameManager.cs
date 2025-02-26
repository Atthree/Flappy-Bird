using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _highScoreText;
    [SerializeField] private Button _replayButton;
    private int _score;

    private void Start()
    {
        _replayButton.onClick.AddListener(() =>
        {
            ResetGame();
        });
        _score = 0;
        _scoreText.text = _score.ToString();
        _highScoreText.text = "High Score : " + PlayerPrefs.GetInt("highScore");

    }
    public void IncreaseScore()
    {
        _score++;
        _scoreText.text = _score.ToString();

        if (_score > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", _score);
            _highScoreText.text = "High Score : " + PlayerPrefs.GetInt("highScore");
        }
    }
    private void ResetGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
