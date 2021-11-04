using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MissionCount : MonoBehaviour
{
    public TextMeshProUGUI missionMessage;
    public float timeCount = 0f;
    public bool flag = false;

    // Start is called before the first frame update
    void Start()
    {
        setFlag(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.flag)
        {
            setTimeCount();
            setMissionMessage("�� �ȿ��� �Ƶ��д뿡 ����\n ���ǵ��� ã���ּ���.");
        }
        else
        {
            this.timeCount = 0f;
            setMissionMessage(null);
        }
    }

    void setFlag(bool flag)
    {
        this.flag = flag;
    }

    void setMissionMessage(string msg)
    {
        this.missionMessage.text = msg;
    }

    void setTimeCount()
    {
        this.timeCount += Time.deltaTime;
        if (this.timeCount >= 5f)
        {
            setFlag(false);
        }
    }
}
