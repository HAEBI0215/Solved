local input = io.read()
local arr = {}

local sum = 0
local avg = 0
local count = 0

for num in string.gmatch(input, "%S+") do
    table.insert(arr, tonumber(num))
end

for i = 1, #arr, 1 do
    if arr[i] == 0 then
        break
    end

    if arr[i] % 5 == 0 then
        sum = sum + arr[i]
        count = count + 1
    end
end

avg = sum / count

print(string.format("Multiples of 5 : %d", count))
print(string.format("sum : %d", sum))
print(string.format("avg : %.1f", avg))
