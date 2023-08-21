#include<stdio.h>
void area()
{
int side,result;
printf("enter side");
scanf("%d",&side);
result=side*side;
return result;
}
void main()
{
	int result;
	result=area;
	printf("area of square=%d",result);
	printf("do you want to continue,press 'y'");
	fflush(stdin);
	scanf("%c",&ch);
	{
		while(ch=='y');
	}
}

