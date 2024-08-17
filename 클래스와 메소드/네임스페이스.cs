/*
 * 학습목표: 이름공간(name space)에 대한 이해
 * 작정일  : 2024-08-17
 * 작성자  : 한승민
 */


/*
 * 이름:다른 이름을 가짐으로써 구분할 수 있다.
 * 만약에 같은 이름이 중복되면 어떻게 될까?
 * 
 * 
 */

/*
 * 2.네임 스페이스 선언 방법
 * name space 이름공간의 이름 {  } 범위를 표현해주는 기호
 * 
 */





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;




//이름 공간 (커피 브랜드 두개 선언을 해보세요)
namespace 벤티
{
    class 커피
    {
        public int count;

    }
}

namespace 컴포즈
{
    class 커피
    {
        public int count;

    }
}
namespace 부산
{
    class 밀면
    {
        public int count;

    }



}





namespace 서울
{
    class 밀면
    {
       public int count;

    }

}

namespace 클래스와_메소드
{
    internal class 네임스페이스
    {
        public void show()
        {

            //1.같은 이름이 중복되면 안되는 예시

            부산.밀면 noodle = new 부산.밀면();
            noodle.count = 10;
            Console.WriteLine(noodle.count);
            서울.밀면 noodle2 = new 서울.밀면();

            벤티.커피 coffee = new 벤티.커피();
            coffee.count = 100;
            Console.WriteLine(coffee.count);
            컴포즈.커피 coffee2 = new 컴포즈.커피();

        }
    }
}
