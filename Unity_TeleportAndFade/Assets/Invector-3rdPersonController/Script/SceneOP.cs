using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneOP : MonoBehaviour
{
    private Image imgCross;
    
    void Start()
    {
        imgCross = GameObject.Find("轉場效果").GetComponent<Image>();
        StartCoroutine(NextLevel());
    }
    public IEnumerator NextLevel()
    {
        for (int i = 0; i < 20; i++)
        {
            imgCross.color -= new Color(0, 0, 0, 0.05f);
            yield return new WaitForSeconds(0.03f);
        }
        
    }
}
