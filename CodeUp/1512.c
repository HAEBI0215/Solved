#include <stdio.h>

int main()
{
    int n;
    int x, y;

    scanf("%d", &n);
    scanf("%d %d", &x, &y);
    x--;
    y--;

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int value = abs(i -x) + abs(j - y) + 1;
            printf("%d ", value);
        }

        printf("\n");
    }

    return 0;
}