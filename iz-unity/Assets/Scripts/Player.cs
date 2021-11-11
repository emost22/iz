using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private RaycastLefthand01 raycastLefthand;
    public const int MAXCOUNT = 5;
    public TextMeshProUGUI missionMessage;
    public TextMeshProUGUI findClue;
    public GameObject targetLocation;
    
    public string[] tags = { "tv", "bat", "dish", "bath", "diary" };
    public int life = 5;
    public int count = 0;

    void Start()
    {
        raycastLefthand = RaycastLefthand01.getInstance();
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
        // ī��Ʈ�� MAX�̸� missionMessage ����, targetLocation Ȱ��ȭ
        if (this.count == MAXCOUNT)
        {
            changeMissionMessage();
            targetLocation.SetActive(true);
        }
    }

    public bool findCheck(string findTag)
    {
        print("�±�: " + findTag);
        bool flag = false;
        for (int i = 0; i < 5; i++)
        {
            if (this.tags[i] == findTag)
            {
                flag = true;
                break;
            }
        }
        raycastLefthand.addPicked(findTag);

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
