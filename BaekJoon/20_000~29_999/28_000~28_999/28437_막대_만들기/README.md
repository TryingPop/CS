# C#

## 난이도 : 골드 3

## 알고리즘 분류
  - 수학
  - 다이나믹 프로그래밍
  - 정수론

## 제한조건
  - 시간 제한 : 1초
  - 메모리 제한 : 1024 MB

## 문제
#### 길고 얇은 막대를 만드는 과정은 다음과 같습니다.
  - 기본으로 사용할 막대를 고릅니다. 사용 가능한 막대의 길이는 A_1, ..., A_N입니다.
  - 원하는 길이가 될 때까지 0번 이상 막대를 늘립니다. 기계에 2 이상의 양의 정수 k를 설정해서 막대를 넣으면, 길이가 x였던 막대가 길이 kx의 막대가 됩니다.
#### 주어진 Q개의 길이 각각에 대해 길이가 L_i인 막대를 만드는 방법의 수를 출력하세요. 두 방법이 서로 다르다는 것은 처음 선택한 막대가 다르거나, 막대를 늘리는 과정에서 입력한 정수 k의 수열이 서로 다르다는 것을 의미합니다.

## 입력
#### 첫 줄에 막대의 개수 N이 주어집니다. (1 ≤ N ≤ 100,000)
#### 둘째 줄에 N개의 서로 다른 정수 A_1, A_2, ..., A_N이 공백으로 구분되어 주어집니다. (1 ≤ A_i ≤ 100,000)
#### 셋째 줄에 만들고자 하는 막대 길이의 개수 Q가 주어집니다. (1 ≤ Q ≤ 100,000)
#### 넷째 줄에 Q개의 정수 L_1, ..., L_Q가 공백으로 구분되어 주어집니다. (1 ≤ L_i ≤ 100,000)

## 출력
#### 첫 줄에 Q개의 수를 공백으로 구분해 출력합니다. i번째 수는 길이가 L_i인 막대를 만드는 방법의 수입니다. 가능한 모든 입력에 대해 답이 10^9을 넘지 않음을 증명할 수 있습니다.

## 예제 입력
5<br/>
1 2 3 4 5<br/>
6<br/>
1 2 3 4 5 6<br/>

## 예제 출력
1 2 2 4 2 5<br/>

## 힌트
#### 길이 6인 막대를 만드는 서로 다른 방법은 다음과 같습니다.
  - 길이가 1인 막대를 고릅니다. 길이를 2배 늘려 길이를 2로 만듭니다. 길이를 3배 늘려 길이를 6으로 만듭니다.
  - 길이가 1인 막대를 고릅니다. 길이를 3배 늘려 길이를 3로 만듭니다. 길이를 2배 늘려 길이를 6으로 만듭니다.
  - 길이가 1인 막대를 고릅니다. 길이를 6배 늘려 길이를 6으로 만듭니다.
  - 길이가 2인 막대를 고릅니다. 길이를 3배 늘려 길이를 6으로 만듭니다.
  - 길이가 3인 막대를 고릅니다. 길이를 2배 늘려 길이를 6으로 만듭니다.

## 문제 링크
https://www.acmicpc.net/problem/28437