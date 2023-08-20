#include<stdio.h>
void table(int num,int i)
{
	for(i=1;i<=10;i++)
	{
   
		printf("%d*%d=%d\n",num,i,num*i);
	}
}
	

void main()
{

	int num,i=1;
	printf("enter number=");
	scanf("%d",&num);
	table(num,i);
}


//Algorithm:
//	1)start 
//	2)define the function table
//	3)initialize variable i=1,i<=10,i++
//	4)then print num*i=result
//	5)exit loop end the function
//	6)call the table function
//	7)stop






