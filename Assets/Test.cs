using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


//Boss�N���X�����
public class Boss
{
    private int mp = 53;

    //���@�U���̊֐�Magic�̐錾
    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + mp + "�B");
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ�");
        }
    }
}

public class Test : MonoBehaviour
{
    //Start is called before the first frame update
    void Start()
    {
    //�ۑ�---------------------------------------------------------------------
        //int�^�z��array��錾���čD���Ȓl�ŏ�����
        int[] array = { 10, 20, 30, 40, 50 };

        //for���ŏ��Ԃɕ\��
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        //for���ŋt���ɕ\��
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

    //���W�ۑ�------------------------------------------------------------------
        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        //���@�U���p�̊֐���10��Ăяo��
        for (int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }

        //������x���@�U���p�̊֐����Ăяo����mp������Ȃ����b�Z�[�W���m�F����
        lastboss.Magic();
    }
}