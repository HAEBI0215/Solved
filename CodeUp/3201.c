#include <stdio.h>

char tree[10001];
int len = 0;

void inorder(int idex)
{
    if (idex >= len)
        return;

    inorder(idex * 2 + 1);
    printf("%c", tree[idex]);
    inorder(idex * 2 + 2);
}

int main()
{
    scanf("%s", tree);

    while (tree[len] != '\0')
        len++;

    inorder(0);

    return 0;
}