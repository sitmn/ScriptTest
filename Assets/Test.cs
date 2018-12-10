using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    class Boss
    {
        private int hp = 100;
        private int power = 25;
        private int mp = 53;
        private int magiccost = 5;

        public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた");
        }

        public void Defence(int damage)
        {
            Debug.Log(damage + "のダメージを受けた");
            this.hp -= damage;

        }

        //発展課題
        public void Magic()
        {
            if (this.mp >= this.magiccost)
            {
                this.mp -= this.magiccost;
                Debug.Log("魔法攻撃をした。残りmpは" + this.mp + "。");
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }
        }
    }

    // Use this for initialization
    void Start()
    {
        Boss lastboss = new Boss();

        lastboss.Attack();
        lastboss.Defence(3);


        Boss middleboss = new Boss();
        middleboss.Attack();
        middleboss.Defence(10);


        //①配列宣言課題
        int[] array = { 4, 2, 3, 8, 3 };

        //順番に表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        //逆順に表示
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        //発展課題,魔法を10回使用後、11回目の使用で不発
        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
