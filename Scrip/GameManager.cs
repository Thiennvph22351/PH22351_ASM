using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{   
    public TextMeshProUGUI scoreText;
    [SerializeField] private int score;
    public void Start(){
        LoadGame();
        SetScoreText();
    }
    public void SaveGame(){
        string maHoa = Extension.Encrypt(score.ToString(),"truongnxph42284");
        PlayerPrefs.SetString("diem",maHoa);
    }
    public void LoadGame(){
        string loadData = PlayerPrefs.GetString("diem");
        if(!string.IsNullOrEmpty(loadData)){
            string giaiMa = Extension.Decrypt(loadData, "truongnxph42284");

            score = int.Parse(giaiMa);
        }
    }
    public void AddScore(){
        score++;
    }
    public void SetScoreText(){
        scoreText.text = "Score: " + score.ToString("n0");
    }
}
