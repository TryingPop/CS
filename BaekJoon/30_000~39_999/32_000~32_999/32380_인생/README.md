# C#

## 난이도 : 골드 1

## 알고리즘 분류
  - 그리디 알고리즘
  - 누적 합

## 제한조건
  - 시간 제한 : 2초
  - 메모리 제한 : 1024 MB

## 문제
#### N개의 정수로 이루어진 두 배열 A, B와 두 정수 U, D가 주어진다. 배열 A, B의 i번째 원소는 각각 A_i, B_i이다.
#### f(n)을 다음과 같이 정의한다.
  - 아래 과정을 i = 1, 2, ..., n에 대해 순서대로 수행한다.
    1. A_i와 B_i 중 하나를 고른다.
    2. 이후 i < j ≤ n을 만족하는 모든 j에 대해, A_i를 골랐다면 A_j와 B_j의 값이 U만큼 증가하고, B_i를 골랐다면 A_j와 B_j의 값이 D만큼 감소한다.
  - f(n)은 수를 고르는 2^n가지 방법 중, 고른 수들의 합의 최솟값이다.
#### 1 이상 N 이하의 모든 정수 n에 대해, f(n)의 값을 구해보자.

## 입력
#### 첫째 줄에 배열의 길이 N과 양의 정수 U, D가 공백으로 구분되어 주어진다. (1 ≤ N ≤ 300,000; 1 ≤ U, D ≤ 10^6) 
#### 둘째 줄에 A_1, A_2, ..., A_N이 공백으로 구분되어 주어진다. (0 ≤ A_i ≤ 10^6) 
#### 셋째 줄에 B_1, B_2, ..., B_N이 공백으로 구분되어 주어진다. (0 ≤ B_i ≤ 10^6)

## 출력
#### N개의 줄에 걸쳐 답을 출력한다. n번째 줄에는 f(n)을 출력한다.

## 제한
  - 1 ≤ N ≤ 1,000,000
  - -10^9 ≤ s_i ≤ 10^9
  - 1 ≤ i ≤ N
  - 1 ≤ L ≤ R ≤ N

## 예제 입력
5 2 3<br/>
4 8 2 8 1<br/>
11 5 14 8 19<br/>

## 예제 출력
4<br/>
11<br/>
9<br/>
13<br/>
7<br/>

## 힌트
#### f(5)의 값을 얻을 수 있는 방법은 다음과 같다.
  1. A_1 = 4, B_1 = 11 중 B_1를 고른다. 이후 수열 A는 [4, 5, -1, 5, -2], B는 [11, 2, 11, 5, 16]로 변한다.
  2. A_2 = 5, B_2 = 2 중 B_2를 고른다. 이후 수열 A는 [4, 5, -4, 2, -5], B는 [11, 2, 8, 2, 13]로 변한다.
  3. A_3 = -4, B_3 = 8 중 A_3를 고른다. 이후 수열 A는 [4, 5, -4, 4, -3], B는 [11, 2, 8, 4, 15]로 변한다.
  4. A_4 = 4, B_4 = 4 중 B_4를 고른다. 이후 수열 A는 [4, 5, -4, 4, -6], B는 [11, 2, 8, 4, 12]로 변한다.
  5. A_5 = -6, B_5 = 12 중 A_5를 고른다.
#### 고른 수들의 합은 11 + 2 + (-4) + 4 + (-6) = 7이다.

## 문제 링크
https://www.acmicpc.net/problem/32380