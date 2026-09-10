local input = io.read()
local numbers = {}

local A = 0
local B = 0
-- A 짝수번째 합
-- B 홀수번째 합

for num in string.gmatch(input, "%S+") do -- 입력받은 값을 공백으로 나눔
    table.insert(numbers, tonumber(num)) -- 나눈 값을 배열에 저장
end

for i = 2, #numbers, 2 do
    A = A + numbers[i]
end

for i = 1, #numbers, 2 do
    B = B + numbers[i]
end

B = B / 5

print(string.format("sum : %d", A))
print(string.format("avg : %.1f", B))
