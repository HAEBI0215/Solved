local n = io.read("*n")
local score = {}

if n > 20 then
    return
end

for i = 1, n do
    score[i] = io.read("*n")
end

table.sort(score, function(a, b)
    return a > b
end)

for i = 1, n do
    print(score[i])
end
