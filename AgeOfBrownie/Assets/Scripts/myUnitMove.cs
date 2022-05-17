using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myUnitMove : MonoBehaviour
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

    void Start()
    {
        
    }

    // Update is called once per frame
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
        }
        else if (Status == "ATTACK")
        {
            unitRigidbody.velocity = new Vector2(0, 0); // ����
            _animator.SetBool("attackBool", true);
            attackStatus();
            reloadStatus();
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
        _animator.SetBool("attackBool", false);
    }


    void attackStatus() // ���� �ൿ
    {
        if (curShotDelay < maxShotDelay)
        {
           return;
        }
        
        Instantiate(bullet, firePos.transform.position, firePos.transform.rotation);
        
        curShotDelay = 0;
    }
    void reloadStatus() // ���� ��� �ൿ
    {
        curShotDelay += Time.deltaTime;
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
