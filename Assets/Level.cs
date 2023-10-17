using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Level : MonoBehaviour
{
    public static Level instance;
    [SerializeField] public Text levelText;
    public int level = 1;
    [SerializeField] public int damage = 1;
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
        yield return new WaitUntil(() => Score.instance.score >= NextLevel2);
        Debug.Log("Level 2");
        levelText.color = Color.yellow;
        levelText.text = ("LVL 2");
        damage = 4;
        level = 2;

        yield return new WaitUntil(() => Score.instance.score >= NextLevel3);
        Debug.Log("Level 3");
        levelText.color = Color.red;
        levelText.text = ("LVL 3");
        damage = 10;
        level = 3;

        yield return new WaitUntil(() => Score.instance.score >= NextLevel4);
        Debug.Log("Level 4");
        levelText.color = Color.magenta;
        levelText.text = ("LVL 4");
        damage = 20;
        level = 4;
    }
}