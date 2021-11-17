using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private static Player instance = new Player();
    private HashSet<string> picked = new HashSet<string>();

    public const int MAXCOUNT = 6;
    public TextMeshProUGUI missionMessage;
    public TextMeshProUGUI findClue;
    public GameObject targetLocation;
    
    public string[] tags = { "tv", "bat", "dish", "bath", "diary", "chair" };
    public int life = 5;
    public int count = 0;

    private Player() { }

    public static Player getInstance()
    {
        return instance;
    }

    private void Start()
    {
        changeFindClue();
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
        this.missionMessage.text = "��� �ܼ��� ã�ҽ��ϴ�.\n��Ż�� ���� ������ ������\n�̵����ּ���.";
    }

    void changeFindClue()
    {
        this.findClue.text = "ã�� �ܼ�: " + this.count + " / " + MAXCOUNT;
    }

    void fakeClue(string tagName)
    {
        // ������ 1 ���� �� text�� failMessage�� ����
        this.life--;
        // �������� 0�̵Ǹ� �ƿ�
        // TODO Add more
    }

    void realClue(string tagName)
    {
        // ī��Ʈ 1 ���� �� text�� successMessage�� ����
        GameObject gameObjectByTag = GameObject.FindGameObjectWithTag(tagName);
        //gameObjectByTag.transform.Find("")

        this.count++;
        changeFindClue();
        // ī��Ʈ�� MAX�̸� missionMessage ����, targetLocation Ȱ��ȭ, count, picked �ʱ�ȭ
        if (this.count == MAXCOUNT)
        {
            changeMissionMessage();
            targetLocation.SetActive(true);
            this.count = 0;
            instance.picked.Clear();
        }
    }

    public bool findCheck(string findTag)
    {
        print("�±�: " + findTag);
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
