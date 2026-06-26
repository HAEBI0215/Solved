#include <stdio.h>

char tree[10001];
int len;

void preorder(int idx)
{
    if (idx >= len)
        return;

    printf("%c", tree[idx]);

    preorder(idx * 2 + 1);
    preorder(idx * 2 + 2); 
}

int main()
{
    scanf("%s", tree);

    while(tree[len] != '\0')
        len++;

    preorder(0);

    return 0;
}