using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using 메이플스토리;
using 한승민.수업내용;
/*
 *  using : 이름 공간을 사용해라
 *  using : 이름공간.이름공간;
 *  => 네임 스페이스를 앞에 붙이지 않아도 그 공간안데 있는 코드를 사용할 수 있다
 */
 
namespace 한승민
{
    namespace 수업내용
    {
       /*
        *    클래스
        *    사용자 정의 데이터 유형입니다.=> int,float,string,char
        *    클래스를 이용하여 객체를 생성하고 그 객체 내부에 있는 변수와 메소드를 이용하여 데이터에 접근하고 사용할 수 있는 집합체 입니다.
        */
        
        /*
         * 1. 클래스이 선언
         * class 이름{}
         */

        //슬라임

       

        class Monster
        {
            //공격한다(행동)

            //체력
            //공격력
            //방어력

        }

        /*
         * 2. 클래스이 사용
         */


        

    }

    
}
namespace 메이플스토리
{
   class Slime
    {
        //슬라임의 체력은 50입니다. 정수형,실수형

        /*
         * 1.public : 공공의, 외부에서 전부 사용할 수 있게 하라
         * 2.private : class 내부에서만 사용해라, 접근 지정자를 명시하지 않으면 자동으로 private 선언이 된다.
         */
        public int HP;
        public int AttackPower;
        public string Name;
        public float MoveSpeed;

        /*
         *메소드 :코드를 하나의 이름 아래 묶는 것입니다.
         *묶인 코드를 이름을 불러주는 것만으로 실행할 수 있습니다.
         *메소드를 호출하는 것을 Call method (메소드 호출)
         */

        /*
         * (접근지정자) (반환값) (메소드의 이름) () {}
         * public       void     show()     {묵인 코드 내용들)
         * 접근지정자 : private,public => public 선언을 해주세요
         * 반환값이 없는 경우 : void
         * 반환값이 있는 경우 : int(정수형),float(실수형),string(문자열),class이름(사용자 정의형)반환하라...
         * 메소드의 이름 : show()=; 1.show(이름)
         */

        public void show()
        {
            Console.WriteLine($"{Name}의 체력 : {HP}");
            Console.WriteLine($"{Name}의 공격력 : {AttackPower}");
            Console.WriteLine($"{Name}의 이동속도 : {MoveSpeed}");
                
        }



    }




    class 초록달펭이
    {


        public int HP;
        public int AttackPower;
        public string Name;
        public float MoveSpeed;

        public void show()
        {
            Console.WriteLine($"{Name}의 체력 : {HP}");
            Console.WriteLine($"{Name}의 공격력 : {AttackPower}");
            Console.WriteLine($"{Name}의 이동속도 : {MoveSpeed}");

        }


    }


    class 플레이어
    {

        public int HP;                  
        public int AttackPower;
        public string Name;
        public float MoveSpeed;

        public void show()
        {
            Console.WriteLine($"{Name}의 체력 : {HP}");
            Console.WriteLine($"{Name}의 공격력 : {AttackPower}");
            Console.WriteLine($"{Name}의 이동속도 : {MoveSpeed}");


        }
                                                                                                                            
                                                                        


        
        
     



        class Player
        {
            public int HP;
            public int AttackPower;

           

            public void Show()
            {
                Console.WriteLine($"플레이어의 체력 : {HP}");
                Console.WriteLine($"플레이어의 공격력 : {AttackPower}");
            }

            public void Attack(Slime slime)
            {
                slime.HP = slime.HP - AttackPower;

                Console.WriteLine($"플레이어가 {slime.Name}을 공격했습니다!");
                Console.WriteLine($"------------------결과-------------------");
                Console.WriteLine($"플레이어의 공격력 : {AttackPower}으로 공격했습니다!");
                Console.WriteLine($"슬라임의 현재 체력 : {slime.HP}");
            }

            public void Rest()
            {
                HP = HP + 10;

                Console.WriteLine($"플레이어가 휴식을 했습니다!");
                Console.WriteLine($"------------------결과-------------------");
                Console.WriteLine($"플레이어의 체력을 회복했습니다!");
                Console.WriteLine($"플레이어의 현재 체력 : {HP}");








                
            }

        }



        
        


    }

  //내가하는 게임의 몬스터의 정보를 클래스를 만든다




    





    









}


















class 플레이어
    {

        public int HP;
        public int AttackPower;
        public string Name;
        public float MoveSpeed;

        public void show()
        {
            Console.WriteLine($"{Name}의 체력 : {HP}");
            Console.WriteLine($"{Name}의 공격력 : {AttackPower}");
            Console.WriteLine($"{Name}의 이동속도 : {MoveSpeed}");


        }










    class Player
    {
        public int HP;
        public int AttackPower;

        public void Show()
        {
            Console.WriteLine($"플레이어의 체력 : {HP}");
            Console.WriteLine($"플레이어의 공격력 : {AttackPower}");
        }

        public void Attack(Slime slime)
        {
            slime.HP = slime.HP - AttackPower;

            Console.WriteLine($"플레이어가 {slime.Name}을 공격했습니다!");
            Console.WriteLine($"------------------결과-------------------");
            Console.WriteLine($"플레이어의 공격력 : {AttackPower}으로 공격했습니다!");
            Console.WriteLine($"슬라임의 현재 체력 : {slime.HP}");
        }

        public void Rest()
        {
            HP = HP + 10;

            Console.WriteLine($"플레이어가 휴식을 했습니다!");
            Console.WriteLine($"------------------결과-------------------");
            Console.WriteLine($"플레이어의 체력을 회복했습니다!");
            Console.WriteLine($"플레이어의 현재 체력 : {HP}");
        }

    }







}















namespace 클래스와_메소드
{
    internal class 클래스
    {






    }

}
