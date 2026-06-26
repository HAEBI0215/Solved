#include <stdio.h>

char tree[10001];
int len = 0;

void postorder(int idex)
{
    if (idex >= len)
        return;

    postorder(idex * 2 + 1);
    postorder(idex * 2 + 2);
    printf("%c", tree[idex]);
}

int main()
{
    scanf("%s", tree);

    while (tree[len] != '\0')
        len++;

    postorder(0);

    return 0;
}