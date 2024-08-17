// 주석 : 컴퓨터는 알아볼 수 없지만 사람만 알아볼 수 있게 표시하는 기능
//1.// 해당주 줄은 주석처리된다.(컴퓨터는 알아볼 수 없게 된다.)
//2./* */ :/* ~ */ 모두 주석처리하라

/*
 *학습 목표 :csharp 언어로 첫 프로그래밍 작성하기. 변수에 대한 이해
 *작성일 :2024-08-10
 *작성자 :한승민
 */

/*프로그래밍 + 언어
 * 프로그래밍 : 컴퓨터로 프로그램을 작동시키는 작업
 * 언어       :두 객체 사이에 대화를 하기 위해 필요한 언어다.
 * 
 * 사람은 기계가 하는 말을 알아들을 수 있습니까? -> X
 * 기계가 사람이 하는 말을 알아들을 수 있을까요? -> X
 * 번역기, 통역사 -> 컴파일러 : 사람과 컴퓨터 사이에 번역을 해주는 기계
 * c언어 c++, 파이썬 ,자바, 자바스크립트,타임스크립트
 * .c .cpp .cs .py .jv .js .ty ->변역기가 따로 있습니다
 */

/*
 * 컴퓨터가 사람이 사용하는 언어를 표현하는 방법을 모방하려면
  * 키워드? 이미 의미가 정해져 있는 단어. 
 * 파란색으로 표시되어 있는 단어.
 * 흰색        : 어떤 것(데이터 타입)의 이름
 * 밝은 노란색 : 함수
 * 
 *  정수는 정수 방식으로 표현한다.
 *  실수는 실수 방식으로 표현한다.
 *  문자는 문자 방식으로 표현한다.
 *  
 *  정수 방식으로 사용한는 키워드 : int
 *  실수 방식으로 사용하는 키워드
 */


using System;
using System.Collections.Concurrent;

namespace csharpstudy
{

    class Program
    {
        static void Main(string[] args)
        {
            //변수 :변하는 수 출력할 떄 값이 다를 수 있는 형태
            //변수의 선언
            //키워드 해당키워드이 이름:
            //이름 :number

            int number; //정수를 저장할 수있는 변수를 선언하는데 그 녀석의 이름이 number
            number = 10; //number를 대입하라

            //정수형 변수로 이름을 num으로 선언해서 그 변수에 100이라는 숫자를 넣어보세요.

            //초기화 : 변수의 선언과 동시에 데이터을 넣는 것





            //키워드를 하나 선택 float
            //변수의 선언
            //변수의 초기화
            //변수의 사친연산

            //문자는 사실 숫자이다
            //a라는 숫자를 46이다.
            //46 -> a
            //ascll



            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s1 + s2);

            string input = "Hello World!"; //문자열을 저장할 수 있는 input이라는 변수를 선언한다


            Console.WriteLine(input);

            Console.Write("첫번째 숫자를 입력해주세요");
            string inputA = Console.ReadLine();
            int inputNumber1 = int.Parse(inputA); // "35" -> 35
            //사각혀으이 넓이를 구하는 프로그램;
            Console.WriteLine("가로의 크기를 입력해주세요");
            string width = Console.ReadLine();
            int widthNumber = int.Parse(width);
            Console.WriteLine("세로의 크기를 입력해주세요");
            string height = Console.ReadLine();
            int heightNumber = int.Parse(height);
            Console.WriteLine($"삼각형의 넓이 {widthNumber * heightNumber}");


            

            





















        }
    }

}


















































