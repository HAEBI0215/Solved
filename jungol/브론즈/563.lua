local input = io.read()
local numbers = {}

for num in string.gmatch(input, "%S+") do -- 입력받은 값을 공백으로 나눔
    table.insert(numbers, tonumber(num)) -- 나눈 값을 배열에 저장
end

table.sort(numbers, function(a, b)
    return a > b
end)

print(table.concat(numbers, " "))
