#include <stdio.h>

int main()
{
    int n;
    scanf("%d", &n);

    for (int i = 0; i < 2 * n - 1; i++)
    {
        int space;

        if (i < n)
            space = n - 1 - i;
        else
            space = i - (n - 1);

        int star = 2 * (n - space) - 1;

        for (int j = 0; j < space; j++)
            printf(" ");

        for (int j = 0; j < star; j++)
            printf("*");

        for (int j = 0; j < space; j++)
            printf(" ");

        printf("\n");
    }

    return 0;
}