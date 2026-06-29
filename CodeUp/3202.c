#include <stdio.h>

char tree[10001];
int len;

void DoRuning(int index)
{
    if (index >= len)
        return;

    printf ("%c", tree[index]);

    DoRuning (index * 2 + 1);
    DoRuning (index * 2 + 2); 
}

int main()
{
    scanf ("%s", tree);

    while (tree[len] != '\0')
        len++;

    DoRuning(0);

    return 0;
}