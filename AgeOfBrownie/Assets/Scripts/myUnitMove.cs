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

    void statusThinker() // 상태 지정자
    {
        if (!_attackRange.attackDecision && _unitStatus.HP > 0)
            Status = "MOVE";
        else if (_attackRange.attackDecision && _unitStatus.HP > 0)
            Status = "ATTACK";
        else if (_unitStatus.HP <= 0)
            Status = "DEATH";
    }

    void GameDecision() // 상태별 행동
    {
        if (Status == "MOVE")
        {
            moveForward();
        }
        else if (Status == "ATTACK")
        {
            unitRigidbody.velocity = new Vector2(0, 0); // 정지
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

    void moveForward() // 이동 행동
    {
        unitRigidbody.velocity = new Vector2(speed, 0); // 전진
        _animator.SetBool("attackBool", false);
    }


    void attackStatus() // 공격 행동
    {
        if (curShotDelay < maxShotDelay)
        {
           return;
        }
        
        Instantiate(bullet, firePos.transform.position, firePos.transform.rotation);
        
        curShotDelay = 0;
    }
    void reloadStatus() // 공격 대기 행동
    {
        curShotDelay += Time.deltaTime;
    }

    void deathStatus() // 사망 행동
    {
        unitRigidbody.velocity = new Vector2(0, 0); // 정지
        _animator.SetTrigger("deathTrigger");
    }

    void destroyUnit() // 유닛 제거
    {
        Destroy(gameObject);
    }
}
