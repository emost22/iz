using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaycastRighthand01 : MonoBehaviour
{
    private Player player;
    private LineRenderer layser;        // ������
    private RaycastHit Collided_object; // �浹�� ��ü
    private GameObject currentObject;   // ���� �ֱٿ� �浹�� ��ü�� �����ϱ� ���� ��ü

    public float raycastDistance = 100f; // ������ ������ ���� �Ÿ�

    // Start is called before the first frame update
    void Start()
    {
        player = Player.getInstance();

        // ��ũ��Ʈ�� ���Ե� ��ü�� ���� ��������� ������Ʈ�� �ְ��ִ�.
        layser = this.gameObject.AddComponent<LineRenderer>();

        // ������ �������� ���� ǥ��
        Material material = new Material(Shader.Find("Standard"));
        material.color = new Color(255, 255, 255, 0.5f);
        layser.material = material;
        // �������� �������� 2���� �ʿ� �� ���� ������ ��� ǥ�� �� �� �ִ�.
        layser.positionCount = 2;
        // ������ ���� ǥ��
        layser.startWidth = 0.01f;
        layser.endWidth = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        layser.SetPosition(0, transform.position); // ù��° ������ ��ġ
                                                   // ������Ʈ�� �־� �����ν�, �÷��̾ �̵��ϸ� �̵��� ���󰡰� �ȴ�.
                                                   //  �� �����(�浹 ������ ����)

        // �浹 ���� ��
        if (Physics.Raycast(transform.position, transform.forward, out Collided_object, raycastDistance))
        {
            layser.SetPosition(1, Collided_object.point);

            // �浹 ��ü�� �±װ� Button�� ���
            if (Collided_object.collider.gameObject.CompareTag("Clue"))
            {
                layser.material.color = new Color(0, 195, 255, 0.5f);
                // ��ŧ���� �� �����ܿ� ū ���׶�� �κ��� ���� ���
                if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
                {
                    Debug.Log("right ����");
                    string tagName = Collided_object.collider.gameObject.transform.Find("Canvas").gameObject.tag;
                    if (player.containsPicked(tagName))
                    {
                        Collided_object.collider.gameObject.transform.Find("Complete").gameObject.SetActive(true);
                    }
                    else
                    {
                        Collided_object.collider.gameObject.transform.Find("Canvas").gameObject.SetActive(true);
                    }
                }

                else
                {
                    currentObject = Collided_object.collider.gameObject;
                }
            }
        }

        else
        {
            // �������� ������ ���� ���� ������ ������ �ʱ� ���� ���̸�ŭ ��� �����.
            layser.SetPosition(1, transform.position + (transform.forward * raycastDistance));
            layser.material.color = new Color(255, 255, 255, 0.5f);

            // �ֱ� ������ ������Ʈ�� Button�� ���
            // ��ư�� ���� �����ִ� �����̹Ƿ� �̰��� Ǯ���ش�.
            if (currentObject != null)
            {
                currentObject = null;
            }

        }

    }
}
