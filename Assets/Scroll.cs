using UnityEngine;
using System.Collections;


public class Scroll : MonoBehaviour
{
    //�X�s�[�h���C���X�y�N�^�[����I�ׂ�l�ɂ����I
    public float scrollSpeed = 1.0f;
    //float�^��start��end�Ő錾���܂��B
    public float start;
    public float end;

    private void Update()
    {
        //�X�N���[���̏������v�Z�B
        transform.Translate(-1 * scrollSpeed * Time.deltaTime, 0, 0);
        //�X�N���[���I���̔����V����������֐�ScrollEnd�ŎQ�Ƃ��܂��B
        if (transform.position.x <= end) ScrollEnd();
    }

    void ScrollEnd()
    {
        //�X�N���[������������������߂��܂��B
        transform.Translate(-1 * (end - start), 0, 0);

    }


}