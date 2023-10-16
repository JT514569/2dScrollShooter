using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Level : MonoBehaviour
{
    public Text levelText;
    int level = 1;
    [SerializeField] public int NextLevel2;
    [SerializeField] public int NextLevel3;
    [SerializeField] public int NextLevel4;
    [SerializeField] public int NextLevel5;

    void Start()
    {
        StartCoroutine(Leveling());
    }

    // Start is called before the first frame update
    IEnumerator Leveling()
    {
        yield return new WaitUntil(()Score.instance.score >= NextLevel2);
        Debug.Log("Level 2");
        level = 2;
    }
    // Update is called once per frame
    void Update()
    {
        if (level == 4)
        {
            GetComponent<Text>().color = Color.red;
        }
        else if (level == 3)
        {
            GetComponent<Text>().color = Color.yellow;
        }
        else if (level == 2)
        {
            GetComponent<Text>().color = Color.yellow;
        }
        else
        {
            GetComponent<Text>().color = Color.white;
        }
    }

}
