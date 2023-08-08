#include<stdio.h>
int main()
{
	int num;
	printf("enter num:");
	scanf("%d",&num);
	switch(num%2==0)
	{
		case1:
			printf("num is even=%d",num);
			break;
			default:
				printf("num is odd=%d",num);
				break;
	}
}
