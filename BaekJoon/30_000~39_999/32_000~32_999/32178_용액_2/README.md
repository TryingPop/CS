# C#

## 난이도 : 골드 2

## 알고리즘 분류
  - 그리디 알고리즘
  - 정렬
  - 누적 합

## 제한조건
  - 시간 제한 : 1초
  - 메모리 제한 : 1024 MB

## 문제
#### 중앙대학교에 숨겨진 화학연구소에는 산성과 염기성을 띠는 용액 N개가 일렬로 나열되어 있다. 푸앙이는 용액의 특성값이 0보다 크면 산성, 0보다 작으면 염기성이라 생각한다. 또한 특성값의 절댓값이 작을수록 중성에 가깝다고 생각한다. i번 용액의 특성값은 s_i이다.
#### 특성값이 a, b인 두 용액을 섞으면 화학 반응에 의해 특성값이 a + b인 용액이 된다고 한다. 푸앙이는 나열된 N개의 용액 중 연속적인 구간의 용액들을 섞어 중성에 가까운 용액을 만들고자 한다. 푸앙이가 만들 수 있는 가장 중성에 가까운 용액의 특성값과 그 용액을 만드는 방법을 구해보자.

## 입력
#### 첫 번째 줄에 양의 정수 N이 주어진다.
#### 두 번째 줄에 정수 s_1, s_2, s_3, ..., s_N이 공백으로 구분되어 주어진다.

## 출력
#### 첫 번째 줄에 푸앙이가 만들 수 있는 가장 중성에 가까운 용액의 특성값을 출력한다.
#### 두 번째 줄에 양의 정수 L, R을 공백으로 구분하여 출력한다. L번부터 R번까지의 용액을 섞었다는 뜻이다.
#### 가능한 경우가 여러 가지라면 그중 아무거나 하나를 출력한다.

## 제한
  - 1 ≤ N ≤ 1,000,000
  - -10^9 ≤ s_i ≤ 10^9
  - 1 ≤ i ≤ N
  - 1 ≤ L ≤ R ≤ N

## 예제 입력
4<br/>
1 2 -1 -1<br/>

## 예제 출력
0<br/>
2 4<br/>

## 문제 링크
https://www.acmicpc.net/problem/32178