# C#

## 난이도 : 실버 2

## 알고리즘 분류
  - 구현
  - 브루트포스 알고리즘
  - 두 포인터

## 제한조건
  - 시간 제한 : 2초
  - 메모리 제한 : 1024 MB

## 문제
#### 은하는 긴 막대에 N개의 과일이 꽂혀있는 과일 탕후루를 만들었습니다. 과일의 각 종류에는 1부터 9까지의 번호가 붙어있고, 앞쪽부터 차례로 S_1, S_2, ..., S_N번 과일이 꽂혀있습니다. 과일 탕후루를 다 만든 은하가 주문을 다시 확인해보니 과일을 두 종류 이하로 사용해달라는 요청이 있었습니다.
#### 탕후루를 다시 만들 시간이 없었던 은하는, 막대의 앞쪽과 뒤쪽에서 몇 개의 과일을 빼서 두 종류 이하의 과일만 남기기로 했습니다. 앞에서 a개, 뒤에서 b개의 과일을 빼면 S_{a+1}, S_{a+2}, ..., S_{N-b-1}, S_{N-b}번 과일, 총 N-(a+b)개가 꽂혀있는 탕후루가 됩니다. (0 ≤ a, b; a+b < N)
#### 이렇게 만들 수 있는 과일을 두 종류 이하로 사용한 탕후루 중에서, 과일의 개수가 가장 많은 탕후루의 과일 개수를 구하세요.

## 입력
#### 첫 줄에 과일의 개수 N이 주어집니다. (1 ≤ N ≤ 200,000) 
#### 둘째 줄에 탕후루에 꽂힌 과일을 의미하는 N개의 정수 S_1, ..., S_N이 공백으로 구분되어 주어집니다. (1 ≤ S_i ≤ 9) 

## 출력
#### 문제의 방법대로 만들 수 있는 과일을 두 종류 이하로 사용한 탕후루 중에서, 과일의 개수가 가장 많은 탕후루의 과일 개수를 첫째 줄에 출력하세요.

## 예제 입력
5<br/>
5 1 1 2 1<br/>

## 예제 출력
4<br/>

## 힌트
#### 과일을 앞에서 1개, 뒤에서 0개의 과일을 빼면 남은 과일은 1, 1, 2, 1번 과일이 꽂혀있는 탕후루가 됩니다. 과일의 개수는 4개입니다.

## 문제 링크
https://www.acmicpc.net/problem/30804