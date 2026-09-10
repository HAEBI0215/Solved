-- 두 정수 A B
-- A부터 B까지의 구구단을 차례로 출력
-- 단 A가 B보다 클 수도 있음
-- 이 경우에도 A부터 B까지 순서대로 출력(아마 역순?)

-- 두 정수 A, B 입력
local A, B = io.read("*n", "*n")

-- 구구단 진행 방향
local direction = 1

if A > B then
	direction = -1
end

local currentDan = A

while true do
	-- 현재 단의 1~9 출력
	for i = 1, 9 do
		print(string.format("%d * %d = %d", currentDan,i, currentDan * i))
	end

	-- B단까지 출력했다면 종료
	if currentDan == B then
		break
	end

	-- 단과 단 사이 빈 줄
	print()

	-- 다음 단으로 이동
	currentDan = currentDan + direction
end