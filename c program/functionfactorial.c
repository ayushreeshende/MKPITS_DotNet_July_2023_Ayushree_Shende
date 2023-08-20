#include<stdio.h>
void factorial(int num,int fact)
{
		while(num>0)
		{
	 fact=fact*num;
	 num=num-1;
}
	printf("fact=%d",fact);
}

void main()
{

	int num,fact=1;
	printf("enter a no");
	scanf("%d",&num);
	factorial(num,fact);
}

//Algorithm:
//	1)start
//	2)define the function factorial
//	3)while(num>0)
//	4) fact=fact*num
//	5)go to main function
//	6)accept 2 no
//	7)call the function factorial(num,fact)
//	8)stop
