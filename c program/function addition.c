#include<stdio.h>
void addition(int n1,int n2)
{
	int result=n1+n2;
	printf("addition of 2 no=%d",result);
	
}
void main()
{
	int num1,num2;
	printf("enter 2 no");
	scanf("%d%d",&num1,&num2);
	addition(num1,num2);
	printf("\nbye");
}



//Algorithm:
//	1)start
//	2)define the function addition
//	3)declare num1,num2
//	4)print addition of 2 no
//	5)go to main function
//	6)accept 2 no
//	7)call the function
//	8)print bye
//	9)stop
