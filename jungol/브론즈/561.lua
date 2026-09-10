local input = io.read()
local numbers = {}

local A = nil
local B = nil
-- A 100미만 가장 큰 수
-- B 100이상 가장 작은 수

for num in string.gmatch(input, "%S+") do -- 입력받은 값을 공백으로 나눔
    table.insert(numbers, tonumber(num)) -- 나눈 값을 배열에 저장
end

for i = 1, #numbers, 1 do
    local current = numbers[i]

    if current < 100 then
        if A == nil or current > A then
            A= current
        end

    else
        if B == nil or current < B then
            B = current
        end
    end
end

print(string.format("%d %d", A or 100, B or 100))
