#include<stdio.h>
void main()
{
	int num=5;
	int*ptr=&num;
	printf("address=%x\n",ptr);
	printf("value at address=%d",*ptr);
}
