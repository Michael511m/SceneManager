using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class EndScript : MonoBehaviour
{
    [SerializeField] private FloatSO scoreSO;
    [SerializeField] private TMP_Text scoreText;

    string path;
    int highScore;
    int score;

    void Start()
    {
        scoreText.text = scoreSO.Value + "";
        path = Application.dataPath + "/highscore.txt";

        score = int.Parse(scoreSO.Value + "");

        



        
        if (File.Exists(path))
        {
            
            StreamReader reader = new StreamReader(path);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                highScore = int.Parse(line);
            }
            reader.Close();
        } else
        {
            File.Create(path).Dispose();
            highScore = 0;
        }
        UpdateHighScore(score);
    }

    void UpdateHighScore(int score)
    {
        
        if (score > highScore)
        {
            
            highScore = score;
            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine(highScore);
            writer.Close();
        }
    }
}
