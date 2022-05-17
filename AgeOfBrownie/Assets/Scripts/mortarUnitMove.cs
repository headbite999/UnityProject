using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mortarUnitMove : MonoBehaviour
{
    public Rigidbody2D unitRigidbody;
    public Animator _animator;
    public attackRange _attackRange;
    public UnitStatus _unitStatus;
    public GameObject bullet;
    public GameObject firePos;


    public float speed;
    public float destroyDelay;
    public float maxShotDelay;
    public float curShotDelay;

    public string Status;
    public string readyStatus = "READY";

    void Start()
    {
        
    }

    void Update()
    {
        statusThinker();
        GameDecision();
    }

    void statusThinker() // ���� ������
    {
        if (!_attackRange.attackDecision && _unitStatus.HP > 0)
            Status = "MOVE";
        else if (_attackRange.attackDecision && _unitStatus.HP > 0)
            Status = "ATTACK";
        else if (_unitStatus.HP <= 0)
            Status = "DEATH";
    }

    void GameDecision() // ���º� �ൿ
    {
        if (Status == "MOVE")
        {
            moveForward();
            readyStatus = "READY";
        }
        else if (Status == "ATTACK")
        {
            unitRigidbody.velocity = new Vector2(0, 0); // ����
            if (readyStatus == "READY")
            {
                seigeStatus();
            }
            else if (readyStatus == "FIRE")
            {
                Invoke("attackStatus", 0.3f);
                reloadStatus();
                if (!_attackRange.attackDecision)
                {
                    unseigeStatus();
                    readyStatus = "READY";
                }
            }
            
        }
        else if(Status == "SEIGE")
        {

        }
        else if (Status == "DEATH")
        {
            deathStatus();
            Status = "DESTROYED";
            Invoke("destroyUnit", destroyDelay);
        }
    }

    void moveForward() // �̵� �ൿ
    {
        unitRigidbody.velocity = new Vector2(speed, 0); // ����
        _animator.SetInteger("seigeLevel", 0);
    }

    void seigeStatus()
    {
        _animator.SetInteger("seigeLevel", 1);
        readyStatus = "FIRE";
    }


    void attackStatus() // ���� �ൿ
    {
        if (curShotDelay < maxShotDelay)
        {
            return;
        }
        _animator.SetInteger("seigeLevel", 2);

        Instantiate(bullet, firePos.transform.position, firePos.transform.rotation);

        curShotDelay = 0;
    }
    void reloadStatus() // ���� ��� �ൿ
    {
        curShotDelay += Time.deltaTime;
    }

    void unseigeStatus()
    {
        _animator.SetInteger("seigeLevel", 1);
    }

    void deathStatus() // ��� �ൿ
    {
        unitRigidbody.velocity = new Vector2(0, 0); // ����
        _animator.SetTrigger("deathTrigger");
    }

    void destroyUnit() // ���� ����
    {
        Destroy(gameObject);
    }
}
