using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class toNextScene : MonoBehaviour
{
    private Image imgCross;

    private void Start()
    {
        imgCross = GameObject.Find("轉場畫面").GetComponent<Image>();
    }
    public IEnumerator NextLevel()
    {
        for (int i = 0; i < 20; i++)
        {
            imgCross.color += new Color(0, 0, 0, 0.05f);
            yield return new WaitForSeconds(0.01f);
        }
        SceneManager.LoadScene("第二關");
    }
}
