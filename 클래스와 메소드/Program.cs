using System.Net.Http.Headers;
using System.Xml.Linq;

namespace 클래스와_메소드
{
    internal class Program
    {
        static void Main(string[] args)
        {
           네임스페이스 ns = new 네임스페이스();
           ns.show();

            /*
             *  클래스 사용하는 방법
             *  (이름공간.Slime) (클래스의 이름 변수) = new 메이플스토리.Slime();
             *  
             */

            메이플스토리.Slime slime = new 메이플스토리.Slime();
            slime.Name = "슬라임";
            slime.HP = 50;
            slime.AttackPower = 5;
            slime.MoveSpeed = 2.2f;
            slime.show();


            메이플스토리.초록달펭이 초록달펭이 = new 메이플스토리.초록달펭이();
            초록달펭이.Name = "초록달펭이";
            초록달펭이.HP = 120;
            초록달펭이.AttackPower = 1;
            초록달펭이.MoveSpeed = 0.2f;
            초록달펭이.show();


            메이플스토리.플레이어 플레이어 = new 메이플스토리.플레이어();
            플레이어.Name = "플레이어";
            플레이어.HP = 510;
            플레이어.AttackPower = 75;
            플레이어.MoveSpeed = 20f;
            플레이어.show();






        }
    }
}
