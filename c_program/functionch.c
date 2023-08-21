#include<stdio.h>
void addition(int n1,int n2)
{
	int result=n1+n2;
	printf("addition of 2 no=%d",result);
}
void main()
{

char ch='y';
do
{
	int num1,num2;
	printf("enter 2 no");
	scanf("%d%d",&num1,&num2);
	addition(num1,num2);
	printf("do you want to continue,press y");
	fflush(stdin);
	scanf("%c",&ch);
}
while(ch=='y');
}



//Algorithm:
//	1)start
//	2)define function addition
//	3)declare num1,num2,result
//	4)print addition of 2 no
//	5)go to the main function
//	6)accept 2 no
//	7)while(ch==y)
//	8)stop
