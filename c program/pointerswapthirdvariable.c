#include<stdio.h>
void main()
{
	int n1=5;
	int n2=7;
	int*p1=&n1;
	int*p2=&n2;
	printf("Before swap *p1=%d,*p2=%d",*p1,*p2);
	*p1=*p1+*p2;
	*p2=*p1-*p2;
	*p1=*p1-*p2;
	printf("After swap*p1=%d,*p2=%d",*p1,*p2);
}
