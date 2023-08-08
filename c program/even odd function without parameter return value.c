//function without parameter and return a value
#include<stdio.h>
int check()
{
	int num,rem=0;
	printf("Enter no=");
	scanf("%d",&num);
	if(num%2==0)
	{
		printf("This is a even no");
	}
	else
	{
		printf("This is a odd no");
	}                                    
	return 0;                                                                                                                                                                                                                                     
  }
void main()
{
	int num, rem=0;
	check(num,rem);
}
