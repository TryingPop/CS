# C#

## 난이도 : 실버 3

## 알고리즘 분류
  - 수학
  - 구현
  - 많은 조건 분기

## 제한조건
  - 시간 제한 : 1초
  - 메모리 제한 : 1024 MB

## 문제
#### 우리의 회장님은 성격이 괴팍하다. 그의 마음에 들면 "Nice", "Go ahead"이라고 말하지만, 그의 마음에 들지 않으면 "Remember my character", 그의 선을 넘으면 가차 없이 "Head on"이라는 핍박을 듣게 된다. 그의 요구는 두 다항함수 f(x)와 g(x)를 이용하여 합성 함수를 만드는 것이다.
#### p(x) = f(g(x))이고 q(x) = g(f(x))이다. 이때 f(x)의 최고차항은 2 이하이고 g(x)의 최고차항은 1 이하이다. 회장님은 이 두 함수 y=p(x)와 y=q(x)가 만나는 지점이 무한개인지, 2개인지, 1개인지, 0개인지에 따라 다음과 같이 말한다.
  - 무한개: "Nice"
  - 2개: "Go ahead"
  - 1개: "Remember my character"
  - 0개: "Head on"
#### 두 함수 y=p(x)와 y=q(x)가 만나는 지점의 개수는 p(x)-q(x)=0을 통해 x축과 만나는 점의 개수를 파악하여 알 수 있다.

## 입력
#### 첫째 줄에 함수 f(x)의 2차항, 1차항, 상수항의 계수가 공백으로 구분되어 차례대로 주어지고, 둘째 줄에 함수 g(x)의 1차항, 상수항의 계수가 공백으로 구분되어 차례대로 주어진다.
#### 주어지는 계수와 상수항은 -20 이상 20이하의 정수이다

## 출력
#### 두 함수가 닿는 점의 개수에 따라 "Nice", "Go ahead", "Remember my character", "Head on" 중 하나를 출력한다.

## 예제 입력
2 4 0<br/>
2 0<br/>

## 예제 출력
Remember my character<br/>

## 힌트
#### f(x)가 {2x^2+4x}, {g(x)}가 {2x}일 때 {p(x)}는 {8x^2+8x}이고 {q(x)}는 {4x^2+8x}이다. 이 두 함수를 각각 빼면 {4x^2=0}이다. 이차 방정식 ax^2 + bx + c = 0의 근의 개수는 판별식을 사용하여 알 수 있다. 판별식은 b^2 - 4ac로 표현되며, 이 값을 통해 근의 개수를 알 수 있다.
  1. 판별식 값이 양수인 경우 (b^2 - 4ac > 0): 판별식 값이 양수인 경우, 이차 방정식은 두 개의 서로 다른 실근을 갖는다. 즉, 방정식은 두 개의 서로 다른 실수해를 가진다.
  2. 판별식 값이 0인 경우 (b^2 - 4ac = 0): 판별식 값이 0인 경우, 이차 방정식은 한 개의 중근을 갖는다. 따라서 방정식은 중복된 한 개의 실근을 가진다.
  3. 판별식 값이 음수인 경우 (b^2 - 4ac < 0): 판별식 값이 음수인 경우, 이차 방정식은 실근을 갖지 않는다. 즉, 방정식은 실수해를 가지지 않는다.
#### 따라서, 주어진 이차 방정식의 판별식 값을 계산하여 양수인지, 0인지, 음수인지 확인하면 근의 개수를 판단할 수 있다. {4x^2=0}의 판별식 값은 0이므로 한 점에만 닿게 된다. 즉, Remember my character를 출력해야 한다.

## 문제 링크
https://www.acmicpc.net/problem/28418