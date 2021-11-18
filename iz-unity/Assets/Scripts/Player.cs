using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private static Player instance = new Player();
    private HashSet<string> picked = new HashSet<string>();
    private int count = 0;

    public const int MAXCOUNT = 6;
    public TextMeshProUGUI missionMessage;
    public TextMeshProUGUI findClue;
    public GameObject targetLocation;
    
    public string[] tags = { "tv", "bat", "dish", "bath", "diary", "chair" };
    public int life = 5;

    private Player() { }

    public static Player getInstance()
    {
        return instance;
    }

    private void Start()
    {
        changeFindClue();
    }
    public void countInit()
    {
        instance.count = 0;
    }

    public void pickedInit()
    {
        instance.picked.Clear();
    }

    public void addPicked(string tagName)
    {
        instance.picked.Add(tagName);
    }

    public bool containsPicked(string tagName)
    {
        return instance.picked.Contains(tagName);
    }

    void changeMissionMessage()
    {
        this.missionMessage.text = "모든 단서를 찾았습니다.\n포탈을 통해 아이의 방으로\n이동해주세요.";
    }

    void changeFindClue()
    {
        this.findClue.text = "찾은 단서: " + instance.count + " / " + MAXCOUNT;
    }

    void fakeClue(string tagName)
    {
        // 라이프 1 감소 및 text에 failMessage로 변경
        this.life--;
        // 라이프가 0이되면 아웃
        // TODO Add more
    }

    void realClue(string tagName)
    {
        // 카운트 1 증가 및 text에 successMessage로 변경
        GameObject gameObjectByTag = GameObject.FindGameObjectWithTag(tagName);
        //gameObjectByTag.transform.Find("")

        instance.count++;
        changeFindClue();
        // 카운트가 MAX이면 missionMessage 변경, targetLocation 활성화, count, picked 초기화
        if (instance.count == MAXCOUNT)
        {
            changeMissionMessage();
            targetLocation.SetActive(true);
        }
    }

    public bool findCheck(string findTag)
    {
        print("태그: " + findTag);
        bool flag = false;
        for (int i = 0; i < MAXCOUNT; i++)
        {
            print(tags[i]);
            if (this.tags[i] == findTag)
            {
                flag = true;
                break;
            }
        }
        instance.addPicked(findTag);

        return flag;
    }

    public void clickClue(string findTag)
    {
        if (findCheck(findTag))
        {
            realClue(findTag);
        }
        else
        {
            fakeClue(findTag);
        }
    }
}
